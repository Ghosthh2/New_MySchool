namespace Demo1.StudentData
{
    partial class GetStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStudent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_Acount = new System.Windows.Forms.ToolStripMenuItem();
            this.Set_StudentPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.查看密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_GetResult = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_GetPerson = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_Acount,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_Acount
            // 
            this.ms_Acount.CheckOnClick = true;
            this.ms_Acount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Set_StudentPwd,
            this.查看密码ToolStripMenuItem});
            this.ms_Acount.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ms_Acount.Name = "ms_Acount";
            this.ms_Acount.Size = new System.Drawing.Size(85, 23);
            this.ms_Acount.Text = "账户管理";
            // 
            // Set_StudentPwd
            // 
            this.Set_StudentPwd.Name = "Set_StudentPwd";
            this.Set_StudentPwd.Size = new System.Drawing.Size(142, 24);
            this.Set_StudentPwd.Text = "修改密码";
            // 
            // 查看密码ToolStripMenuItem
            // 
            this.查看密码ToolStripMenuItem.Name = "查看密码ToolStripMenuItem";
            this.查看密码ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.查看密码ToolStripMenuItem.Text = "查看账号";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_GetResult,
            this.ts_GetPerson});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(612, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_GetResult
            // 
            this.ts_GetResult.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ts_GetResult.Image = ((System.Drawing.Image)(resources.GetObject("ts_GetResult.Image")));
            this.ts_GetResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_GetResult.Name = "ts_GetResult";
            this.ts_GetResult.Size = new System.Drawing.Size(92, 22);
            this.ts_GetResult.Text = "查看成绩";
            // 
            // ts_GetPerson
            // 
            this.ts_GetPerson.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ts_GetPerson.Image = ((System.Drawing.Image)(resources.GetObject("ts_GetPerson.Image")));
            this.ts_GetPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_GetPerson.Name = "ts_GetPerson";
            this.ts_GetPerson.Size = new System.Drawing.Size(120, 22);
            this.ts_GetPerson.Text = "查看个人信息";
            // 
            // GetStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(612, 489);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GetStudent";
            this.Text = "GetStudent";
            this.Load += new System.EventHandler(this.GetStudent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ms_Acount;
        private System.Windows.Forms.ToolStripMenuItem Set_StudentPwd;
        private System.Windows.Forms.ToolStripMenuItem 查看密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ts_GetResult;
        private System.Windows.Forms.ToolStripDropDownButton ts_GetPerson;
    }
}