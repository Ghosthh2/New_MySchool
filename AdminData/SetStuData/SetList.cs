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

namespace Demo1.StuData.SetStuData
{
    public partial class SetList : Form
    {
        public SetList()
        {
            InitializeComponent();
        }

        //SetList保存按钮提交事件
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveStuData();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //窗口加载事件
        private void SetList_Load(object sender, EventArgs e)
        {
            //年级下拉框
            DownList();
            
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //插入学生数据
        public void SaveStuData()
        {
            string StudentNo = txt_Number.Text.Trim();
            string LoginPwd = txt_Pwd.Text.Trim();
            string StudentName = txt_Name.Text.Trim();
            string Pwds = txt_Pwds.Text.Trim();
            string Sex;
            string Gradeld = cmb_Grade.Text.Trim();
            string Phone = txt_PhoneNum.Text.Trim();
            string Address = txt_Addres.Text.Trim();
            DateTime BornData = de_ChioesTime.Value;
            string Emails = txt_Email.Text.Trim();
            
            //登陆数据库类
            DBHelper dbhelper = new DBHelper();

            #region 判断用户选择性别
            if (rdo_SexGirl.Checked)
            {
                Sex = "女";
            }
            else if (rdo_SexMan.Checked)
            {
                Sex = "男";
            }
            else
            {
                Sex = null;
            }
            #endregion
            #region 判断邮箱是否带@
            int index = Emails.IndexOf('@');
            if (index < 0)
            {
                MessageBox.Show("邮箱格式错误:" + index + "", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            #endregion
            #region 判断再次输入的密码是否相同
            if (LoginPwd.Equals(Pwds))
            {
                //查询字符串
                string sql = string.Format("INSERT INTO Student(StudentNo , [LoginPwd(密码)] , StudentName , [Sex(性别)] , [Gradeld(所在年级)] , [Phone(联系电话)] , [Address(现住址)] , [BornData(出生日期)] , [Email(电子邮件)]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');SELECT @@IDENTITY FROM Student", StudentNo, LoginPwd, StudentName, Sex, Gradeld, Phone, Address, BornData, Emails);
                try
                {
                    //连接数据库
                    dbhelper.OpenConnection();

                    //创建comm对象
                    SqlCommand comm = new SqlCommand(sql, dbhelper.Connection);
                    int listNum = (int)comm.ExecuteNonQuery();
                    if (listNum != 0)
                    {
                        MessageBox.Show("插入成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("插入失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception er)
                {
                    string error = Convert.ToString(er);
                    MessageBox.Show("插入失败！错误代码：" + error + "", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    throw;
                }
                finally
                {
                    //关闭数据库连接
                    dbhelper.CloseConnection();
                }



            }
            else
            {
                txt_Pwds.Text = "";
                MessageBox.Show("两次密码不相同" + txt_Pwds + "", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

        }

        //年级下拉框
        public void DownList()
        {
            DBHelper dbhelper = new DBHelper();
            string sql = "SELECT [Gradeld(年级编号)] FROM Gradeld";
            try
            {
                //打开数据库连接
                dbhelper.OpenConnection();

                //执行SQL语句
                SqlCommand comm = new SqlCommand(sql, dbhelper.Connection);
                SqlDataReader reader = comm.ExecuteReader();
                
                //读取数据
                while (reader.Read())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("{0}", reader["Gradeld(年级编号)"]);
                    cmb_Grade.Items.Add(sb);
                }


            }
            catch (Exception)
            {

            }
            finally
            {
                dbhelper.CloseConnection();
            }
        }


    }
}
