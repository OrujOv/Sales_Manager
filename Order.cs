using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace Sales_Manager
{
    class Order
    {
        private DateTime orderDate { get; set; }
        private string orderItem { get; set; }
        private decimal cost { get; set; }
        private int quantity { get; set; }
        private int clientId;
        private int id;
        private string connectionString = "Data Source=STIG; Initial Catalog=Sales_manager_DB; User ID=sa;Password=server1739";


        public Order (int client, string orderItem, decimal cost, int quantity, DateTime orderDate)
        {
            this.orderItem = orderItem;
            this.cost = cost;
            this.quantity = quantity;
            this.orderDate = orderDate;
            this.clientId = client;
        }

        public void AddOrder()
        {
            id = GetOrderId() + 1;
            string format = "yyyy-MM-dd";
            string date = orderDate.Date.ToString(format);
            string SQLcommand = "INSERT INTO orders values (" + id + ","+clientId+ ",'"+orderItem +
                "',"+cost.ToString("0.00", CultureInfo.GetCultureInfo("en-US")) + ","
                +quantity+ ",convert(date,'" + date +"'),"+(cost*quantity).ToString("0.00", CultureInfo.GetCultureInfo("en-US")) + ");";
            SqlConnection connection_to_DB = new SqlConnection(connectionString);
            SqlCommand command_to_database = new SqlCommand(SQLcommand, connection_to_DB);
            connection_to_DB.Open();
            command_to_database.ExecuteNonQuery();
            connection_to_DB.Close();
        }

        public int GetOrderId()
        {
            int temp = 0;

            SqlDataReader dataReader;
            string SQLcommand1 = "Select ISNULL(MAX(ID), 0) from orders";
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
