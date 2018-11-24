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

namespace Demo1.AdminData.GetStuData
{
    public partial class GetStudent : Form
    {
        public GetStudent()
        {
            InitializeComponent();
        }

        private void GetStudent_Load(object sender, EventArgs e)
        {
            //将ListView视图设置为详细信息
            lv_ViewData.View = View.Details;
            #region 手打Columns
            lv_ViewData.Columns.AddRange(new ColumnHeader[] {
                columnHeader1,
                columnHeader2,
                columnHeader3,
                columnHeader4});
            columnHeader1.DisplayIndex = 0;
            columnHeader1.Width = 150;

            columnHeader2.DisplayIndex = 1;
            columnHeader2.Width = 150;

            columnHeader3.DisplayIndex = 2;
            columnHeader3.Width = 150;

            columnHeader4.DisplayIndex = 3;
            columnHeader4.Width = 150;

            #endregion
            
            

        }
        private void lv_ViewData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_GetNameBox_Click(object sender, EventArgs e)
        {
            FillistView();
        }
        //查询方法
        public void FillistView()
        {
            DBHelper dbhelper = new DBHelper();

            string Name = txt_GetNameBox.Text.Trim();
            string sql = string.Empty;
            string sql2 = string.Empty;
            int i = 0;

            //查找前先清空数据
            if (lv_ViewData.Items.Count > 0)
            {
                lv_ViewData.Items.Clear();
            }
            //打开数据库连接
            dbhelper.OpenConnection();
            try
            {
                //先查询有几条数据
                sql2 = "SELECT COUNT(*) FROM Student WHERE StudentName LIKE '%" + Name + "%'";
                //实例化comm对象
                SqlCommand comm = new SqlCommand(sql2, dbhelper.Connection);
                int num = (int)comm.ExecuteScalar();
                ListViewItem[] items = new ListViewItem[num];
                

                sql = "SELECT StudentNo , StudentName , [Sex(性别)] , [Gradeld(所在年级)] FROM Student WHERE StudentName LIKE '%" + Name + "%'";

                //实例化comm对象
                comm = new SqlCommand(sql , dbhelper.Connection);
                SqlDataReader reader = comm.ExecuteReader();
                //读取数据
                while (reader.Read())
                {
                    //将对应的结果保存到变量
                    string studentNo = reader["StudentNo"].ToString();
                    string studentName = reader["StudentName"].ToString();
                    string Sex = reader["Sex(性别)"].ToString();
                    string gradeld = reader["Gradeld(所在年级)"].ToString();
                    /*
                    ListViewItem itema = new ListViewItem(studentNo);
                    itema.SubItems.Add(studentName);
                    itema.SubItems.Add(Sex);
                    itema.SubItems.Add(gradeld);
                    */
                    #region 将值放入列表中
                    items[i] = new ListViewItem(new string[]{
                    studentNo,
                    studentName,
                    Sex,
                    gradeld
                   });

                    //lv_ViewData.Items.Add(itema);
                    #endregion

                    i++;
                }
                this.lv_ViewData.Items.AddRange(items);
                reader.Close();

            }
            catch (Exception ex)
            {
                
                throw;
            }
            finally
            {
                dbhelper.CloseConnection();
            }
        }

        private void txt_GetNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cms_Set1_Click(object sender, EventArgs e)
        {
            //将所选项的学号传递过去
            if (this.lv_ViewData.SelectedItems.Count > 0)
            {
                //选中
                SetStuData.NewSetList newlist = new SetStuData.NewSetList();
                newlist.studentNo = Convert.ToString(this.lv_ViewData.SelectedItems[0].Text.Trim());
                //值传递过去之后在打开窗口
                newlist.Show();
            }
            else
            {
                //没选中就messBos弹窗
                MessageBox.Show("请选择一个学生！", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
