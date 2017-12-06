using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Data.SqlClient;

namespace Sales_Manager
{
    public partial class Form1 : Form
    {
        Report_A ReportA;
        Report_B ReportB;
        Report_C ReportC;
        Managment Managment;
        public DateTime OrderDate;
        private string selectedFolder = "";

        public Form1()
        {
            InitializeComponent();
            OrderDate = dateTimePicker1.Value;
        }

        private void Test_button_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = selectedFolder;
            openFileDialog1.Filter = "Report files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FileName = "TEST data.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(selectedFolder + @"\TEST_data.txt"))
                {
                    string name;
                    while ((name=reader.ReadLine()) != null)
                    {
                        //string name = reader.ReadLine();
                        string orderItem = reader.ReadLine();
                        decimal cost = Convert.ToDecimal(reader.ReadLine());
                        int quantity = Convert.ToInt32(reader.ReadLine());
                        DateTime orderdate = Convert.ToDateTime(reader.ReadLine());
                        Managment = new Managment(name, orderItem, cost, quantity, orderdate);
                        Managment.AddOrder();
                    }
                }
            }
            DisplayData();
        }

        private void report_A_button_Click(object sender, EventArgs e)
        {
                ReportA=new Report_A();
                ReportA.SaveCompleteReport(selectedFolder);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_textBox.Text) || string.IsNullOrEmpty(Item_textBox.Text)
                || string.IsNullOrEmpty(Cost_textBox.Text) || string.IsNullOrEmpty(Quantity_textBox.Text))
            {
                MessageBox.Show("Please specify order information", "Unable to add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                Managment = new Managment(Name_textBox.Text, Item_textBox.Text,Convert.ToDecimal(Cost_textBox.Text), 
                    Convert.ToInt32(Quantity_textBox.Text), OrderDate);
                Managment.AddOrder();

            DisplayData();
        }

        private void Folder_button_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (!String.IsNullOrEmpty(folderBrowserDialog1.SelectedPath) && result == DialogResult.OK)
            {
                report_A_button.Enabled = true;
                report_B_button.Enabled = true;
                report_C_button.Enabled = true;
                Test_button.Enabled = true;
                selectedFolder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void report_B_button_Click(object sender, EventArgs e)
        {
            ReportB = new Report_B();
            ReportB.SaveCompleteReport(selectedFolder);
        }

        private void report_C_button_Click(object sender, EventArgs e)
        {
                ReportC = new Report_C();
                ReportC.SaveCompleteReport(selectedFolder);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            OrderDate=dateTimePicker1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sales_manager_DBDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.sales_manager_DBDataSet1.Orders);
            // TODO: This line of code loads data into the 'sales_manager_DBDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.sales_manager_DBDataSet.Orders);
            // TODO: This line of code loads data into the 'sales_manager_DBDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sales_manager_DBDataSet.Client);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.FillBy(this.sales_manager_DBDataSet.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayData()
        {
            string connectionString = "Data Source=STIG; Initial Catalog=Sales_manager_DB; User ID=sa;Password=server1739";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT o.ID, c.Name, o.OrderItem, o.Cost, o.Quantity, o.OrderDate, o.Amount"+
                    " FROM Orders AS o INNER JOIN  Client AS c ON o.Client_FK = c.ID", connection);
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            connection.Close();
        }
    }
}
