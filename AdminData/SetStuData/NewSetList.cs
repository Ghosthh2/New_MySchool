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

namespace Demo1.AdminData.SetStuData
{
    public partial class NewSetList : Form
    {
        public string studentNo = string.Empty;
        //实例连接类
        DBHelper dbhelper = new DBHelper();

        public NewSetList()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveStuData();
        }

        private void NewSetList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //加载到窗口
        public void LoadData()
        {
            //根据学号查询信息
            dbhelper.OpenConnection();

            try
            {
                string sql = "SELECT StudentNo , [LoginPwd(密码)] , StudentName , [Sex(性别)] , [Gradeld(所在年级)] , [Phone(联系电话)] , [Address(现住址)] ,[BornData(出生日期)] , [Email(电子邮件)] FROM Student WHERE StudentNo = '" + studentNo + "'";
                SqlCommand comm = new SqlCommand(sql, dbhelper.Connection);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //提取保存到变量
                    string stuNo = reader["StudentNo"].ToString();
                    string login = reader["LoginPwd(密码)"].ToString();
                    string stuName = reader["StudentName"].ToString();
                    string sex = reader["Sex(性别)"].ToString();
                    string grade = reader["Gradeld(所在年级)"].ToString();
                    string phone = reader["Phone(联系电话)"].ToString();
                    string addres = reader["Address(现住址)"].ToString();
                    DateTime bron = Convert.ToDateTime(reader["BornData(出生日期)"]);
                    string Email = reader["Email(电子邮件)"].ToString();
                        
                    //赋值到窗口
                    this.txt_Number.Text = stuNo;
                    this.txt_Pwd.Text = login;
                    this.txt_Pwds.Text = login;
                    this.txt_Name.Text = stuName;
                    this.cmb_Grade.Text = grade;
                    this.txt_PhoneNum.Text = phone;
                    this.txt_Addres.Text = addres;
                    this.de_ChioesTime.Text = bron.ToString() ;
                    this.txt_Email.Text = Email;
                    //性别赋值
                    if (sex == "男")
                    {
                        rdo_SexMan.Checked = true;
                        rdo_SexGirl.Checked = false;
                    }
                    else if (sex == "女")
                    {
                        rdo_SexMan.Checked = false;
                        rdo_SexGirl.Checked = true;
                    }
                }
                //关闭reader
                
                reader.Close();
                

            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                Gradeid();
                dbhelper.CloseConnection();
            }
        }
        //加载学生年级
        public void Gradeid()
        {
            //连接数据库
            dbhelper.OpenConnection();
            try
            {
                string sql = "SELECT [Gradeld(年级编号)] , [GradeName(年级名)] FROM Gradeld";
                SqlCommand comm = new SqlCommand(sql, dbhelper.Connection);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cmb_Grade.Items.Add(reader["GradeName(年级名)"].ToString());
                }


            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                dbhelper.CloseConnection();
            }
        }
        /// <summary>
        /// SaveStuData()
        /// 保存到数据库
        /// </summary>
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
                string sql = string.Format("UPDATE Student SET [LoginPwd(密码)] = {0}, StudentName = '{1}', [Sex(性别)] = '{2}', [Gradeld(所在年级)] = {3}, [Phone(联系电话)] = {4}, [Address(现住址)] = '{5}', [BornData(出生日期)] = '{6}', [Email(电子邮件)] = '{7}' WHERE StudentNo = '" + studentNo + "'", LoginPwd, StudentName, Sex, Gradeld, Phone, Address, BornData, Emails);
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
            this.Close();
            //刷新窗口
            GetStuData.GetStudent getstu = new GetStuData.GetStudent();
            getstu.FillistView();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
 