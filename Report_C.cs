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
    class Report_C : Report
    {
        List<string> names = new List<string>();
        private string connectionString = "Data Source=STIG; Initial Catalog=Sales_manager_DB; User ID=sa;Password=server1739";


        public void SaveCompleteReport(string pathName)
        {
            FillNames();
            StreamWriter sw = new StreamWriter(pathName + @"\Report C.txt");
    
            SqlConnection connection_to_DB = new SqlConnection(connectionString);
            connection_to_DB.Open();
            foreach (string name in names)
            {
                sw.WriteLine("Клиент по имени " + name + " давно не покупает следующие товары: ");
                SqlDataReader dataReader;
                string SQLcommand = "select distinct(orderItem) from Orders where orderItem not in (select o.OrderItem from Orders o, Client c where c.ID = o.Client_FK and c.Name = '"+name+"'"
                            + " and month(o.OrderDate) >= month(CONVERT(date, SYSDATETIME())) - 2)";
                SqlCommand command_to_database = new SqlCommand(SQLcommand, connection_to_DB);

                dataReader = command_to_database.ExecuteReader();
                while (dataReader.Read())
                {
                    sw.WriteLine(dataReader.GetValue(0));
                }
                dataReader.Close();
                command_to_database.Dispose();
            }
            sw.Close();
            connection_to_DB.Close();
            MessageBox.Show("Report written");
        }

        public void FillNames()
        {
            string connectionString = "Data Source=STIG; Initial Catalog=Sales_manager_DB; User ID=sa;Password=server1739";
            SqlDataReader dataReader;
            string SQLcommand = "Select ID, Rtrim(name) from Client";
            SqlConnection connection_to_DB = new SqlConnection(connectionString);
            SqlCommand command_to_database = new SqlCommand(SQLcommand, connection_to_DB);

            connection_to_DB.Open();
            dataReader = command_to_database.ExecuteReader();
            while (dataReader.Read())
            {
                names.Add(dataReader.GetString(1));
            }
            dataReader.Close();
            command_to_database.Dispose();
            connection_to_DB.Close();
        }
    }
}
