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

namespace Demo1.SetPassWord
{
    public partial class SetPwd : Form
    {
        public string w_admin = string.Empty;
        public string w_LoginType = string.Empty;
        //连接数据库类
        DBHelper dbHelper = new DBHelper();

        public SetPwd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmPwd_Click(object sender, EventArgs e)
        {

            string oldPwd = txt_OldPwd.Text.Trim();
            string newPwd = txt_NewPwd.Text.Trim();
            string pwdss = txt_Pwss.Text.Trim();

            if (JudgePwd())
            {
                //判断两次密码是否相同
                if (newPwd.Equals(pwdss))
                {
                    //调用方法
                    SetPassWord(pwdss);

                }
                else
                {
                    MessageBox.Show("两次密码输入不相同", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        //判断原密码是否相同
        public bool JudgePwd()
        {
            //拿到管理员的登陆名 和 登陆类型
            string getAdmin = w_admin;
            string getType = w_LoginType;
            string sql;
            try
            {
                //连接数据库
                dbHelper.OpenConnection();
                if (getType != null && getType.Equals("管理员"))
                {
                    sql = "SELECT * FROM Admin WHERE adminUser = '" + getAdmin + "'";
                }
                else
                {
                    sql = "SELECT * FROM Admin WHERE adminUser = '" + getAdmin + "'";
                }
                //创建comm对象
                SqlCommand comm = new SqlCommand(sql, dbHelper.Connection);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["adminUser"].ToString().Equals(getAdmin))
                    {
                        if (reader["adminPwd"].ToString().Equals(txt_OldPwd.Text.Trim()))
                        {
                            //关闭reader
                            reader.Close();
                            return true;
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            MessageBox.Show("滚你不是主人！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return false;
                    }
                }
                //关闭reader
                reader.Close();
                return false;
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                MessageBox.Show("数据库错误：" + error + "", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            { 
                //关闭数据
                dbHelper.CloseConnection();
                
            } 
            
        }
        //修改密码
        public void SetPassWord(string pwdss)
        {
            string sql;
            try
            {
                //打开数据库
                dbHelper.OpenConnection();
                //创建数据库语句
                sql = "UPDATE Admin SET adminPwd = '" + pwdss + "' WHERE adminUser = '" + w_admin + "'";
                //实例化comm对象
                SqlCommand comm = new SqlCommand(sql , dbHelper.Connection);
                int num = (int)comm.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                MessageBox.Show("数据库错误：" + error + "", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }
    }
}
