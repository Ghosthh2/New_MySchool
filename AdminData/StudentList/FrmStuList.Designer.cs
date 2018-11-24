namespace Demo1.AdminData.StudentList
{
    partial class FrmStuList
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("男", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("女", 3, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("s1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("男", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("女", 3, 3);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("s2", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("男", 2, 2);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("女", 3, 3);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("s3", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStuList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.il_TreeIcon = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(736, 521);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.il_TreeIcon;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "man1";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "男";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "girl1";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "女";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "s1";
            treeNode3.SelectedImageKey = "flie2.jpg";
            treeNode3.Text = "s1";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "man2";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "男";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "girl2";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "女";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "s2";
            treeNode6.SelectedImageKey = "flie2.jpg";
            treeNode6.Text = "s2";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "man3";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Text = "男";
            treeNode8.ImageIndex = 3;
            treeNode8.Name = "girl3";
            treeNode8.SelectedImageIndex = 3;
            treeNode8.Text = "女";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "s3";
            treeNode9.SelectedImageKey = "flie2.jpg";
            treeNode9.Text = "s3";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "Whole";
            treeNode10.SelectedImageKey = "flie2.jpg";
            treeNode10.Text = "全部";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(174, 521);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // il_TreeIcon
            // 
            this.il_TreeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_TreeIcon.ImageStream")));
            this.il_TreeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.il_TreeIcon.Images.SetKeyName(0, "file1.jpg");
            this.il_TreeIcon.Images.SetKeyName(1, "flie2.jpg");
            this.il_TreeIcon.Images.SetKeyName(2, "Male.jpg");
            this.il_TreeIcon.Images.SetKeyName(3, "Female.jpg");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(558, 521);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmStuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 521);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmStuList";
            this.Text = "FrmStuList";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList il_TreeIcon;
    }
}