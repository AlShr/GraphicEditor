namespace GraphicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_file = new System.Windows.Forms.ToolStripMenuItem();
            this.m_new = new System.Windows.Forms.ToolStripMenuItem();
            this.m_open = new System.Windows.Forms.ToolStripMenuItem();
            this.m_save = new System.Windows.Forms.ToolStripMenuItem();
            this.m_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mode = new System.Windows.Forms.ToolStripMenuItem();
            this.m_line = new System.Windows.Forms.ToolStripMenuItem();
            this.m_curve = new System.Windows.Forms.ToolStripMenuItem();
            this.m_bizier = new System.Windows.Forms.ToolStripMenuItem();
            this.m_rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ellipse = new System.Windows.Forms.ToolStripMenuItem();
            this.m_font = new System.Windows.Forms.ToolStripMenuItem();
            this.fillEllipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pen = new System.Windows.Forms.ToolStripMenuItem();
            this.m_brush = new System.Windows.Forms.ToolStripMenuItem();
            this.m_image = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mpageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mpreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mprint = new System.Windows.Forms.ToolStripMenuItem();
            this.m_about = new System.Windows.Forms.ToolStripMenuItem();
            this.m_version = new System.Windows.Forms.ToolStripMenuItem();
            this.area = new System.Windows.Forms.Panel();
            this.ppen = new System.Windows.Forms.Panel();
            this.pbrush = new System.Windows.Forms.Panel();
            this.lmode = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_file,
            this.m_mode,
            this.toolsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.m_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_file
            // 
            this.m_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_new,
            this.m_open,
            this.m_save,
            this.m_saveas,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.m_file.Name = "m_file";
            this.m_file.Size = new System.Drawing.Size(37, 20);
            this.m_file.Text = "File";
            // 
            // m_new
            // 
            this.m_new.Name = "m_new";
            this.m_new.Size = new System.Drawing.Size(152, 22);
            this.m_new.Text = "New";
            this.m_new.Click += new System.EventHandler(this.m_new_Click);
            // 
            // m_open
            // 
            this.m_open.Name = "m_open";
            this.m_open.Size = new System.Drawing.Size(152, 22);
            this.m_open.Text = "Open";
            this.m_open.Click += new System.EventHandler(this.m_open_Click);
            // 
            // m_save
            // 
            this.m_save.Name = "m_save";
            this.m_save.Size = new System.Drawing.Size(152, 22);
            this.m_save.Text = "Save";
            this.m_save.Click += new System.EventHandler(this.m_save_Click);
            // 
            // m_saveas
            // 
            this.m_saveas.Name = "m_saveas";
            this.m_saveas.Size = new System.Drawing.Size(152, 22);
            this.m_saveas.Text = "Save as";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // m_mode
            // 
            this.m_mode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_line,
            this.m_curve,
            this.m_bizier,
            this.m_rectangle,
            this.m_ellipse,
            this.m_font,
            this.fillEllipseToolStripMenuItem});
            this.m_mode.Name = "m_mode";
            this.m_mode.Size = new System.Drawing.Size(50, 20);
            this.m_mode.Text = "Mode";
            // 
            // m_line
            // 
            this.m_line.Name = "m_line";
            this.m_line.Size = new System.Drawing.Size(152, 22);
            this.m_line.Text = "Line";
            this.m_line.Click += new System.EventHandler(this.m_line_Click);
            // 
            // m_curve
            // 
            this.m_curve.Name = "m_curve";
            this.m_curve.Size = new System.Drawing.Size(152, 22);
            this.m_curve.Text = "Curve";
            this.m_curve.Click += new System.EventHandler(this.m_curve_Click);
            // 
            // m_bizier
            // 
            this.m_bizier.Name = "m_bizier";
            this.m_bizier.Size = new System.Drawing.Size(152, 22);
            this.m_bizier.Text = "Bizier";
            this.m_bizier.Click += new System.EventHandler(this.m_bizier_Click);
            // 
            // m_rectangle
            // 
            this.m_rectangle.Name = "m_rectangle";
            this.m_rectangle.Size = new System.Drawing.Size(152, 22);
            this.m_rectangle.Text = "Rectangle";
            this.m_rectangle.Click += new System.EventHandler(this.m_rectangle_Click);
            // 
            // m_ellipse
            // 
            this.m_ellipse.Name = "m_ellipse";
            this.m_ellipse.Size = new System.Drawing.Size(152, 22);
            this.m_ellipse.Text = "Ellipse";
            this.m_ellipse.Click += new System.EventHandler(this.m_ellipse_Click);
            // 
            // m_font
            // 
            this.m_font.Name = "m_font";
            this.m_font.Size = new System.Drawing.Size(152, 22);
            this.m_font.Text = "Font";
            this.m_font.Click += new System.EventHandler(this.m_font_Click);
            // 
            // fillEllipseToolStripMenuItem
            // 
            this.fillEllipseToolStripMenuItem.Name = "fillEllipseToolStripMenuItem";
            this.fillEllipseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fillEllipseToolStripMenuItem.Text = "FillEllipse";
            this.fillEllipseToolStripMenuItem.Click += new System.EventHandler(this.m_fillellipse_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_pen,
            this.m_brush,
            this.m_image});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // m_pen
            // 
            this.m_pen.Name = "m_pen";
            this.m_pen.Size = new System.Drawing.Size(152, 22);
            this.m_pen.Text = "Pen ...";
            this.m_pen.Click += new System.EventHandler(this.m_pen_Click);
            // 
            // m_brush
            // 
            this.m_brush.Name = "m_brush";
            this.m_brush.Size = new System.Drawing.Size(152, 22);
            this.m_brush.Text = "Brush ...";
            this.m_brush.Click += new System.EventHandler(this.m_brush_Click);
            // 
            // m_image
            // 
            this.m_image.Name = "m_image";
            this.m_image.Size = new System.Drawing.Size(152, 22);
            this.m_image.Text = "Image...";
            this.m_image.Click += new System.EventHandler(this.m_image_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mpageSetup,
            this.mpreview,
            this.mprint});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // mpageSetup
            // 
            this.mpageSetup.Name = "mpageSetup";
            this.mpageSetup.Size = new System.Drawing.Size(152, 22);
            this.mpageSetup.Text = "PageSetup";
            this.mpageSetup.Click += new System.EventHandler(this.mpageSetup_Click);
            // 
            // mpreview
            // 
            this.mpreview.Name = "mpreview";
            this.mpreview.Size = new System.Drawing.Size(152, 22);
            this.mpreview.Text = "Preview";
            this.mpreview.Click += new System.EventHandler(this.mpreview_Click);
            // 
            // mprint
            // 
            this.mprint.Name = "mprint";
            this.mprint.Size = new System.Drawing.Size(152, 22);
            this.mprint.Text = "Print";
            this.mprint.Click += new System.EventHandler(this.mprint_Click);
            // 
            // m_about
            // 
            this.m_about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_version});
            this.m_about.Name = "m_about";
            this.m_about.Size = new System.Drawing.Size(52, 20);
            this.m_about.Text = "About";
            // 
            // m_version
            // 
            this.m_version.Name = "m_version";
            this.m_version.Size = new System.Drawing.Size(112, 22);
            this.m_version.Text = "Version";
            this.m_version.Click += new System.EventHandler(this.m_version_Click);
            // 
            // area
            // 
            this.area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.area.Location = new System.Drawing.Point(0, 27);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(751, 474);
            this.area.TabIndex = 1;
            this.area.SizeChanged += new System.EventHandler(this.area_SizeChanged);
            this.area.Paint += new System.Windows.Forms.PaintEventHandler(this.area_Paint);
            this.area.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.area_MouseDoubleClick);
            this.area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.area_MouseDown);
            this.area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.area_MouseMove);
            this.area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.area_MouseUp);
            // 
            // ppen
            // 
            this.ppen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ppen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppen.Location = new System.Drawing.Point(12, 517);
            this.ppen.Name = "ppen";
            this.ppen.Size = new System.Drawing.Size(90, 33);
            this.ppen.TabIndex = 2;
            // 
            // pbrush
            // 
            this.pbrush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbrush.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbrush.Location = new System.Drawing.Point(126, 517);
            this.pbrush.Name = "pbrush";
            this.pbrush.Size = new System.Drawing.Size(91, 33);
            this.pbrush.TabIndex = 3;
            // 
            // lmode
            // 
            this.lmode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lmode.AutoSize = true;
            this.lmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lmode.Location = new System.Drawing.Point(246, 525);
            this.lmode.Name = "lmode";
            this.lmode.Size = new System.Drawing.Size(76, 25);
            this.lmode.TabIndex = 4;
            this.lmode.Text = "label1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 562);
            this.Controls.Add(this.lmode);
            this.Controls.Add(this.pbrush);
            this.Controls.Add(this.ppen);
            this.Controls.Add(this.area);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_file;
        private System.Windows.Forms.ToolStripMenuItem m_new;
        private System.Windows.Forms.ToolStripMenuItem m_open;
        private System.Windows.Forms.ToolStripMenuItem m_save;
        private System.Windows.Forms.ToolStripMenuItem m_saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_mode;
        private System.Windows.Forms.ToolStripMenuItem m_line;
        private System.Windows.Forms.ToolStripMenuItem m_curve;
        private System.Windows.Forms.ToolStripMenuItem m_bizier;
        private System.Windows.Forms.ToolStripMenuItem m_rectangle;
        private System.Windows.Forms.ToolStripMenuItem m_ellipse;
        private System.Windows.Forms.ToolStripMenuItem m_font;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_pen;
        private System.Windows.Forms.ToolStripMenuItem m_brush;
        private System.Windows.Forms.ToolStripMenuItem m_image;
        private System.Windows.Forms.ToolStripMenuItem m_about;
        private System.Windows.Forms.ToolStripMenuItem m_version;
        private System.Windows.Forms.Panel area;
        private System.Windows.Forms.Panel ppen;
        private System.Windows.Forms.Panel pbrush;
        private System.Windows.Forms.Label lmode;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mpageSetup;
        private System.Windows.Forms.ToolStripMenuItem mpreview;
        private System.Windows.Forms.ToolStripMenuItem mprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem fillEllipseToolStripMenuItem;
    }
}

