using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Sales_Manager
{
    class Report_B:Report
    {
        public void SaveCompleteReport(string pathName)
        {
            string tempName = "";
            //string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter sw = new StreamWriter(pathName + @"\Report B.txt");

            string connectionString = "Data Source=STIG; Initial Catalog=Sales_manager_DB; User ID=sa;Password=server1739";

            SqlDataReader dataReader;
            string SQLcommand1 = "select RTRIM(c.Name), sum(o.amount) from orders as o, client as c where o.client_FK = c.ID and year(o.orderDate) = year(CONVERT(date, SYSDATETIME())) group by c.Name";
            string SQLcommand2 = "select RTRIM(c.Name), avg(o.amount) from orders as o, client as c where o.client_FK = c.ID and year(o.orderDate) = year(CONVERT(date, SYSDATETIME())) group by c.Name";
            string SQLcommand3 = "select RTRIM(c.Name), MONTH(orderDate), avg(o.amount) as am"
                + " from orders as o, client as c where o.client_FK = c.ID and year(o.orderDate) = year(CONVERT(date, SYSDATETIME())) group by c.Name, MONTH(orderDate) order by Name, am desc;";//!!
            SqlConnection connection_to_DB = new SqlConnection(connectionString);
            SqlCommand command_to_database1 = new SqlCommand(SQLcommand1, connection_to_DB);
            SqlCommand command_to_database2 = new SqlCommand(SQLcommand2, connection_to_DB);
            SqlCommand command_to_database3 = new SqlCommand(SQLcommand3, connection_to_DB);
            SqlCommand command_to_database4 = new SqlCommand(SQLcommand3, connection_to_DB);

            try
            {
                connection_to_DB.Open();

                dataReader = command_to_database1.ExecuteReader();
                while (dataReader.Read())
                {
                    sw.WriteLine("Сумма потраченная клиентом " + dataReader.GetValue(0) + " составляет " + dataReader.GetValue(1) + " единиц");
                }
                dataReader.Close();
                command_to_database1.Dispose();

                dataReader = command_to_database2.ExecuteReader();
                while (dataReader.Read())
                {
                    sw.WriteLine("Сумма среднего чек клиента " + dataReader.GetValue(0) + " составляет " + dataReader.GetValue(1) + " единиц");
                }
                dataReader.Close();
                command_to_database2.Dispose();

                dataReader = command_to_database3.ExecuteReader();
                while (dataReader.Read())
                {
                    if (tempName != dataReader.GetString(0))
                    {
                        sw.WriteLine("Максимальная сумма среднего чека за месяц по клиенту " + dataReader.GetValue(0) 
                            +" составляет: " + dataReader.GetValue(2) + " единиц");
                    }
                    tempName = dataReader.GetString(0);
                }
                dataReader.Close();
                command_to_database3.Dispose();

                tempName = "";
                dataReader = command_to_database4.ExecuteReader();
                while (dataReader.Read())
                {
                    if (tempName != dataReader.GetString(0))
                    {
                        sw.WriteLine("Номер месяца, когда сумма среднего чека была максимальной по клиенту " + dataReader.GetValue(0)
                            + " : " + dataReader.GetValue(1));
                    }
                    tempName = dataReader.GetString(0);
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
