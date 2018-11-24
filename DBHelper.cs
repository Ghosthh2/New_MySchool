using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Demo1
{
    class DBHelper
    {
        //数据库连接字符串
        private static string connString = @"Data Source=DESKTOP-4JQ8L9K\MSSQLSERVERZ;Initial Catalog=Student;Persist Security Info=True;User ID=sa;Password=qq1816858916";

        //数据库连接Connection对象
        private SqlConnection connection = new SqlConnection(connString);

        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }


        //打开数据库连接 
        public void OpenConnection()
        {
            //与数据库状态断开
            if (Connection.State == ConnectionState.Closed)
            {

                //打开连接
                Connection.Open();
                Console.Write("连接成功");
            }
            //与数据连接中断
            else if (Connection.State == ConnectionState.Broken)
            {
                //先关闭
                Connection.Close();
                //再打开
                Connection.Open();
                Console.Write("连接成功");
            }
            
        }

        //关闭数据库连接
        public void CloseConnection()
        {
            //数据库打开 和 连接中断
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
            {
                //关闭数据库
                Connection.Close();
            }
        }

        //
    }
}
