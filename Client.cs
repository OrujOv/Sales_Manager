using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sales_Manager
{
    class Client
    {
        //private int Id;
        private string name { get; set; }
        private int id;
        public int Id { get { return id; } }
        private string connectionString = "Data Source=STIG; Initial Catalog=Sales_manager_DB; User ID=sa;Password=server1739";


        public Client (string name)
        {
            this.name = name;
        }

        public int AddClientName()
        {
            id = CheckName(name);
            if (Id == 0)
            {
                id = GetMaxId() + 1;

                SqlConnection connection_to_DB = new SqlConnection(connectionString);
                string SQLcommand = "INSERT INTO client values (" + Id + ",'" + name + "');";
                SqlCommand command_to_database1 = new SqlCommand(SQLcommand, connection_to_DB);
                connection_to_DB.Open();
                command_to_database1.ExecuteNonQuery();
                connection_to_DB.Close();
                return Id;
            }
            else return Id;
        }

        public int CheckName(string Name)
        {
            int temp = 0;
            string tem_str;

            string connectionString = "Data Source=STIG; Initial Catalog=Sales_manager_DB; User ID=sa;Password=server1739";
            SqlDataReader dataReader;
            string SQLcommand = "Select ISNULL(ID,0), ISNULL(Rtrim(name),'NULL') from client";
            SqlConnection connection_to_DB = new SqlConnection(connectionString);
            SqlCommand command_to_database = new SqlCommand(SQLcommand, connection_to_DB);

            connection_to_DB.Open();
            dataReader = command_to_database.ExecuteReader();
            while (dataReader.Read())
            {
                tem_str = dataReader.GetString(1);
                if (tem_str == name)
                {
                    temp = dataReader.GetInt32(0);
                }
            }
            dataReader.Close();
            command_to_database.Dispose();
            connection_to_DB.Close();

            return temp;

        }

        public int GetMaxId()
        {
            int temp = 0;

            SqlDataReader dataReader;
            string SQLcommand1 = "Select ISNULL(MAX(ID), 0) from client";
            SqlConnection connection_to_DB = new SqlConnection(connectionString);
            SqlCommand command_to_database = new SqlCommand(SQLcommand1, connection_to_DB);

            connection_to_DB.Open();
            dataReader = command_to_database.ExecuteReader();
            while (dataReader.Read())
            {
                temp = dataReader.GetInt32(0);
            }
            dataReader.Close();
            command_to_database.Dispose();
            connection_to_DB.Close();
            return temp;
        }
    }
}
