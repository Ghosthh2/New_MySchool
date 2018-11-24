namespace Demo1.About
{
    partial class SchoolAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolAbout));
            this.pb_Ltime = new System.Windows.Forms.PictureBox();
            this.li_AboutImg = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ltime)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Ltime
            // 
            this.pb_Ltime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Ltime.BackgroundImage")));
            this.pb_Ltime.Location = new System.Drawing.Point(23, 25);
            this.pb_Ltime.Name = "pb_Ltime";
            this.pb_Ltime.Size = new System.Drawing.Size(202, 226);
            this.pb_Ltime.TabIndex = 0;
            this.pb_Ltime.TabStop = false;
            this.pb_Ltime.Click += new System.EventHandler(this.pb_Ltime_Click);
            // 
            // li_AboutImg
            // 
            this.li_AboutImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("li_AboutImg.ImageStream")));
            this.li_AboutImg.TransparentColor = System.Drawing.Color.Transparent;
            this.li_AboutImg.Images.SetKeyName(0, "1.bmp");
            this.li_AboutImg.Images.SetKeyName(1, "2.bmp");
            this.li_AboutImg.Images.SetKeyName(2, "3.bmp");
            this.li_AboutImg.Images.SetKeyName(3, "4.bmp");
            this.li_AboutImg.Images.SetKeyName(4, "5.bmp");
            this.li_AboutImg.Images.SetKeyName(5, "6.bmp");
            this.li_AboutImg.Images.SetKeyName(6, "7.bmp");
            this.li_AboutImg.Images.SetKeyName(7, "8.bmp");
            this.li_AboutImg.Images.SetKeyName(8, "9.bmp");
            this.li_AboutImg.Images.SetKeyName(9, "10.bmp");
            this.li_AboutImg.Images.SetKeyName(10, "11.bmp");
            this.li_AboutImg.Images.SetKeyName(11, "12.bmp");
            this.li_AboutImg.Images.SetKeyName(12, "13.bmp");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SchoolAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 392);
            this.Controls.Add(this.pb_Ltime);
            this.Name = "SchoolAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ltime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Ltime;
        private System.Windows.Forms.ImageList li_AboutImg;
        private System.Windows.Forms.Timer timer1;
    }
}