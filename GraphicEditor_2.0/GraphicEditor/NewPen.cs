using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GraphicEditor
{
    public partial class NewPen : Form
    {
        private Pen pen= new Pen(Brushes.Aqua);

        public NewPen(Pen p)
        {
            InitializeComponent();
           
            this.BackColor = Color.LightSteelBlue;
            string[] dash = Enum.GetNames(typeof(DashStyle));
            foreach (string s in dash)
            {
                comboBox1.Items.Add(s);
            }
            
            pen = p;
            tb.Value = Convert.ToInt32(pen.Width);
            pcolor.BackColor = pen.Color;
            comboBox1.SelectedIndex = (int)pen.DashStyle;

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;           
        }

        private void pcolor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pcolor.BackColor = cd.Color;
               
            }
             panelpen.Invalidate();
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            lvalue.Text =tb.Value.ToString();
            panelpen.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelpen.Invalidate();
        }

        private void panelpen_Paint(object sender, PaintEventArgs e)
        {
            pen = new Pen(pcolor.BackColor, tb.Value);
            pen.DashStyle = (DashStyle)comboBox1.SelectedIndex;
            e.Graphics.DrawLine(pen, 0, panelpen.Height / 2, panelpen.Width, panelpen.Height / 2);
            
        }

        public Pen myPen
        {
            get { return pen; }
        }
    }
}
