using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo1
{
    public partial class Form1 : Form
    {
        /**************全局变量区**************/

        public const string CAPTION = "提示";
        public const string ADMIN = "管理员";
        public string stuDateString;
        //数据库连接对象
        DBHelper dbhelp = new DBHelper();

        /**************全局变量区END**************/
        public Form1()
        {
            InitializeComponent();
        }
        //登陆按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                
                int result = CheckUser();
                //返回1代表管理员登陆
                if (result == 1)
                {
                    //实例化对象
                    
                    
                    //另一个界面对象实例
                    StuData.StuData studata = new StuData.StuData();
                    //传递用户名
                    studata.admin = teBox_Admin.Text.Trim();
                    studata.LoginType = comboBox_type.Text.Trim();
                    studata.Show();

                    
                }
                //返回2代表学生登陆
                else if (result == 2)
                {
                    //传递用户名
                    //setpwd.admin = teBox_Admin.Text.Trim();
                    //setpwd.LoginType = comboBox_type.Text.Trim();
                    MessageBox.Show("学生登陆成功！");
                }
                else if (result == -1)
                {
                    MessageBox.Show("用户名或者密码错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                    return;
                }
                //if (this.comboBox_type.Text.Equals(ADMIN))
                //{
                //    //跳转到下一个界面
                //    AdminFrom.FrmAdminMain frmAdmin = new AdminFrom.FrmAdminMain();
                //    //把用户名去除左右空格保存到 userId 中
                //    frmAdmin.userId = teBox_Admin.Text.Trim();
                //    frmAdmin.Show();
                //}
                this.Hide();
            }
            
        }

/************************************************************************************************************/

        //登陆类型框
        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //用户名输入框
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }
        //关闭按钮
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退书登陆吗？","温馨提示" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //改背景颜色按钮
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Yellow;
            }
            else if (this.BackColor == Color.Yellow)
            {
                this.BackColor = Color.Green;
            }
            else if (this.BackColor == Color.Green)
            {
                this.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentData.GetStudent getstudent = new StudentData.GetStudent();
            getstudent.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Yellow;
            }
            else if (this.BackColor == Color.Yellow)
            {
                this.BackColor = Color.Green;
            }
            else if (this.BackColor == Color.Green)
            {
                this.BackColor = Color.Red;
            }
        }

/*****************************************************分割线*************************************************/


        //数据库判断管理员密码与学生密码
        public bool AdminPwd(string userName , string userPwd , string DataBase)
        {
            string sql = null;
            //打开数据库连接
            dbhelp.OpenConnection();
            try
            {
                
                //执行SQL语句
                if (DataBase.Equals("Admin"))
                {
                    sql = "SELECT COUNT(*) FROM " + DataBase + " WHERE adminUser = '" + userName + "' AND adminPwd = '" + userPwd + "'";
                }
                if (DataBase.Equals("Student"))
                {
                    sql = "SELECT COUNT(*) FROM " + DataBase + " WHERE StudentName = '" + userName + "' AND [LoginPwd(密码)] = '" + userPwd + "'";
                }
                
                SqlCommand comm = new SqlCommand(sql , dbhelp.Connection);
                int num = (int)comm.ExecuteScalar();
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }
            catch (Exception er)
            {
                string error = Convert.ToString(er);
                MessageBox.Show("错误代码：" + error + "", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally 
            {
                //关闭数据库连接
                dbhelp.CloseConnection();
            }

        }

        //登陆信息框是否为空
        public bool CheckInput()
        {
            //用户名是否为空
            if (this.teBox_Admin.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.teBox_Admin.Focus();
            }
            //密码是否为空
            else if (this.teBox_Pwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.teBox_Pwd.Focus();
            }
            //登陆类型是否为空
            else if (this.comboBox_type.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择登陆类型", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.comboBox_type.Focus();
            }
            //符合登陆条件
            else
            {
                return true;
            }
            return false;
        }
        //判断登陆及连接到服务器
        public int CheckUser()
        {
            string userName = teBox_Admin.Text.Trim();
            string userPwd = teBox_Pwd.Text.Trim();

            if (comboBox_type.Text.Trim().Equals(ADMIN))
            {
                //如果是管理员登陆则传入Admin
                if (AdminPwd(userName, userPwd, "Admin"))
                {
                    //打开数据库连接
                    dbhelp.OpenConnection();
                    return 1;
                }
                else
                {
                    return -1;
                }

            }
            if (comboBox_type.Text.Trim().Equals("学生"))
            {
                //如果是学生登陆 则传入 Student
                if (AdminPwd(userName, userPwd, "Student"))
                {
                    //打开数据库连接
                    dbhelp.OpenConnection();
                    return 2;
                }
            }

            return -1;
        }
    }
}
