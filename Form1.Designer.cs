namespace Demo1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lal_UserName = new System.Windows.Forms.Label();
            this.lal_Pwd = new System.Windows.Forms.Label();
            this.teBox_Admin = new System.Windows.Forms.TextBox();
            this.teBox_Pwd = new System.Windows.Forms.TextBox();
            this.lal_Type = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.Name = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lal_UserName
            // 
            resources.ApplyResources(this.lal_UserName, "lal_UserName");
            this.lal_UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lal_UserName.Name = "lal_UserName";
            // 
            // lal_Pwd
            // 
            resources.ApplyResources(this.lal_Pwd, "lal_Pwd");
            this.lal_Pwd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lal_Pwd.Name = "lal_Pwd";
            // 
            // teBox_Admin
            // 
            this.teBox_Admin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.teBox_Admin.BackColor = System.Drawing.SystemColors.Control;
            this.teBox_Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teBox_Admin.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.teBox_Admin, "teBox_Admin");
            this.teBox_Admin.Name = "teBox_Admin";
            this.teBox_Admin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // teBox_Pwd
            // 
            this.teBox_Pwd.BackColor = System.Drawing.SystemColors.Control;
            this.teBox_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.teBox_Pwd, "teBox_Pwd");
            this.teBox_Pwd.Name = "teBox_Pwd";
            // 
            // lal_Type
            // 
            resources.ApplyResources(this.lal_Type, "lal_Type");
            this.lal_Type.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lal_Type.Name = "lal_Type";
            // 
            // comboBox_type
            // 
            this.comboBox_type.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            resources.GetString("comboBox_type.Items"),
            resources.GetString("comboBox_type.Items1")});
            resources.ApplyResources(this.comboBox_type, "comboBox_type");
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.lal_Type);
            this.Controls.Add(this.teBox_Pwd);
            this.Controls.Add(this.teBox_Admin);
            this.Controls.Add(this.lal_Pwd);
            this.Controls.Add(this.lal_UserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lal_UserName;
        private System.Windows.Forms.Label lal_Pwd;
        private System.Windows.Forms.TextBox teBox_Admin;
        private System.Windows.Forms.TextBox teBox_Pwd;
        private System.Windows.Forms.Label lal_Type;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

