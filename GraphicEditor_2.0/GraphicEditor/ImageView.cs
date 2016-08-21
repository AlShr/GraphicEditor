using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class ImageView : Form
    {
        /// <summary>
        /// The BackgroundWorker component follows the principles of the EAP pattern; 
        /// it exposes a series of events to represent state changes 
        /// during the life of the asynchronous operation.
        /// </summary>
        private BackgroundWorker backgroundWorker;
        private Bitmap bmp;
        private Point p;

        public ImageView()
        {
            InitializeComponent();
            this.AsyncProgressBar.Maximum = pictureBox1.Width;
            p = new Point(0, 0);
        }

        public static void DoneWritting(IAsyncResult state)
        {
            FileStream f = (state.AsyncState as FileStream);
            int n = f.EndRead(state);
            f.Close();

        }

        private void startProcesing(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                FileInfo fi = new FileInfo(ofd.FileName);
                long size = fi.Length;
                byte[] data = new byte[size];
                IAsyncResult res = fs.BeginRead(data, 0, data.Length,
                    new AsyncCallback(DoneWritting), fs);
                if (res.AsyncWaitHandle.WaitOne())
                {
                    MemoryStream ms = new MemoryStream(data);
                    Image img = Image.FromStream(ms);
                    bmp = new Bitmap(img, (int)pictureBox1.Width, (int)pictureBox1.Height);
                }

                backgroundWorker = new BackgroundWorker();

                backgroundWorker.DoWork += performProcessing;
                backgroundWorker.RunWorkerCompleted += processingDone;
                backgroundWorker.ProgressChanged += updateProgress;

                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.WorkerSupportsCancellation = true;

                backgroundWorker.RunWorkerAsync();
            }

        }

        private void updateProgress(object sender, ProgressChangedEventArgs e)
        {
            this.AsyncProgressBar.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// On background thread event handler the DoWork event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void performProcessing(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    Color curcolor = bmp.GetPixel(i, j);
                    Bitmap cbmp = new Bitmap(1, 1);
                    cbmp.SetPixel(0, 0, curcolor);
                    int modeSleep;
                    int.TryParse(tbMode.Text, out modeSleep);
                    Thread.Sleep(modeSleep);

                    backgroundWorker.ReportProgress(i);
                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    Graphics g = pictureBox1.CreateGraphics();
                    g.DrawImage(cbmp, i + p.X, j + p.Y);
                }
            }
            this.AsyncProgressBar.Value = pictureBox1.Width;
            e.Result = "Load!";

        }

        /// <summary>
        /// On background thread event handler the RunWorkerCompleted event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void processingDone(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                this.ResultTextBlock.Text = e.Error.Message;
            else if (e.Cancelled)
                this.ResultTextBlock.Text = "CANCELLED";
            else
                this.ResultTextBlock.Text = e.Result.ToString();

        }

        /// <summary>
        /// Politely ask for the background worker to cancel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelProcessing(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }
    }
}
