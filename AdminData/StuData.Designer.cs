namespace Demo1.StuData
{
    partial class StuData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuData));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_Acount = new System.Windows.Forms.ToolStripMenuItem();
            this.tms_SetPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tms_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_StuAcount = new System.Windows.Forms.ToolStripMenuItem();
            this.tms_AddStu = new System.Windows.Forms.ToolStripMenuItem();
            this.tms_QurName = new System.Windows.Forms.ToolStripMenuItem();
            this.tms_QurGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tms_StuList = new System.Windows.Forms.ToolStripMenuItem();
            this.科目管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_Acount,
            this.ms_StuAcount,
            this.科目管理CToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.窗口YToolStripMenuItem,
            this.关于KToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_Acount
            // 
            this.ms_Acount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tms_SetPwd,
            this.tms_Exit});
            this.ms_Acount.Name = "ms_Acount";
            this.ms_Acount.Size = new System.Drawing.Size(101, 21);
            this.ms_Acount.Text = "账户管理（&U）";
            // 
            // tms_SetPwd
            // 
            this.tms_SetPwd.Name = "tms_SetPwd";
            this.tms_SetPwd.Size = new System.Drawing.Size(124, 22);
            this.tms_SetPwd.Text = "修改密码";
            this.tms_SetPwd.Click += new System.EventHandler(this.tms_SetPwd_Click);
            // 
            // tms_Exit
            // 
            this.tms_Exit.Name = "tms_Exit";
            this.tms_Exit.Size = new System.Drawing.Size(124, 22);
            this.tms_Exit.Text = "退出";
            this.tms_Exit.Click += new System.EventHandler(this.tms_Exit_Click);
            // 
            // ms_StuAcount
            // 
            this.ms_StuAcount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tms_AddStu,
            this.tms_QurName,
            this.tms_QurGrade,
            this.tms_StuList});
            this.ms_StuAcount.Name = "ms_StuAcount";
            this.ms_StuAcount.Size = new System.Drawing.Size(123, 21);
            this.ms_StuAcount.Text = "学生用户管理（&S）";
            // 
            // tms_AddStu
            // 
            this.tms_AddStu.Name = "tms_AddStu";
            this.tms_AddStu.Size = new System.Drawing.Size(172, 22);
            this.tms_AddStu.Text = "新增学生（&N）";
            // 
            // tms_QurName
            // 
            this.tms_QurName.Name = "tms_QurName";
            this.tms_QurName.Size = new System.Drawing.Size(172, 22);
            this.tms_QurName.Text = "按姓名查询（&M）";
            this.tms_QurName.Click += new System.EventHandler(this.tms_QurName_Click);
            // 
            // tms_QurGrade
            // 
            this.tms_QurGrade.Name = "tms_QurGrade";
            this.tms_QurGrade.Size = new System.Drawing.Size(172, 22);
            this.tms_QurGrade.Text = "按年级查询（&G）";
            this.tms_QurGrade.Click += new System.EventHandler(this.tms_QurGrade_Click);
            // 
            // tms_StuList
            // 
            this.tms_StuList.Name = "tms_StuList";
            this.tms_StuList.Size = new System.Drawing.Size(172, 22);
            this.tms_StuList.Text = "学生列表（&L）";
            // 
            // 科目管理CToolStripMenuItem
            // 
            this.科目管理CToolStripMenuItem.Name = "科目管理CToolStripMenuItem";
            this.科目管理CToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.科目管理CToolStripMenuItem.Text = "科目管理（&C）";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.帮助HToolStripMenuItem.Text = "帮助（&H）";
            // 
            // 窗口YToolStripMenuItem
            // 
            this.窗口YToolStripMenuItem.Name = "窗口YToolStripMenuItem";
            this.窗口YToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.窗口YToolStripMenuItem.Text = "窗口（&Y）";
            // 
            // 关于KToolStripMenuItem
            // 
            this.关于KToolStripMenuItem.Name = "关于KToolStripMenuItem";
            this.关于KToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.关于KToolStripMenuItem.Text = "关于（&K）";
            this.关于KToolStripMenuItem.Click += new System.EventHandler(this.关于KToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4,
            this.toolStripSeparator1,
            this.toolStripDropDownButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripDropDownButton1.Text = "新建学生用户";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            this.toolStripDropDownButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripDropDownButton1_MouseDown);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(145, 22);
            this.toolStripDropDownButton2.Text = "按姓名查询学生信息";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(145, 22);
            this.toolStripDropDownButton3.Text = "按年龄查询学生信息";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButton4.Text = "学生列表";
            this.toolStripDropDownButton4.Click += new System.EventHandler(this.toolStripDropDownButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButton5.Text = "科目列表";
            // 
            // StuData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(752, 743);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StuData";
            this.Load += new System.EventHandler(this.StuData_Load);
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
        private System.Windows.Forms.ToolStripMenuItem tms_SetPwd;
        private System.Windows.Forms.ToolStripMenuItem tms_Exit;
        private System.Windows.Forms.ToolStripMenuItem ms_StuAcount;
        private System.Windows.Forms.ToolStripMenuItem tms_AddStu;
        private System.Windows.Forms.ToolStripMenuItem tms_QurName;
        private System.Windows.Forms.ToolStripMenuItem tms_QurGrade;
        private System.Windows.Forms.ToolStripMenuItem tms_StuList;
        private System.Windows.Forms.ToolStripMenuItem 科目管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口YToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于KToolStripMenuItem;
    }
}