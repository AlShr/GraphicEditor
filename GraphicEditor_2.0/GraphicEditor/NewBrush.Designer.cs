namespace GraphicEditor
{
    partial class NewBrush
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Solid = new System.Windows.Forms.TabPage();
            this.pcolor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Hatch = new System.Windows.Forms.TabPage();
            this.hatchdemo = new System.Windows.Forms.Panel();
            this.phatch2 = new System.Windows.Forms.Panel();
            this.phatch1 = new System.Windows.Forms.Panel();
            this.cbhatch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Texture = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.ppicture = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.Linear_Gradient = new System.Windows.Forms.TabPage();
            this.linear_demo = new System.Windows.Forms.Panel();
            this.plinear2 = new System.Windows.Forms.Panel();
            this.plinear1 = new System.Windows.Forms.Panel();
            this.cbplinear = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Path_Gradient = new System.Windows.Forms.TabPage();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.Solid.SuspendLayout();
            this.Hatch.SuspendLayout();
            this.Texture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.Linear_Gradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Solid);
            this.tabControl1.Controls.Add(this.Hatch);
            this.tabControl1.Controls.Add(this.Texture);
            this.tabControl1.Controls.Add(this.Linear_Gradient);
            this.tabControl1.Controls.Add(this.Path_Gradient);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // Solid
            // 
            this.Solid.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Solid.Controls.Add(this.pcolor);
            this.Solid.Controls.Add(this.label1);
            this.Solid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Solid.Location = new System.Drawing.Point(4, 22);
            this.Solid.Name = "Solid";
            this.Solid.Padding = new System.Windows.Forms.Padding(3);
            this.Solid.Size = new System.Drawing.Size(448, 345);
            this.Solid.TabIndex = 0;
            this.Solid.Text = "Solid";
            // 
            // pcolor
            // 
            this.pcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcolor.Location = new System.Drawing.Point(6, 114);
            this.pcolor.Name = "pcolor";
            this.pcolor.Size = new System.Drawing.Size(434, 140);
            this.pcolor.TabIndex = 1;
            this.pcolor.Click += new System.EventHandler(this.pcolor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Color";
            // 
            // Hatch
            // 
            this.Hatch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Hatch.Controls.Add(this.hatchdemo);
            this.Hatch.Controls.Add(this.phatch2);
            this.Hatch.Controls.Add(this.phatch1);
            this.Hatch.Controls.Add(this.cbhatch);
            this.Hatch.Controls.Add(this.label4);
            this.Hatch.Controls.Add(this.label3);
            this.Hatch.Controls.Add(this.label2);
            this.Hatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hatch.Location = new System.Drawing.Point(4, 22);
            this.Hatch.Name = "Hatch";
            this.Hatch.Padding = new System.Windows.Forms.Padding(3);
            this.Hatch.Size = new System.Drawing.Size(448, 345);
            this.Hatch.TabIndex = 1;
            this.Hatch.Text = "Hatch";
            // 
            // hatchdemo
            // 
            this.hatchdemo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hatchdemo.Location = new System.Drawing.Point(19, 208);
            this.hatchdemo.Name = "hatchdemo";
            this.hatchdemo.Size = new System.Drawing.Size(412, 100);
            this.hatchdemo.TabIndex = 6;
            this.hatchdemo.Paint += new System.Windows.Forms.PaintEventHandler(this.hatchdemo_Paint);
            // 
            // phatch2
            // 
            this.phatch2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phatch2.Location = new System.Drawing.Point(195, 130);
            this.phatch2.Name = "phatch2";
            this.phatch2.Size = new System.Drawing.Size(163, 32);
            this.phatch2.TabIndex = 5;
            this.phatch2.Click += new System.EventHandler(this.phatch2_Click);
            // 
            // phatch1
            // 
            this.phatch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phatch1.Location = new System.Drawing.Point(195, 69);
            this.phatch1.Name = "phatch1";
            this.phatch1.Size = new System.Drawing.Size(163, 32);
            this.phatch1.TabIndex = 4;
            this.phatch1.Click += new System.EventHandler(this.phatch1_Click);
            // 
            // cbhatch
            // 
            this.cbhatch.FormattingEnabled = true;
            this.cbhatch.Location = new System.Drawing.Point(195, 18);
            this.cbhatch.Name = "cbhatch";
            this.cbhatch.Size = new System.Drawing.Size(163, 24);
            this.cbhatch.TabIndex = 3;
            this.cbhatch.SelectedIndexChanged += new System.EventHandler(this.cbhatch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Цвет фона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Цвет штриховки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Стиль штриховки";
            // 
            // Texture
            // 
            this.Texture.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Texture.Controls.Add(this.label5);
            this.Texture.Controls.Add(this.ppicture);
            this.Texture.Controls.Add(this.pb);
            this.Texture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Texture.Location = new System.Drawing.Point(4, 22);
            this.Texture.Name = "Texture";
            this.Texture.Size = new System.Drawing.Size(448, 345);
            this.Texture.TabIndex = 2;
            this.Texture.Text = "Texture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select";
            // 
            // ppicture
            // 
            this.ppicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ppicture.Location = new System.Drawing.Point(206, 72);
            this.ppicture.Name = "ppicture";
            this.ppicture.Size = new System.Drawing.Size(234, 158);
            this.ppicture.TabIndex = 1;
            this.ppicture.Paint += new System.Windows.Forms.PaintEventHandler(this.ppicture_Paint);
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Location = new System.Drawing.Point(8, 72);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(192, 158);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // Linear_Gradient
            // 
            this.Linear_Gradient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Linear_Gradient.Controls.Add(this.numericUpDownHeight);
            this.Linear_Gradient.Controls.Add(this.numericUpDownWidth);
            this.Linear_Gradient.Controls.Add(this.label10);
            this.Linear_Gradient.Controls.Add(this.label9);
            this.Linear_Gradient.Controls.Add(this.linear_demo);
            this.Linear_Gradient.Controls.Add(this.plinear2);
            this.Linear_Gradient.Controls.Add(this.plinear1);
            this.Linear_Gradient.Controls.Add(this.cbplinear);
            this.Linear_Gradient.Controls.Add(this.label6);
            this.Linear_Gradient.Controls.Add(this.label7);
            this.Linear_Gradient.Controls.Add(this.label8);
            this.Linear_Gradient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Linear_Gradient.Location = new System.Drawing.Point(4, 22);
            this.Linear_Gradient.Name = "Linear_Gradient";
            this.Linear_Gradient.Size = new System.Drawing.Size(448, 345);
            this.Linear_Gradient.TabIndex = 3;
            this.Linear_Gradient.Text = "Linear Gradient";
            // 
            // linear_demo
            // 
            this.linear_demo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linear_demo.Location = new System.Drawing.Point(24, 217);
            this.linear_demo.Name = "linear_demo";
            this.linear_demo.Size = new System.Drawing.Size(412, 100);
            this.linear_demo.TabIndex = 13;
            this.linear_demo.Paint += new System.Windows.Forms.PaintEventHandler(this.linear_demo_Paint);
            // 
            // plinear2
            // 
            this.plinear2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plinear2.Location = new System.Drawing.Point(132, 139);
            this.plinear2.Name = "plinear2";
            this.plinear2.Size = new System.Drawing.Size(163, 32);
            this.plinear2.TabIndex = 12;
            this.plinear2.Click += new System.EventHandler(this.plinear2_Click);
            // 
            // plinear1
            // 
            this.plinear1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plinear1.Location = new System.Drawing.Point(132, 78);
            this.plinear1.Name = "plinear1";
            this.plinear1.Size = new System.Drawing.Size(163, 32);
            this.plinear1.TabIndex = 11;
            this.plinear1.Click += new System.EventHandler(this.plinear1_Click);
            // 
            // cbplinear
            // 
            this.cbplinear.FormattingEnabled = true;
            this.cbplinear.Location = new System.Drawing.Point(132, 27);
            this.cbplinear.Name = "cbplinear";
            this.cbplinear.Size = new System.Drawing.Size(163, 24);
            this.cbplinear.TabIndex = 10;
            this.cbplinear.SelectedIndexChanged += new System.EventHandler(this.cbplinear_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цвет фона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Цвет градиент";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Стиль градиент";
            // 
            // Path_Gradient
            // 
            this.Path_Gradient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Path_Gradient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Path_Gradient.Location = new System.Drawing.Point(4, 22);
            this.Path_Gradient.Name = "Path_Gradient";
            this.Path_Gradient.Size = new System.Drawing.Size(448, 345);
            this.Path_Gradient.TabIndex = 4;
            this.Path_Gradient.Text = "Path Gradient";
            // 
            // bt_OK
            // 
            this.bt_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_OK.Location = new System.Drawing.Point(42, 377);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(90, 30);
            this.bt_OK.TabIndex = 1;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Cancel.Location = new System.Drawing.Point(299, 377);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(90, 30);
            this.bt_Cancel.TabIndex = 2;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ширина:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Высота:";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(369, 30);
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownWidth.TabIndex = 16;
            this.numericUpDownWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(369, 83);
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownHeight.TabIndex = 17;
            this.numericUpDownHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDownHeight_ValueChanged);
            // 
            // NewBrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 420);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewBrush";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewBrush";
            this.tabControl1.ResumeLayout(false);
            this.Solid.ResumeLayout(false);
            this.Solid.PerformLayout();
            this.Hatch.ResumeLayout(false);
            this.Hatch.PerformLayout();
            this.Texture.ResumeLayout(false);
            this.Texture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.Linear_Gradient.ResumeLayout(false);
            this.Linear_Gradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Solid;
        private System.Windows.Forms.TabPage Hatch;
        private System.Windows.Forms.TabPage Texture;
        private System.Windows.Forms.TabPage Linear_Gradient;
        private System.Windows.Forms.TabPage Path_Gradient;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Panel pcolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel hatchdemo;
        private System.Windows.Forms.Panel phatch2;
        private System.Windows.Forms.Panel phatch1;
        private System.Windows.Forms.ComboBox cbhatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ppicture;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel linear_demo;
        private System.Windows.Forms.Panel plinear2;
        private System.Windows.Forms.Panel plinear1;
        private System.Windows.Forms.ComboBox cbplinear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}