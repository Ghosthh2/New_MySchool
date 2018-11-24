namespace Demo1.AdminData.GradeGetStu
{
    partial class SetResult
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.cbo_Subject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtp_Time);
            this.groupBox1.Controls.Add(this.txt_Result);
            this.groupBox1.Controls.Add(this.cbo_Subject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入成绩";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(482, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_Time
            // 
            this.dtp_Time.CalendarFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_Time.Location = new System.Drawing.Point(103, 134);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(349, 33);
            this.dtp_Time.TabIndex = 3;
            // 
            // txt_Result
            // 
            this.txt_Result.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.txt_Result.Location = new System.Drawing.Point(103, 90);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(349, 30);
            this.txt_Result.TabIndex = 2;
            this.txt_Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbo_Subject
            // 
            this.cbo_Subject.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_Subject.FormattingEnabled = true;
            this.cbo_Subject.Location = new System.Drawing.Point(103, 43);
            this.cbo_Subject.Name = "cbo_Subject";
            this.cbo_Subject.Size = new System.Drawing.Size(349, 29);
            this.cbo_Subject.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "考试时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(55, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "成绩";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "科目";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stuname,
            this.StuSubject,
            this.StuResult,
            this.TestTime});
            this.dataGridView1.Location = new System.Drawing.Point(1, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(664, 324);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Stuname
            // 
            this.Stuname.DataPropertyName = "StuName";
            this.Stuname.HeaderText = "学生姓名";
            this.Stuname.Name = "Stuname";
            this.Stuname.Width = 155;
            // 
            // StuSubject
            // 
            this.StuSubject.DataPropertyName = "SubName";
            this.StuSubject.HeaderText = "科目名称";
            this.StuSubject.Name = "StuSubject";
            this.StuSubject.Width = 155;
            // 
            // StuResult
            // 
            this.StuResult.DataPropertyName = "Result";
            this.StuResult.HeaderText = "成绩";
            this.StuResult.Name = "StuResult";
            this.StuResult.Width = 155;
            // 
            // TestTime
            // 
            this.TestTime.DataPropertyName = "TestTime";
            this.TestTime.HeaderText = "考试时间";
            this.TestTime.Name = "TestTime";
            this.TestTime.Width = 156;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "提交";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetResult";
            this.Text = "SetResult";
            this.Load += new System.EventHandler(this.SetResult_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.ComboBox cbo_Subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestTime;
        private System.Windows.Forms.Button button2;
    }
}