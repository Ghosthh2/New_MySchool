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


namespace Demo1.AdminData.GradeGetStu
{
    public partial class Grade : Form
    {
        /// <summary>
        ///  Tables[0] 指的是 Student表
        ///  Tables[1] 指的是 Gradeld表
        ///  TaBles[2] 指的是 Result表
        /// </summary>
        private DataSet ds_List = new DataSet();              //声明GradeDataSet
        
        private SqlDataAdapter adapter;       //声明读取年级信息的数据适配器

        DBHelper dbhelper = new DBHelper();   //实例化DBHeler

        public Grade()
        {
            InitializeComponent();
        }

        private void Grade_Load(object sender, EventArgs e)
        {

            GetGrade();
            //初始化下拉框
            DownList();
            dbv_StuName.DataSource = ds_List.Tables["Student"];
            
        }
        //年级下拉框
        public void DownList()
        {
            try
            {
                //打开数据库
                dbhelper.OpenConnection();
                string sql = "SELECT * FROM Gradeld";
                SqlCommand comm = new SqlCommand(sql, dbhelper.Connection);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cbo_Grade.Items.Add(reader["GradeName(年级名)"]);
                }
                reader.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            InputData();
        }
        //查询年级表,学生表
        public void GetGrade()
        {

            string sql = "SELECT * FROM Student";
            SqlDataAdapter adapterStu = new SqlDataAdapter(sql.ToString(), dbhelper.Connection);
            adapterStu.Fill(ds_List, "Student");

        }
        //填充DataSet
        public void InputData()
        {
            //清空DataSet
            if (ds_List.Tables["Student"] != null)
            {
                ds_List.Tables["Student"].Clear();
            }

            string Grade = cbo_Grade.Text.Trim();
            StringBuilder sql = new StringBuilder();
            //sql语句
            sql.AppendFormat("SELECT * FROM Student WHERE [Gradeld(所在年级)] = {0}" , Gredeid(Grade));
            
            SqlDataAdapter adapterStu = new SqlDataAdapter(sql.ToString() , dbhelper.Connection);
            adapterStu.Fill(ds_List, "Student");
        }
        //查询窗口赋值
        public string Gredeid(string GradeName)
        {
            string gradeld;
            //打开数据库连接
            dbhelper.OpenConnection();
            try
            {
                if (GradeName.Equals(""))
                {
                    return "-1";
                }
                string sql = "SELECT [Gradeld(年级编号)] FROM Gradeld WHERE [GradeName(年级名)] = '" + GradeName + "'";
                SqlCommand comm = new SqlCommand(sql, dbhelper.Connection);
                gradeld = comm.ExecuteScalar().ToString();
                

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbhelper.CloseConnection();
            }
            return gradeld;
        }

        private void 修改成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeGetStu.SetResult result = new SetResult();
            //传值 姓名
            result.name = Convert.ToString(dbv_StuName.SelectedCells[3].Value);
            result.Show();
        }
    }
}
