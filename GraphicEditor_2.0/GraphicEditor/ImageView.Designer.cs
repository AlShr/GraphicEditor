namespace GraphicEditor
{
    partial class ImageView
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
            this.AsyncProgressBar = new System.Windows.Forms.ProgressBar();
            this.ResultTextBlock = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btDraw = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbMode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AsyncProgressBar
            // 
            this.AsyncProgressBar.Location = new System.Drawing.Point(12, 320);
            this.AsyncProgressBar.Name = "AsyncProgressBar";
            this.AsyncProgressBar.Size = new System.Drawing.Size(164, 20);
            this.AsyncProgressBar.TabIndex = 0;
            // 
            // ResultTextBlock
            // 
            this.ResultTextBlock.Location = new System.Drawing.Point(12, 12);
            this.ResultTextBlock.Name = "ResultTextBlock";
            this.ResultTextBlock.Size = new System.Drawing.Size(235, 20);
            this.ResultTextBlock.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 191);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btDraw
            // 
            this.btDraw.Location = new System.Drawing.Point(218, 320);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(75, 23);
            this.btDraw.TabIndex = 6;
            this.btDraw.Text = "Start";
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.startProcesing);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(325, 320);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.cancelProcessing);
            // 
            // tbMode
            // 
            this.tbMode.Location = new System.Drawing.Point(340, 48);
            this.tbMode.Name = "tbMode";
            this.tbMode.Size = new System.Drawing.Size(75, 20);
            this.tbMode.TabIndex = 8;
            this.tbMode.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mode";
            // 
            // ImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMode);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDraw);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResultTextBlock);
            this.Controls.Add(this.AsyncProgressBar);
            this.Name = "ImageView";
            this.Text = "ImageView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar AsyncProgressBar;
        private System.Windows.Forms.TextBox ResultTextBlock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbMode;
        private System.Windows.Forms.Label label1;
    }
}