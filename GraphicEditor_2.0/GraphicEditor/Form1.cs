using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {      
        int click = 0; 
        public enum DrawMode { Line, Curve, Bizie, Rectangle, Ellipse, Font, FillEllipse, FillRectangle, None };//Собственное перечислен для пунктов меню Mode
        DrawMode mode = DrawMode.None;        
        List<Point> pts = new List<Point>();
        Pen cp = new Pen(Brushes.Red);
        Brush cb = new SolidBrush(Color.LightSteelBlue);
        List<Figure> fgs = new List<Figure>(); 
        Bitmap bitmap = null;     
        TextBox tb = null;
        Font font_ = new Font("Arial",12);
        Metafile mf = null;

        public Form1()
        {
            InitializeComponent();
            lmode.Text = "";        
        }

        /// <summary>
        /// Represents the method that will handle the Paint event of a Control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void area_Paint(object sender, PaintEventArgs e)
        {           
            foreach (Figure f in fgs)
            {
                f.Draw(e.Graphics);
            }

            Graphics g1 = ppen.CreateGraphics();
            g1.DrawLine(cp, 5, ppen.Height / 2, ppen.Width-5, ppen.Height / 2);
            g1.Dispose();

            Graphics g2 = pbrush.CreateGraphics();
            g2.FillRectangle(cb, new Rectangle(0,0,pbrush.Width, pbrush.Height));
            g2.Dispose();
        }

        /// <summary>
        /// Represent the mehod that will handle the MouseDown event
        /// Occurs when the mouse pointer is over the control 
        /// and a mouse button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">
        /// x:
        /// X-coordinate of mouse clicks in locations.
        /// y:
        /// Y-coordinate of mouse clicks in locations.

        private void area_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mode == DrawMode.Line)
                {
                    if (click == 0)
                    {
                        pts.Add(new Point(e.X, e.Y));
                        click++;
                    }
                    else
                    {
                        pts.Add(new Point(e.X, e.Y));
                        Figure f = new Line(pts, cp, cb);
                        f.GP.AddLine(pts[0], pts[1]);
                        fgs.Add(f); 
                        click = 0;
                        pts.Clear();
                    }
                }
                if (mode == DrawMode.Rectangle)
                {
                    if (click == 0)
                    {
                        pts.Add(new Point(e.X, e.Y));
                        click++;
                    }
                    else
                    {
                        pts.Add(new Point(e.X, e.Y));
                        pts = TopLeft(pts);
                        Figure f = new RectangleGE(pts, cp, cb);
                        f.GP.AddRectangle(new Rectangle(pts[0].X, pts[0].Y, pts[1].X - pts[0].X, pts[1].Y - pts[0].Y));
                        f.FB = new SolidBrush(pbrush.BackColor);
                            
                        fgs.Add(f); 
                        click = 0;
                        pts.Clear();
                    }
                }
                if (mode == DrawMode.FillRectangle)
                {
                    if (click == 0)
                    {
                        pts.Add(new Point(e.X, e.Y));
                        click++;
                    }
                    else
                    {
                        pts.Add(new Point(e.X, e.Y));
                        pts = TopLeft(pts);
                        Figure f = new FillRectGE(pts, cp, cb);
                        f.GP.AddRectangle(new Rectangle(pts[0].X, pts[0].Y, pts[1].X - pts[0].X, pts[1].Y - pts[0].Y));
                        f.FB = new SolidBrush(pbrush.BackColor);

                        fgs.Add(f); 
                        click = 0;
                        pts.Clear();
                    }
                }
                if (mode == DrawMode.Ellipse)
                {
                    if (click == 0)
                    {
                        pts.Add(new Point(e.X, e.Y));
                        click++;
                    }
                    else
                    {
                        pts.Add(new Point(e.X, e.Y));
                        pts = TopLeft(pts);
                        Figure f = new EllipseGE(pts, cp, cb);
                        f.GP.AddEllipse(new Rectangle(pts[0].X, pts[0].Y, pts[1].X - pts[0].X, pts[1].Y - pts[0].Y));
                        fgs.Add(f);
                        click = 0;
                        pts.Clear();
                    }
                }
                if (mode == DrawMode.FillEllipse)
                {
                    if (click == 0)
                    {
                        pts.Add(new Point(e.X, e.Y));
                        click++;
                    }
                    else
                    {
                        pts.Add(new Point(e.X, e.Y));
                        pts = TopLeft(pts);
                        Figure f = new FillEllipseGE(pts, cp, cb);
                        f.GP.AddEllipse(new Rectangle(pts[0].X, pts[0].Y, pts[1].X - pts[0].X, pts[1].Y - pts[0].Y));
                        fgs.Add(f);
                        click = 0;
                        pts.Clear();
                    }
                }
                if (mode == DrawMode.Bizie)
                {
                    if (click < 3)
                    {
                        pts.Add(new Point(e.X, e.Y));
                        click++;
                    }
                    else
                    {
                        pts.Add(new Point(e.X, e.Y));
                        Figure f = new BizieGE(pts, cp, cb);
                        f.GP.AddBezier(pts[0], pts[1], pts[2], pts[3]);
                        fgs.Add(f); 
                        click = 0;
                        pts.Clear();
                    }
                }
                if (mode == DrawMode.Curve)
                {
                    if (click == 0)
                    {
                        pts.Add(new Point(e.X, e.Y));
                        click++;
                    }                   
                }
                if (mode == DrawMode.Font)
                {
                    FontDialog fd = new FontDialog();
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                      font_ = fd.Font;
                      tb = new TextBox();
                      tb.Font = font_;                     
                      tb.Location = new Point(e.X, e.Y);

                      pts.Add(new Point(e.X, e.Y));

                      tb.Size = new Size(area.Width, font_.Height + 5);                      
                      area.Controls.Add(tb);
                      tb.Focus();
                      tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
                       
                    }
                }
            }        

            area.Invalidate();
        }

        private void m_line_Click(object sender, EventArgs e)
        {
            mode = DrawMode.Line;
            lmode.Text = "Line";
        }

        private void m_curve_Click(object sender, EventArgs e)
        {
            mode = DrawMode.Curve;
            lmode.Text = "Curve";
        }

        private void m_bizier_Click(object sender, EventArgs e)
        {
            mode = DrawMode.Bizie;
            lmode.Text = "Bizie";
        }

        private void m_rectangle_Click(object sender, EventArgs e)
        {
            mode = DrawMode.Rectangle;
            lmode.Text = "Rectangle";
        }

        private void m_ellipse_Click(object sender, EventArgs e)
        {
            mode = DrawMode.Ellipse;
            lmode.Text = "Ellipse";
        }

        private void m_font_Click(object sender, EventArgs e)
        {
            mode = DrawMode.Font;
            lmode.Text = "Font";
        }

        private void m_fillellipse_Click(object sender, EventArgs e)
        {
            mode = DrawMode.FillEllipse;
            lmode.Text = "FillEllipse";
        }

        private void m_fillrectangle_Click(object sender, EventArgs e)
        {
            mode = DrawMode.FillRectangle;
            lmode.Text = "FillRectangle";
        }

        private List<Point> TopLeft(List<Point> lp)
        {
            Point topleft = new Point(0, 0);
            Point bottomrigth = new Point(0, 0);
            if (lp[1].Y < lp[0].Y)
            {
                topleft.Y = lp[1].Y;
                bottomrigth.Y = lp[0].Y;
            }
            else
            {
                topleft.Y = lp[0].Y;
                bottomrigth.Y = lp[1].Y;
            }
            if (lp[1].X < lp[0].X)
            {
                topleft.X = lp[1].X;
                bottomrigth.X = lp[0].X;
            }
            else
            {
                topleft.X = lp[0].X;
                bottomrigth.X = lp[1].X;
            }
            lp[0] = topleft;
            lp[1] = bottomrigth;
            return lp;
        }

        private void m_pen_Click(object sender, EventArgs e)
        {
            NewPen np = new  NewPen(cp);
            if (np.ShowDialog() == DialogResult.OK)
            {
                ppen.Invalidate();
                cp = np.myPen;             
            }
        }

        private void m_brush_Click(object sender, EventArgs e)
        {
            NewBrush nb =new NewBrush();
            if (nb.ShowDialog() == DialogResult.OK)
            {
                cb = nb.MyBrush;            
            }
        }

        private void m_image_Click(object sender, EventArgs e)
        {
            ImageView iv = new ImageView();
            iv.ShowDialog();
        }

        private void area_MouseMove(object sender, MouseEventArgs e)
        {
            if (mode == DrawMode.Curve && click!=0)
            {
                pts.Add(new Point(e.X, e.Y));
                click++;
           }
        }

        private void area_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mode == DrawMode.Curve)
                {
                    if (click != 0)
                    {
                        pts.Add(new Point(e.X, e.Y));
                        Figure f = new CurveGE(pts, cp, cb);
                        f.GP.AddCurve(pts.ToArray(),1.2f);
                        fgs.Add(f);                         
                        click = 0;
                        pts.Clear();
                    }
                   
                }
            }
            area.Invalidate();
        }

        private void m_save_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            area.Refresh();
            bitmap = new Bitmap(area.Width, area.Height);

           
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(PointToScreen(area.Location), new Point(0, 0), new Size(area.Width, area.Height));
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "emf|*.emf|wmf|*.wmf|jpg|*.jpg|png|*.png|tiff|*.tiff|All|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if(sfd.FileName.EndsWith("emf")||sfd.FileName.EndsWith("wmf"))
                    {
                     Graphics ga= area.CreateGraphics();
                        IntPtr hdc = ga.GetHdc();
                        try
                        {
                         mf= new Metafile(sfd.FileName, hdc);
                        }
                        catch(Exception ex)
                        {
                        MessageBox.Show(ex.Message);
                            return;
                        }

                        Graphics gmf= Graphics.FromImage(mf);
                        gmf.SmoothingMode= SmoothingMode.HighQuality;
                        foreach(Figure f in fgs)
                        {
                         f.Draw(gmf);
                        }
                        ga.ReleaseHdc(hdc);
                        ga.Dispose();
                        gmf.Dispose();
                    
                    }
                    else
                    {
                        bitmap.Save(sfd.FileName);
                    }               
                }
            }
            menuStrip1.Visible = true;

        }

        private void m_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg|png|*.png|tiff|*.tiff|All|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap original = new Bitmap(ofd.FileName);
                bitmap = new Bitmap(original, area.Width, area.Height);
                area.BackgroundImage = bitmap;
            }
        }

        private void area_SizeChanged(object sender, EventArgs e)
        {
            if (bitmap == null) return;
            if (area.Height == 0 || area.Width == 0) return;
            Bitmap original = new Bitmap(area.Width, area.Height);
            using (Graphics g = Graphics.FromImage(original))
            {
                g.DrawImage(bitmap, new Rectangle(0, 0, area.Width, area.Height));
                area.BackgroundImage = original;
            }

        }

        private void area_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void m_new_Click(object sender, EventArgs e)
        {
            Graphics g = area.CreateGraphics();
            g.Clear(area.BackColor);
            fgs.Clear();            
            pts.Clear();
            click = 0;
            g.Dispose();
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (mode == DrawMode.Font)
                {
                    fgs.Add(new StringGE(pts, cb, tb.Text, font_));
                    pts.Clear();
                    tb.Dispose();
                }
            }
        }

        private void m_version_Click(object sender, EventArgs e)
        {
            Version about = new Version();
            about.ShowDialog();
        }
        
        private void mpageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void mpreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void mprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;


            Graphics g = e.Graphics;
            if (fgs.Count == 0)
            {
                if(bitmap!= null)
                {
                    g.DrawImage(bitmap, new Point(x, y));
                }              
            }
            else
            { 
                foreach (Figure f in fgs)
                {
                    e.Graphics.TranslateTransform(x, y);
                    f.Draw(g);                   
                }
            }
            
        }     
    }
}
