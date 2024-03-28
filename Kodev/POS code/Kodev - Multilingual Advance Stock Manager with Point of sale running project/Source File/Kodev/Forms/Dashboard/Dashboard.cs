using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodev.Forms.Dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(clsUtility.CnString);
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Day_Credit", con);
            adapt.Fill(ds);
            Credit.DataSource = ds;
            Credit.Titles.Add("Credit");
            Credit.Series["Credit"].XValueMember = "Dayss";
            Credit.Series["Credit"].YValueMembers = "Credit";
            con.Close();                                  




            con.Open();
            SqlDataAdapter adapt3 = new SqlDataAdapter("select * from day_sales", con);
            adapt3.Fill(ds);
            Sales.DataSource = ds;
            Sales.Titles.Add("Sales");
            Sales.Series["Sales"].XValueMember = "Day1";
            Sales.Series["Sales"].YValueMembers = "Sales";
            con.Close();





            con.Open();
            SqlDataAdapter adapt5 = new SqlDataAdapter("select * from price", con);
            adapt5.Fill(ds);
            Price.DataSource = ds;
            Price.Titles.Add("Top 5 Highest sellling item by Price");
            Price.Series["Price"].XValueMember = "ItemName";
            Price.Series["Price"].YValueMembers = "TotalPrice";
            con.Close();






            con.Open();
            SqlDataAdapter adapt6 = new SqlDataAdapter("select * from Quantity", con);
            adapt6.Fill(ds);
            Quantity.DataSource = ds;
            Quantity.Titles.Add("Top 5 Highest selling item by Quantity");
            Quantity.Series["Quantity"].XValueMember = "ItemName";
            Quantity.Series["Quantity"].YValueMembers = "Quantity";
            con.Close();





            con.Open();
            SqlDataAdapter adapt15 = new SqlDataAdapter("select * from Day_Purchase", con);
            adapt15.Fill(ds);
            Purchase.DataSource = ds;
            Purchase.Titles.Add("Purchase");
            Purchase.Series["Purchase"].XValueMember = "days";
            Purchase.Series["Purchase"].YValueMembers = "purchase";
            con.Close();


            con.Open();
            SqlDataAdapter adapt4 = new SqlDataAdapter("select * from Day_Return", con);
            adapt4.Fill(ds);
            Return.DataSource = ds;
            Return.Titles.Add("Sales return");
            Return.Series["Return"].XValueMember = "Days";
            Return.Series["Return"].YValueMembers = "Salesreturn";
            con.Close();


        }

        //private void Dashboard_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'dsOrion.Quantity' table. You can move, or remove it, as needed.
        //    this.quantityTableAdapter2.Fill(this.dsOrion.Quantity);
        //    // TODO: This line of code loads data into the 'dsOrion.Day_Return' table. You can move, or remove it, as needed.
        //    this.day_ReturnTableAdapter2.Fill(this.dsOrion.Day_Return);
        //    // TODO: This line of code loads data into the 'dsOrion.Day_Purchase' table. You can move, or remove it, as needed.
        //    this.day_PurchaseTableAdapter2.Fill(this.dsOrion.Day_Purchase);
        //    // TODO: This line of code loads data into the 'dsOrion.price' table. You can move, or remove it, as needed.
        //    this.priceTableAdapter2.Fill(this.dsOrion.price);
        //    // TODO: This line of code loads data into the 'dsOrion.Day_Credit' table. You can move, or remove it, as needed.
        //    this.day_CreditTableAdapter2.Fill(this.dsOrion.Day_Credit);
        //    // TODO: This line of code loads data into the 'dsOrion.day_sales' table. You can move, or remove it, as needed.
        //    this.day_salesTableAdapter2.Fill(this.dsOrion.day_sales);

        //}
    }
}
