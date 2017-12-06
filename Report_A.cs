using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sales_Manager
{
    class Report_A:Report
    {
        public void SaveCompleteReport(string pathName)
        {
            int tempCount = 0;
            //string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter sw = new StreamWriter(pathName+@"\Report A.txt");

            string connectionString = "Data Source=STIG; Initial Catalog=Sales_manager_DB; User ID=sa;Password=server1739";

            SqlDataReader dataReader;
            string SQLcommand1 = "select MONTH(orderDate), sum(o.amount)  from orders as o where year(o.orderDate)=year(CONVERT (date, SYSDATETIME())) group by MONTH(orderDate);";
            string SQLcommand2 = "select MONTH(orderDate), avg(o.amount)  from orders as o where year(o.orderDate)=year(CONVERT (date, SYSDATETIME())) group by MONTH(orderDate);";
            string SQLcommand3 = "select MONTH(orderDate) as mon,orderItem,sum(o.quantity) as SUMM from orders as o where year(o.orderDate)=year(CONVERT (date, SYSDATETIME())) group by MONTH(orderDate), orderItem  order by mon, summ desc;";//!!;
            string SQLcommand4 = "select MONTH(orderDate) as mon, RTRIM(c.Name), count(OrderItem) as co from orders as o, client as c where o.client_FK=c.ID group by MONTH(orderDate), c.Name order by mon,co desc;";//!!
            SqlConnection connection_to_DB = new SqlConnection(connectionString);
            SqlCommand command_to_database1 = new SqlCommand(SQLcommand1, connection_to_DB);
            SqlCommand command_to_database2 = new SqlCommand(SQLcommand2, connection_to_DB);
            SqlCommand command_to_database3 = new SqlCommand(SQLcommand3, connection_to_DB);
            SqlCommand command_to_database4 = new SqlCommand(SQLcommand4, connection_to_DB);

            try
            {
                connection_to_DB.Open();

                dataReader = command_to_database1.ExecuteReader();
                while (dataReader.Read())
                {
                    sw.WriteLine("Сумма продаж за " + dataReader.GetValue(0)+" месяц составляет "+ dataReader.GetValue(1)+" единиц");
                }
                dataReader.Close();
                command_to_database1.Dispose();

                dataReader = command_to_database2.ExecuteReader();
                while (dataReader.Read())
                {
                    sw.WriteLine("Средний чек за " + dataReader.GetValue(0) + " месяц составляет " + dataReader.GetValue(1) + " единиц");
                }
                dataReader.Close();
                command_to_database2.Dispose();

                dataReader = command_to_database3.ExecuteReader();
                while (dataReader.Read())
                {
                    if (tempCount != dataReader.GetInt32(0))
                    {
                        sw.WriteLine("Самый продаваемый товар за " + dataReader.GetValue(0) + " месяц - " + dataReader.GetValue(1));
                    }
                    tempCount = dataReader.GetInt32(0);
                }
                dataReader.Close();
                command_to_database3.Dispose();

                tempCount = 0;
                dataReader = command_to_database4.ExecuteReader();
                while (dataReader.Read())
                {
                    if (tempCount != dataReader.GetInt32(0))
                    {
                        sw.WriteLine("Самый активный за " + dataReader.GetValue(0) + " месяц клиент - " + dataReader.GetValue(1));
                    }
                    tempCount = dataReader.GetInt32(0);
                }
                dataReader.Close();
                command_to_database4.Dispose();

                sw.Close();
                connection_to_DB.Close();
                MessageBox.Show("Report written");
            }
            catch
            {
                MessageBox.Show("ERROR");
                return;   
            }
        }
    }
}
