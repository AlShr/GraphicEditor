using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace GraphicEditor
{
    public partial class NewBrush : Form
    {
        Brush brush;       

        public NewBrush()
        {
            InitializeComponent();

            this.BackColor = Color.LightSkyBlue;
            tabControl1.BackColor = Color.LightSkyBlue;

            //штриховая кисть Hatch Brush
            string[] hatch = Enum.GetNames(typeof(HatchStyle));
            cbhatch.Items.AddRange(hatch);
            cbhatch.SelectedIndex = 0;
            cbhatch.Items.RemoveAt(cbhatch.Items.Count - 1);
            cbhatch.Items.RemoveAt(cbhatch.Items.Count - 1);
            cbhatch.Items.RemoveAt(cbhatch.Items.Count - 1);

            //штриховая кисть Linear Gradient
            string[] linear = Enum.GetNames(typeof(LinearGradientMode));
            cbplinear.Items.AddRange(linear);
            cbplinear.SelectedIndex = 0;
        }

        private void pcolor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pcolor.BackColor = cd.Color;
                brush = new SolidBrush(pcolor.BackColor);
            }
        }

        public Brush MyBrush
        {
            get { return brush; }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;  
        }
    
       //////////////////////////////////////////////////////HATCH

        private void phatch1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                phatch1.BackColor = cd.Color;
                hatchdemo.Invalidate();
            }
        }

        private void phatch2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                phatch2.BackColor = cd.Color;
                hatchdemo.Invalidate();
            }
        }

        private void hatchdemo_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                brush = new HatchBrush((HatchStyle)cbhatch.SelectedIndex, phatch1.BackColor, phatch2.BackColor);
                e.Graphics.FillRectangle(brush, new Rectangle(0, 0, hatchdemo.Width, hatchdemo.Height));
            }
            catch (Exception ex)
            { 
            }
        }

        private void cbhatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            hatchdemo.Invalidate();
        }
         ////////////////////////////////////////////////////////Texture
        private void pb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png|*.png|jpg|*.jpg|gif|*.gif|ico|*.ico|icon|*.icon|All|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb.Image = Image.FromFile(ofd.FileName);
                ppicture.Invalidate();
            }
        }

        private void ppicture_Paint(object sender, PaintEventArgs e)
        {
            if (pb.Image == null) return;
            brush=new TextureBrush(pb.Image);
            e.Graphics.FillRectangle(brush, new Rectangle(0,0, ppicture.Width, ppicture.Height));
        }


        ////////////////////////////////////////////////////////Linear Gradient
       

        private void cbplinear_SelectedIndexChanged(object sender, EventArgs e)
        {
            linear_demo.Invalidate();
        }
        private void plinear1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                plinear1.BackColor = cd.Color;
                linear_demo.Invalidate();               
            }
        }  
        private void plinear2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                plinear2.BackColor = cd.Color;
                linear_demo.Invalidate();
            }
        }

        private void linear_demo_Paint(object sender, PaintEventArgs e)
        {
            brush = new LinearGradientBrush(new Rectangle(0, 0, (int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value), plinear1.BackColor, plinear2.BackColor, (LinearGradientMode)cbplinear.SelectedIndex);
            e.Graphics.FillRectangle(brush, 0, 0, linear_demo.Width, linear_demo.Height);
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            linear_demo.Invalidate();
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            linear_demo.Invalidate();
        }

 

        ////////////////////////////////////////////////////// Path Gradient
    }
}
