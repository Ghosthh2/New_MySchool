namespace Demo1.AdminData.GetStuData
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
            this.components = new System.ComponentModel.Container();
            this.grb_Top = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GetNameBox = new System.Windows.Forms.Button();
            this.txt_GetNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_ViewData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms_SetData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_Set1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_Top.SuspendLayout();
            this.cms_SetData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Top
            // 
            this.grb_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Top.Controls.Add(this.label2);
            this.grb_Top.Controls.Add(this.btn_GetNameBox);
            this.grb_Top.Controls.Add(this.txt_GetNameBox);
            this.grb_Top.Controls.Add(this.label1);
            this.grb_Top.Location = new System.Drawing.Point(2, 2);
            this.grb_Top.Name = "grb_Top";
            this.grb_Top.Size = new System.Drawing.Size(643, 64);
            this.grb_Top.TabIndex = 0;
            this.grb_Top.TabStop = false;
            this.grb_Top.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "(支持模糊查找)";
            // 
            // btn_GetNameBox
            // 
            this.btn_GetNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GetNameBox.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_GetNameBox.Location = new System.Drawing.Point(336, 18);
            this.btn_GetNameBox.Name = "btn_GetNameBox";
            this.btn_GetNameBox.Size = new System.Drawing.Size(109, 38);
            this.btn_GetNameBox.TabIndex = 2;
            this.btn_GetNameBox.Text = "查找";
            this.btn_GetNameBox.UseVisualStyleBackColor = true;
            this.btn_GetNameBox.Click += new System.EventHandler(this.btn_GetNameBox_Click);
            // 
            // txt_GetNameBox
            // 
            this.txt_GetNameBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_GetNameBox.Location = new System.Drawing.Point(141, 24);
            this.txt_GetNameBox.Name = "txt_GetNameBox";
            this.txt_GetNameBox.Size = new System.Drawing.Size(173, 26);
            this.txt_GetNameBox.TabIndex = 1;
            this.txt_GetNameBox.TextChanged += new System.EventHandler(this.txt_GetNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // lv_ViewData
            // 
            this.lv_ViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_ViewData.ContextMenuStrip = this.cms_SetData;
            this.lv_ViewData.FullRowSelect = true;
            this.lv_ViewData.GridLines = true;
            this.lv_ViewData.Location = new System.Drawing.Point(2, 72);
            this.lv_ViewData.MultiSelect = false;
            this.lv_ViewData.Name = "lv_ViewData";
            this.lv_ViewData.Size = new System.Drawing.Size(643, 328);
            this.lv_ViewData.TabIndex = 1;
            this.lv_ViewData.UseCompatibleStateImageBehavior = false;
            this.lv_ViewData.View = System.Windows.Forms.View.Details;
            this.lv_ViewData.SelectedIndexChanged += new System.EventHandler(this.lv_ViewData_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "年级";
            // 
            // cms_SetData
            // 
            this.cms_SetData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cms_SetData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_Set1});
            this.cms_SetData.Name = "cms_SetData";
            this.cms_SetData.Size = new System.Drawing.Size(153, 48);
            // 
            // cms_Set1
            // 
            this.cms_Set1.Name = "cms_Set1";
            this.cms_Set1.Size = new System.Drawing.Size(152, 22);
            this.cms_Set1.Text = "修改";
            this.cms_Set1.Click += new System.EventHandler(this.cms_Set1_Click);
            // 
            // GetStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 426);
            this.Controls.Add(this.lv_ViewData);
            this.Controls.Add(this.grb_Top);
            this.Name = "GetStudent";
            this.Text = "查询学生信息";
            this.Load += new System.EventHandler(this.GetStudent_Load);
            this.grb_Top.ResumeLayout(false);
            this.grb_Top.PerformLayout();
            this.cms_SetData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Top;
        private System.Windows.Forms.Button btn_GetNameBox;
        private System.Windows.Forms.TextBox txt_GetNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv_ViewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip cms_SetData;
        private System.Windows.Forms.ToolStripMenuItem cms_Set1;
    }
}