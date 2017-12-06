using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sales_Manager
{
    class Managment
    {
        public DateTime OrderDate { get; set; }
        private string name { get; set; }
        private string orderItem { get; set; }
        private decimal cost { get; set; }
        private int quantity { get; set; }

        public Order order { get; set; }
        public Client client { get; set; }

        public Managment (string name, string orderItem, decimal cost, int quantity, DateTime orderDate)
        {
            this.name = name;
            this.orderItem = orderItem;
            this.cost = cost;
            this.quantity = quantity;
            this.OrderDate = orderDate;
        }

        public void AddOrder()
        {
                client = new Client(name);
                int ClientId=client.AddClientName();

                order = new Order(ClientId, orderItem, cost, quantity, OrderDate);
                order.AddOrder();
                MessageBox.Show("Order added");

        }
    }
}
