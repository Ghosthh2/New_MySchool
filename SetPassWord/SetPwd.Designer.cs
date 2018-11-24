namespace Demo1.SetPassWord
{
    partial class SetPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_OldPwd = new System.Windows.Forms.TextBox();
            this.txt_NewPwd = new System.Windows.Forms.TextBox();
            this.txt_Pwss = new System.Windows.Forms.TextBox();
            this.btn_ConfirmPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "确认密码：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_OldPwd
            // 
            this.txt_OldPwd.Location = new System.Drawing.Point(102, 37);
            this.txt_OldPwd.Name = "txt_OldPwd";
            this.txt_OldPwd.Size = new System.Drawing.Size(170, 21);
            this.txt_OldPwd.TabIndex = 1;
            // 
            // txt_NewPwd
            // 
            this.txt_NewPwd.Location = new System.Drawing.Point(102, 106);
            this.txt_NewPwd.Name = "txt_NewPwd";
            this.txt_NewPwd.Size = new System.Drawing.Size(170, 21);
            this.txt_NewPwd.TabIndex = 1;
            // 
            // txt_Pwss
            // 
            this.txt_Pwss.Location = new System.Drawing.Point(120, 171);
            this.txt_Pwss.Name = "txt_Pwss";
            this.txt_Pwss.Size = new System.Drawing.Size(152, 21);
            this.txt_Pwss.TabIndex = 1;
            // 
            // btn_ConfirmPwd
            // 
            this.btn_ConfirmPwd.Location = new System.Drawing.Point(68, 203);
            this.btn_ConfirmPwd.Name = "btn_ConfirmPwd";
            this.btn_ConfirmPwd.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfirmPwd.TabIndex = 2;
            this.btn_ConfirmPwd.Text = "确认密码";
            this.btn_ConfirmPwd.UseVisualStyleBackColor = true;
            this.btn_ConfirmPwd.Click += new System.EventHandler(this.btn_ConfirmPwd_Click);
            // 
            // SetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.btn_ConfirmPwd);
            this.Controls.Add(this.txt_Pwss);
            this.Controls.Add(this.txt_NewPwd);
            this.Controls.Add(this.txt_OldPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetPwd";
            this.Text = "SetPwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_OldPwd;
        private System.Windows.Forms.TextBox txt_NewPwd;
        private System.Windows.Forms.TextBox txt_Pwss;
        private System.Windows.Forms.Button btn_ConfirmPwd;
    }
}