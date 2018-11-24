namespace Demo1.AdminData.GradeGetStu
{
    partial class Grade
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Grade = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dbv_StuName = new System.Windows.Forms.DataGridView();
            this.StuData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dbv_StuName)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(222, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "年级：";
            // 
            // cbo_Grade
            // 
            this.cbo_Grade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Grade.Font = new System.Drawing.Font("宋体", 12F);
            this.cbo_Grade.FormattingEnabled = true;
            this.cbo_Grade.Location = new System.Drawing.Point(297, 22);
            this.cbo_Grade.Name = "cbo_Grade";
            this.cbo_Grade.Size = new System.Drawing.Size(198, 24);
            this.cbo_Grade.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(506, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbv_StuName
            // 
            this.dbv_StuName.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.dbv_StuName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbv_StuName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuData,
            this.StuName,
            this.StuSex,
            this.birth});
            this.dbv_StuName.ContextMenuStrip = this.contextMenuStrip1;
            this.dbv_StuName.Location = new System.Drawing.Point(12, 61);
            this.dbv_StuName.Name = "dbv_StuName";
            this.dbv_StuName.RowTemplate.Height = 23;
            this.dbv_StuName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbv_StuName.Size = new System.Drawing.Size(780, 330);
            this.dbv_StuName.TabIndex = 3;
            // 
            // StuData
            // 
            this.StuData.DataPropertyName = "StudentNo";
            this.StuData.Frozen = true;
            this.StuData.HeaderText = "学生学号";
            this.StuData.Name = "StuData";
            this.StuData.Width = 184;
            // 
            // StuName
            // 
            this.StuName.DataPropertyName = "StudentName";
            this.StuName.Frozen = true;
            this.StuName.HeaderText = "学生姓名";
            this.StuName.Name = "StuName";
            this.StuName.Width = 184;
            // 
            // StuSex
            // 
            this.StuSex.DataPropertyName = "Sex(性别)";
            this.StuSex.Frozen = true;
            this.StuSex.HeaderText = "性别";
            this.StuSex.Name = "StuSex";
            this.StuSex.Width = 185;
            // 
            // birth
            // 
            this.birth.DataPropertyName = "BornData(出生日期)";
            this.birth.Frozen = true;
            this.birth.HeaderText = "出生日期";
            this.birth.Name = "birth";
            this.birth.Width = 184;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改成绩ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 修改成绩ToolStripMenuItem
            // 
            this.修改成绩ToolStripMenuItem.Name = "修改成绩ToolStripMenuItem";
            this.修改成绩ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改成绩ToolStripMenuItem.Text = "修改成绩";
            this.修改成绩ToolStripMenuItem.Click += new System.EventHandler(this.修改成绩ToolStripMenuItem_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 403);
            this.Controls.Add(this.dbv_StuName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo_Grade);
            this.Controls.Add(this.label1);
            this.Name = "Grade";
            this.Text = "Grade";
            this.Load += new System.EventHandler(this.Grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbv_StuName)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Grade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dbv_StuName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改成绩ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuData;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
    }
}