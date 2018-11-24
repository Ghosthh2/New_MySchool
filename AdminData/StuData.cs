using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1.StuData
{
    public partial class StuData : Form
    {
        public string admin = string.Empty;
        public string LoginType = string.Empty;
        public StuData()
        {
            InitializeComponent();
        }
        private void StuData_Load(object sender, EventArgs e)
        {
            Background();
        }
        

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripDropDownButton1_MouseDown(object sender, MouseEventArgs e)
        {
            SetStuData.SetList list = new SetStuData.SetList();
            list.MdiParent = this;
            list.Show();
        }

        private void tms_SetPwd_Click(object sender, EventArgs e)
        {
            SetPassWord.SetPwd setpwd = new SetPassWord.SetPwd();
            setpwd.w_admin = admin;
            setpwd.w_LoginType = LoginType;
            setpwd.MdiParent = this;
            setpwd.Show();
        }
        //程序退出
        private void tms_Exit_Click(object sender, EventArgs e)
        {
            //退出整个程序
            Application.Exit();
        }
        public void Background()
        {
            //遍历窗口中所有控件
            foreach (Control control in this.Controls)
            {
                //如果该控件是MDI类型的，就
                if (control is MdiClient)
                {
                    //把当前的背景颜色设置为MDI的背景颜色
                    control.BackColor = this.BackColor;
                    //
                    control.BackgroundImage = this.BackgroundImage;
                    control.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            //显示查询窗口
            AdminData.GetStuData.GetStudent getstu = new AdminData.GetStuData.GetStudent();
            getstu.MdiParent = this;
            getstu.Show();
        }

        private void tms_QurName_Click(object sender, EventArgs e)
        {
            //显示查询窗口
            AdminData.GetStuData.GetStudent getstu = new AdminData.GetStuData.GetStudent();
            getstu.MdiParent = this;
            getstu.Show();
        }

        private void 关于KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About.SchoolAbout about = new About.SchoolAbout();
            about.ShowDialog();
        }

        private void tms_QurGrade_Click(object sender, EventArgs e)
        {
            AdminData.GradeGetStu.Grade gradeid = new AdminData.GradeGetStu.Grade();
            gradeid.Show();
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {
            AdminData.StudentList.FrmStuList frmlist = new AdminData.StudentList.FrmStuList();
            frmlist.MdiParent = this;
            frmlist.Show();

        }
    }
}
