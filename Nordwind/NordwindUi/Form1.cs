using NordwindDal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NordwindUi
{
    public partial class Form1 : Form
    {
             NorthwindContext context = new NorthwindContext();

       public Form1()
        {
            InitializeComponent();

            context.Database.Log = LogIt;

        }

        private void LogIt(string logString)
        {
            textBox1.Text = $"{textBox1.Text}{logString}\n\r";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var qCountries = (from cu in context.Customers
                              select cu.Country).Distinct();

            foreach (var country in qCountries)
            {
                TreeNode ndCountry = new TreeNode(country);
                ndCountry.Nodes.Add(new TreeNode());
                treeView1.Nodes.Add(ndCountry);
            }


            
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            //NorthwindContext context = new NorthwindContext();

            string country = e.Node.Text;

            e.Node.Nodes.Clear();

            var qCustomers = from cu in context.Customers
                             where cu.Country == country
                             select cu; // new { cu.CustomerID, cu.CompanyName };

            Customer cust = qCustomers.First();

            //cust.Orders.First().Order_Details.Skip(10).Take(25)....

            foreach (var customer in qCustomers)
            {
                TreeNode tnCustomer = new TreeNode(customer.CompanyName);
                e.Node.Nodes.Add(tnCustomer);
            }

        }
    }
}
