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
    public partial class SetResult : Form
    {
        DataSet ds_Compose = new DataSet();
        DataSet ds = new DataSet();
        //public SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adaPterRes;
        DBHelper dbhelper = new DBHelper();
        //学生姓名
        public string name = string.Empty;
        public string stuNo = string.Empty;

        public SetResult()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SetResult_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCbo_Subject();
        }

        //数据加载
        public void LoadData()
        {
            //查三表保存
            string sql1 = "SELECT StudentNo , StudentName FROM Student";
            string sql2 = "SELECT [SubjectId(科目编号)], [SubjectName(科目名称)] FROM SubjectId";
            string sql3 = "SELECT [Id(标识列)] ,[StudentNo(学号)],[SubjectId(所考科目)] , [StudentResult(分数)] ,[ExamData(考试日期)] FROM Result";

            SqlDataAdapter adaPterStu = new SqlDataAdapter(sql1, dbhelper.Connection);
            adaPterStu.Fill(ds_Compose, "Student");
            SqlDataAdapter adaPterSub = new SqlDataAdapter(sql2, dbhelper.Connection);
            adaPterSub.Fill(ds_Compose, "SubjectId");
            adaPterRes = new SqlDataAdapter(sql3, dbhelper.Connection);
            adaPterRes.Fill(ds_Compose, "Result");

            

            DataTable table = new DataTable("TAB_MM");

            ds.Tables.Add(table);
            //获取列的集合，添加列
            DataColumnCollection columns = table.Columns;
            columns.Add("StuName", typeof(String));
            columns.Add("SubName", typeof(String));
            columns.Add("Result", typeof(Int32));
            columns.Add("TestTime", typeof(DateTime));
            //添加一行数据
            DataRow row = null;
            //接收学号
            int i = 0;
            
            //拿姓名到Student表里查出对应的学号
            #region 获取学号
            foreach (DataRow item in ds_Compose.Tables[0].Rows)
            {
                if (item["StudentName"].ToString().Equals(name))
                {
                    stuNo = item["StudentNo"].ToString();
                    break;
                }
            }
            #endregion
            #region 用学号查Result表
            foreach(DataRow item in ds_Compose.Tables[2].Rows)
            {
                if (item["StudentNo(学号)"].ToString().Equals(stuNo))
                {
                    row = table.NewRow();
                    row["StuName"] = name;
                    row["SubName"] = ds_Compose.Tables[2].Rows[i]["SubjectId(所考科目)"];
                    row["Result"] = ds_Compose.Tables[2].Rows[i]["StudentResult(分数)"];
                    row["TestTime"] = ds_Compose.Tables[2].Rows[i]["ExamData(考试日期)"];
                    ds.Tables[0].Rows.Add(row);
                    
                }
                i++;
            }
            //ds.Tables[0].Rows.Add(row);
            #endregion
            

            

            
            



            //加载到窗口
            dataGridView1.DataSource = ds.Tables["TAB_MM"];

        }

        //cbo_Subject赋值
        public void LoadCbo_Subject()
        {
            foreach (DataRow item in ds_Compose.Tables[1].Rows)
            {
                cbo_Subject.Items.Add(item["SubjectName(科目名称)"]);
            }
            cbo_Subject.SelectedIndex = 0;
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            LoadReault();
        }
        //点击列表窗口赋值
        public void LoadReault()
        {
            //获取点击列的值
            string res = string.Empty;
            DateTime year = new DateTime();
            if (this.dataGridView1.SelectedCells.Count > 0 && (this.dataGridView1.SelectedCells[2].Value).ToString() != "" || (this.dataGridView1.SelectedCells[3].Value).ToString() != "")
            {
                res = Convert.ToString(this.dataGridView1.SelectedCells[2].Value);
                year = Convert.ToDateTime(this.dataGridView1.SelectedCells[3].Value);
                txt_Result.Text = res.Trim();
                dtp_Time.Text = year.ToString();
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            addDs();
        }
        //添加数据到ds
        public void addDs()
        {
            string subject = cbo_Subject.Text.Trim();
            string reault = txt_Result.Text.Trim();
            string time = dtp_Time.Text.Trim();
            //新建行
            DataRow row = ds.Tables[0].NewRow();
            row["StuName"] = name;
            row["SubName"] = subject;
            row["Result"] = reault;
            row["TestTime"] = time;
            //将数据填充到dsz中下标为0的表中
            ds.Tables[0].Rows.Add(row);

            
        }


        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult ult = MessageBox.Show("是否保存", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (ult == DialogResult.OK)
            {
                Setds_Compose();
            }
        }
        

        //将对应的数据放到对应的大表中
        public void Setds_Compose()
        {
            string subject = string.Empty;
            string subId = string.Empty;
            string result = string.Empty;
            string time = string.Empty;

            //获取最新添加的科目
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                subject = item["SubName"].ToString();
                result = item["Result"].ToString();
                time = item["TestTime"].ToString();

            }
            foreach (DataRow item in ds_Compose.Tables[1].Rows)
            {
                if (item["SubjectName(科目名称)"].ToString().Equals(subject))
                {
                    subId = item["SubjectId(科目编号)"].ToString();
                    break;
                }
            }
            /// <summary>
            /// 将数据插入到大表
            /// </summary>
             
            //1.新建行
            DataRow row = ds_Compose.Tables[2].NewRow();
            
            row["StudentNo(学号)"] = this.stuNo;
            row["SubjectId(所考科目)"] = subId;
            row["StudentResult(分数)"] = result;
            row["ExamData(考试日期)"] = time;
            
            ds_Compose.Tables[2].Rows.Add(row);
            
            //更新到数据库
            try
            {
                dbhelper.OpenConnection();
                SqlCommandBuilder bulider = new SqlCommandBuilder(adaPterRes);
                adaPterRes.Update(ds_Compose, "Result");
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
        
    }
}
