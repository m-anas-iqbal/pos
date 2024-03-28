﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kodev
{
    public partial class frmPOS : Form
    {

        public frmPOS(String SALES_ID)
        {
            InitializeComponent();
            txtInvoiceNo.Text = SALES_ID;
        }

        private void LoadLanguegePack()
        {
            if (Properties.Settings.Default.App_Default_Language)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(@"Language\" + Properties.Settings.Default.App_Language + ".xml");
                    XmlNodeList languageNodes = xmlDocument.GetElementsByTagName("language");
                    foreach (XmlNode languageNode in languageNodes)
                    {

                        XmlNode l1077 = languageNode["l1077"];
                        chkCustomerDisplay.Text = l1077.InnerText;

                        XmlNode l1078 = languageNode["l1078"];
                        chkItemDisplay.Text = l1078.InnerText;

                        XmlNode l1030 = languageNode["l1030"];
                        lbl1030.Text = l1030.InnerText;

                        XmlNode l1034 = languageNode["l1034"];
                        lbl1034.Text = l1034.InnerText;

                        XmlNode l1065 = languageNode["l1065"];
                        lbl1065.Text = l1065.InnerText;

                        XmlNode l1068 = languageNode["l1068"];
                        lbl1068.Text = l1068.InnerText;

                        XmlNode l1069 = languageNode["l1069"];
                        lbl1069.Text = l1069.InnerText;

                        XmlNode l1070 = languageNode["l1070"];
                        lbl1070.Text = l1070.InnerText;

                        XmlNode l1071 = languageNode["l1071"];
                        lbl1071.Text = l1071.InnerText;

                        XmlNode l1072 = languageNode["l1072"];
                        lbl1072.Text = l1072.InnerText;

                        XmlNode l1073 = languageNode["l1073"];
                        lbl1073.Text = l1073.InnerText;

                        XmlNode l1074 = languageNode["l1074"];
                        lbl1074.Text = l1074.InnerText;

                        XmlNode l1075 = languageNode["l1075"];
                        lbl1075.Text = l1075.InnerText;

                        XmlNode l1076 = languageNode["l1076"];
                        lbl1076.Text = l1076.InnerText;

                        XmlNode ctrlComplete = languageNode["ctrlComplete"];
                        btnComplete.Text = ctrlComplete.InnerText;

                        XmlNode ctrlClose = languageNode["ctrlClose"];
                        btnClose.Text = ctrlClose.InnerText;

                        XmlNode ctrlNew = languageNode["ctrlNew"];
                        btnNew.Text = ctrlNew.InnerText;

                        XmlNode ctrlPrint = languageNode["ctrlPrint"];
                        btnReceipt.Text = ctrlPrint.InnerText;

                        XmlNode ctrlSave = languageNode["ctrlSave"];
                        btnSave.Text = ctrlSave.InnerText;

                        XmlNode l1183 = languageNode["l1183"];
                        XmlNode l1046 = languageNode["l1046"];
                        XmlNode l1053 = languageNode["l1053"];

                        dataGridView1.Columns["Column2"].HeaderText = l1030.InnerText;
                        dataGridView1.Columns["Column3"].HeaderText = l1053.InnerText;
                        dataGridView1.Columns["Column5"].HeaderText = l1183.InnerText;
                        dataGridView1.Columns["Column11"].HeaderText = l1071.InnerText;
                        dataGridView1.Columns["Column10"].HeaderText = l1069.InnerText;
                        dataGridView1.Columns["Column6"].HeaderText = l1046.InnerText;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransactionNo_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue, myValue;
            message = "Enter Bank Transaction No";
            title = "Transaction No";
            defaultValue = "";
            myValue = Interaction.InputBox(message, title, defaultValue, 100, 100);
            if (myValue == "")
            {
                clsUtility.ExecuteSQLQuery(" SELECT * FROM SalesInfo  WHERE SALES_ID='" + txtInvoiceNo.Text + "' ");
                myValue = clsUtility.sqlDT.Rows[0]["TrnsNo"].ToString();
            }
            else
            {
                clsUtility.ExecuteSQLQuery(" UPDATE SalesInfo SET TrnsNo='" + myValue + "' WHERE SALES_ID='" + txtInvoiceNo.Text + "' ");
            } 
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            LoadLanguegePack();
            chkItemDisplay.Checked = Properties.Settings.Default.App_ItemDisplay;
            chkCustomerDisplay.Checked = Properties.Settings.Default.App_CustomerDisplay;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            clsUtility.ExecuteSQLQuery("SELECT * FROM loyaltypoints");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
               label6.Text = clsUtility.sqlDT.Rows[0]["pointvalue"].ToString();
                
            }
            clsUtility.FillComboBox(" SELECT  ITEM_ID, ItemName  FROM  ItemInformation  ORDER BY ItemName", "ITEM_ID", "ItemName", cmbItemName);

            // Item List
            if (Properties.Settings.Default.App_ItemDisplay) {
                LoadGroupPanel();
                clsUtility.ExecuteSQLQuery("  SELECT   *  FROM  ItemGroup  ORDER BY GROUP_ID ");
                if (clsUtility.sqlDT.Rows.Count > 0) { LoadProductPanel(clsUtility.sqlDT.Rows[0]["GROUP_ID"].ToString()); }
            }


            if (txtInvoiceNo.Text == "0")
            {
                clsUtility.ExecuteSQLQuery("SELECT  *   FROM  SalesInfo WHERE  USER_ID = '" + clsUtility.UserID + "' AND Terminal='POS'  ORDER BY SALES_ID DESC");
                if (clsUtility.sqlDT.Rows.Count > 0)
                {
                    string DEC_SALES_ID = clsUtility.sqlDT.Rows[0]["SALES_ID"].ToString();
                    txtCustomerID.Text = clsUtility.sqlDT.Rows[0]["CUST_ID"].ToString();
                    clsUtility.ExecuteSQLQuery(" SELECT * FROM   Sales  WHERE SALES_ID = '" + DEC_SALES_ID + "' ");
                    if (clsUtility.sqlDT.Rows.Count > 0) { CreateNewInvoice(); LoadSalesItem(); } else { txtInvoiceNo.Text = DEC_SALES_ID; }
                }
                else { CreateNewInvoice(); LoadSalesItem(); }
            }
            else { LoadSalesItem(); }


        }

        private void LoadGroupPanel()
        {
            pnlGroup.Controls.Clear();
            clsUtility.ExecuteSQLQuery(" SELECT   *  FROM  ItemGroup ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                int i;
                for (i = 0; i <= clsUtility.sqlDT.Rows.Count - 1; i++)
                {
                    Button grpButton = new Button();
                    grpButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                    grpButton.TextAlign = ContentAlignment.MiddleLeft;
                    grpButton.ImageAlign = ContentAlignment.MiddleLeft;
                    grpButton.Name = clsUtility.sqlDT.Rows[i]["GROUP_ID"].ToString();
                    grpButton.Text = clsUtility.sqlDT.Rows[i]["GROUP_NAME"].ToString();
                    grpButton.Size = new System.Drawing.Size(153, 28);
                    grpButton.Image = Kodev.Properties.Resources.shopping_cart;
                    grpButton.Click += Grp_Click;
                    pnlGroup.Controls.Add(grpButton);
                }
            }
        }

        private void Grp_Click(object sender, EventArgs e)
        {
           Button button = sender as Button;
           LoadProductPanel(button.Name);
        }

        private void LoadProductPanel(string GROUP_ID)
        {
            ItemPanelView.Controls.Clear();
            clsUtility.ExecuteSQLQuery(" SELECT  *  FROM   ItemInformation WHERE (GROUP_ID = '" + GROUP_ID + "') ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                int i;
                string ITEM_DIR = Application.StartupPath + @"\Upload\ItemImage\";
                for (i = 0; i <= clsUtility.sqlDT.Rows.Count - 1; i++)
                {
                    Button picturebx = new Button();
                    picturebx.BackColor = Color.White;
                    picturebx.TextImageRelation = TextImageRelation.ImageBeforeText;
                    picturebx.TextAlign = ContentAlignment.MiddleLeft;
                    picturebx.ImageAlign = ContentAlignment.MiddleLeft;
                    picturebx.Name = clsUtility.sqlDT.Rows[i]["ITEM_ID"].ToString();
                    picturebx.Text = clsUtility.sqlDT.Rows[i]["ItemName"].ToString();
                    picturebx.Text += Environment.NewLine + "Barcode: " + clsUtility.sqlDT.Rows[i]["Barcode"];
                    picturebx.Text += Environment.NewLine + "Price: " + clsUtility.sqlDT.Rows[i]["Price"];
                    picturebx.Size = new System.Drawing.Size(206, 89);
                    try
                    {
                        picturebx.Image = resizeImage(Image.FromFile(ITEM_DIR + clsUtility.sqlDT.Rows[i]["PhotoFileName"].ToString()), new Size(74, 71));
                    }
                    catch (Exception) { picturebx.Image = resizeImage(Kodev.Properties.Resources.No_image_found, new Size(74, 71)); }
                    picturebx.Click += Product_Click;
                    ItemPanelView.Controls.Add(picturebx);
                }
            }
        }

        private void Product_Click(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text != "")
            {
                Button button = sender as Button;
                InsertSalesItem(button.Name, 1);
                LoadSalesItem();
            }
            else { MessageBox.Show("Empty Invoice.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void CreateNewInvoice()
        {
            clsUtility.ExecuteSQLQuery(" INSERT INTO SalesInfo  ( SalesDate, SalesTime,  ItemPrice,  VAT,  Discount,  GrandTotal,   CashPay, CardPay,  EntreBy,  Due, Comment, Terminal, CUST_ID, TrnsNo, ShippingName, ShippingAddress, ShippingContact, USER_ID,redeem_pt) VALUES " +
                   " ('" + dtpSalesDate.Value.Date.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("hh:mm") + "',  '" + clsUtility.num_repl(txtNetAmount.Text) + "',  '" + clsUtility.num_repl(txtVAT.Text) + "',  0,  0, 0, 0, '" + clsUtility.UserName + "', 0, '-', 'POS', 0, '-' , '-', '-', '-', '" + clsUtility.UserID + "',0) ");
            clsUtility.ExecuteSQLQuery("SELECT  *  FROM   SalesInfo    ORDER BY SALES_ID DESC");
            txtInvoiceNo.Text = clsUtility.sqlDT.Rows[0]["SALES_ID"].ToString();
            txtCustomerID.Text = clsUtility.sqlDT.Rows[0]["CUST_ID"].ToString();
            txtDiscountPercent.Text = "0";
        }

        private void LoadSalesItem()
        {
            clsUtility.FillDataGrid(" SELECT ID, ItemName, QTY, Discount_amount, Sales.Price, TotalPrice, TotalVat, ExprDate " +
                                    " FROM Sales left join Dis_percentage on Sales.ITEM_ID = Dis_percentage.item_id left JOIN ItemInformation ON ItemInformation.ITEM_ID = Sales.ITEM_ID WHERE Sales.SALES_ID ='" + txtInvoiceNo.Text + "' ", dataGridView1);

             clsUtility.ExecuteSQLQuery("SELECT *  FROM  SalesInfo    WHERE (SALES_ID = '" + txtInvoiceNo.Text + "')");
             if (clsUtility.sqlDT.Rows.Count > 0)
             {
                string s1, s2, s3, s4, s5, s6, s7,s8;
                s1   = clsUtility.sqlDT.Rows[0]["CUST_ID"].ToString();
                s2 = clsUtility.sqlDT.Rows[0]["Discount"].ToString();
                s3 = clsUtility.sqlDT.Rows[0]["GrandTotal"].ToString();
                s4 = clsUtility.sqlDT.Rows[0]["Due"].ToString();
                s5 = clsUtility.sqlDT.Rows[0]["VAT"].ToString();
                s6 = clsUtility.sqlDT.Rows[0]["CashPay"].ToString();
                s7 = clsUtility.sqlDT.Rows[0]["CardPay"].ToString();
                s8 = clsUtility.sqlDT.Rows[0]["redeem_pt"].ToString();
                //label6.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8;
                txtCustomerID.Text = clsUtility.sqlDT.Rows[0]["CUST_ID"].ToString();
                 txtDiscount.Text = clsUtility.sqlDT.Rows[0]["Discount"].ToString();
                 txtGrandTotal.Text = clsUtility.sqlDT.Rows[0]["GrandTotal"].ToString();
                 txtDue.Text = clsUtility.sqlDT.Rows[0]["Due"].ToString();
                 txtVAT.Text = clsUtility.sqlDT.Rows[0]["VAT"].ToString();
                 txtCash.Text = clsUtility.sqlDT.Rows[0]["CashPay"].ToString();
                 txtCard.Text = clsUtility.sqlDT.Rows[0]["CardPay"].ToString();
                 point.Text = clsUtility.sqlDT.Rows[0]["redeem_pt"].ToString();
             }
             else
             {
                 txtDiscount.Text = "0";
                 txtDiscountPercent.Text = "0";
                 txtCash.Text = "0";
                 txtCard.Text = "0";
                 txtCustomerID.Text = "0";
                 loyaltyno.Text = "0";
                 point.Text = "0";
             }         
            //txtCash.Text = "0";

            clsUtility.ExecuteSQLQuery("SELECT  *  FROM  Sales    WHERE (SALES_ID = '" + txtInvoiceNo.Text + "')");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                clsUtility.ExecuteSQLQuery("SELECT  SUM(TotalPrice) AS Expr1 , SUM(TotalVat) AS Expr2 FROM  Sales  WHERE (SALES_ID = '" + txtInvoiceNo.Text + "')");
                txtNetAmount.Text = clsUtility.sqlDT.Rows[0]["Expr1"].ToString();
                txtVAT.Text = clsUtility.sqlDT.Rows[0]["Expr2"].ToString();
            }
            else { txtNetAmount.Text = "0"; txtVAT.Text = "0"; }

            LoadCalculaion();
        }

        private void LoadCalculaion()
        {    
            int dvd =Convert.ToInt32(label6.Text);
            double points = 0;
            double resvalue = 0;
            try
            {  
                
                txtGrandTotal.Text = (Math.Round(double.Parse(txtNetAmount.Text) + (double.Parse(txtVAT.Text) - double.Parse(txtDiscount.Text)), 2)).ToString();
                // txtDiscountPercent.Text = (Math.Round(double.Parse(txtDiscount.Text) * 100 / double.Parse(txtNetAmount.Text) + (double.Parse(txtVAT.Text) ), 2)).ToString();

               
                if (!string.IsNullOrEmpty(point.Text) || point.Text == "0")
                {
                    points = double.Parse(point.Text);
                  
                    if (dvd == 0)
                    {
                        dvd = 1;
                    }
                }
                resvalue = points / dvd;
                txtDue.Text = (Math.Round(double.Parse(txtGrandTotal.Text) - (double.Parse(txtCash.Text) + resvalue + double.Parse(txtCard.Text)), 2)).ToString();
                CustomerDisplay();
            }
            catch (Exception) { }
        }
        private void InsertSalesItem(string ITEM_ID, double QTY)
        {
            
            clsUtility.ExecuteSQLQuery(" SELECT  Discount_amount FROM  Dis_percentage WHERE item_id='" + ITEM_ID + "' AND End_Date >= GETDATE() AND start_date <= GETDATE() ");

            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                string discountamount;
               
                discountamount = clsUtility.sqlDT.Rows[0]["Discount_amount"].ToString();
                if (discountamount != null)
                {
                    double VAT;
                    clsUtility.ExecuteSQLQuery("SELECT * FROM Vat");
                    if (clsUtility.sqlDT.Rows.Count > 0) { VAT = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["Vat"]); } else { VAT = 0; }

                    clsUtility.ExecuteSQLQuery(" SELECT * FROM  ItemInformation  WHERE ITEM_ID ='" + ITEM_ID + "' ");
                    if (clsUtility.sqlDT.Rows.Count > 0)
                    {
                        string WarehouseID, ExpiryDate, VAT_Applicable;
                        WarehouseID = clsUtility.sqlDT.Rows[0]["WarehouseID"].ToString();
                        VAT_Applicable = clsUtility.sqlDT.Rows[0]["VAT_Applicable"].ToString();
                        double Cost = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["Cost"]);
                        double Price = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["Price"]);
                        double UnitVatAmount;
                        if (VAT_Applicable == "Y")
                        {
                            UnitVatAmount = Price * VAT / 100;
                        }
                        else { UnitVatAmount = 0; }
                        Price = Price - double.Parse(discountamount);
                        //Check Warehouse 
                        clsUtility.ExecuteSQLQuery(" SELECT * FROM  Stock  WHERE ITEM_ID ='" + ITEM_ID + "' AND  (Quantity >= '" + QTY + "') ");
                        if (clsUtility.sqlDT.Rows.Count > 0)
                        {
                            
                            ExpiryDate = clsUtility.sqlDT.Rows[0]["ExpiryDate"].ToString();
                            clsUtility.ExecuteSQLQuery(" SELECT * FROM Sales  WHERE ITEM_ID = '" + ITEM_ID + "' AND SALES_ID = '" + txtInvoiceNo.Text + "' ");
                            if (clsUtility.sqlDT.Rows.Count > 0)
                            {
                                clsUtility.ExecuteSQLQuery(" UPDATE  Sales SET QTY = QTY + '" + QTY + "' ,TotalPrice= TotalPrice +'" + QTY * Price + "' ,TotalCost= TotalCost +'" + QTY * Cost + "', TotalVat= TotalVat + '" + QTY * UnitVatAmount + "' " +
                                                           " WHERE ITEM_ID = '" + ITEM_ID + "' AND SALES_ID = '" + txtInvoiceNo.Text + "' ");

                            }
                            else
                            {
                               

                                clsUtility.ExecuteSQLQuery(" INSERT INTO Sales(SALES_ID,Sales_Date,ITEM_ID,QTY,Price,TotalPrice,Cost,TotalCost,Vat,TotalVat,ExprDate, Terminal) VALUES " +
                                                           " ( '" + txtInvoiceNo.Text + "' ,'" + dtpSalesDate.Value.Date.ToString("yyyy-MM-dd") + "' , '" + ITEM_ID + "', '" + QTY + "', '" + Price + "','" + QTY * Price + "','" + Cost + "','" + QTY * Cost + "','" + UnitVatAmount + "','" + QTY * UnitVatAmount + "', '" + ExpiryDate + "', 'POS') ");
                            }
                          clsUtility.ExecuteSQLQuery(" UPDATE   Stock SET Quantity = Quantity - '" + QTY + "' WHERE ITEM_ID ='" + ITEM_ID + "' AND WarehouseID='" + WarehouseID + "'  ");
                        }
                        else {
                        
                    }
                        //End Warehouse
                    }
                }
                
            }
            else
            {
  
                double VAT;
                clsUtility.ExecuteSQLQuery("SELECT * FROM Vat");
                if (clsUtility.sqlDT.Rows.Count > 0) { VAT = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["Vat"]); } else { VAT = 0; }
                clsUtility.ExecuteSQLQuery(" SELECT * FROM  ItemInformation  WHERE ITEM_ID ='" + ITEM_ID + "' ");
                if (clsUtility.sqlDT.Rows.Count > 0)
                {
                    string WarehouseID, ExpiryDate, VAT_Applicable;
                    WarehouseID = clsUtility.sqlDT.Rows[0]["WarehouseID"].ToString();
                    VAT_Applicable = clsUtility.sqlDT.Rows[0]["VAT_Applicable"].ToString();
                    double Cost = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["Cost"]);
                    double Price = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["Price"]);
                    double UnitVatAmount;
                    if (VAT_Applicable == "Y")
                    {
                        UnitVatAmount = Price * VAT / 100;
                    }
                    else { UnitVatAmount = 0; }
                    Price = Price - 0;
                    //Check Warehouse 
                    clsUtility.ExecuteSQLQuery(" SELECT * FROM  Stock  WHERE ITEM_ID ='" + ITEM_ID + "' AND WarehouseID='" + WarehouseID + "' AND  (Quantity >= '" + QTY + "') ");
                    if (clsUtility.sqlDT.Rows.Count > 0)
                    {
                        ExpiryDate = clsUtility.sqlDT.Rows[0]["ExpiryDate"].ToString();
                        clsUtility.ExecuteSQLQuery(" SELECT * FROM Sales  WHERE ITEM_ID = '" + ITEM_ID + "' AND SALES_ID = '" + txtInvoiceNo.Text + "' ");


                        if (clsUtility.sqlDT.Rows.Count > 0)
                        {
                            clsUtility.ExecuteSQLQuery(" UPDATE  Sales SET QTY = QTY + '" + QTY + "' ,TotalPrice= TotalPrice +'" + QTY * Price + "' ,TotalCost= TotalCost +'" + QTY * Cost + "', TotalVat= TotalVat + '" + QTY * UnitVatAmount + "' " +
                                                       " WHERE ITEM_ID = '" + ITEM_ID + "' AND SALES_ID = '" + txtInvoiceNo.Text + "' ");

                        }
                        else
                        {
                            clsUtility.ExecuteSQLQuery(" SELECT  Quantity,Self FROM  Dis_product WHERE item_id='" + ITEM_ID + "' ");
                            if (clsUtility.sqlDT.Rows.Count > 0)
                            {
                                string  product_id, Dis_qnty;
                                product_id = clsUtility.sqlDT.Rows[0]["Self"].ToString();
                                Dis_qnty = clsUtility.sqlDT.Rows[0]["Quantity"].ToString();
                                Convert.ToInt32(Dis_qnty);
                                if (product_id != null)
                                {

                                    clsUtility.ExecuteSQLQuery(" INSERT INTO Sales(SALES_ID,Sales_Date,ITEM_ID,QTY,Price,TotalPrice,Cost,TotalCost,Vat,TotalVat,ExprDate, Terminal) VALUES " +
                                                         " ( '" + txtInvoiceNo.Text + "' ,'" + dtpSalesDate.Value.Date.ToString("yyyy-MM-dd") + "' , '" + ITEM_ID + "', '" + QTY + "', '" + Price + "','" + QTY * Price + "','" + Cost + "','" + QTY * Cost + "','" + UnitVatAmount + "','" + QTY * UnitVatAmount + "', '" + ExpiryDate + "', 'POS') ");

                                    clsUtility.ExecuteSQLQuery(" INSERT INTO Sales(SALES_ID,Sales_Date,ITEM_ID,QTY,Price,TotalPrice,Cost,TotalCost,Vat,TotalVat,ExprDate, Terminal) VALUES " +
                                           " ( '" + txtInvoiceNo.Text + "' ,'" + dtpSalesDate.Value.Date.ToString("yyyy-MM-dd") + "' , '" + product_id + "', '" + Dis_qnty + "', '" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "', '" + ExpiryDate + "', 'POS') ");

                              
                                    clsUtility.ExecuteSQLQuery(" UPDATE   Stock SET Quantity = Quantity - '" + Dis_qnty + "' WHERE ITEM_ID ='" + product_id + "'  ");

                                }
                                else
                                {

                                    clsUtility.ExecuteSQLQuery(" INSERT INTO Sales(SALES_ID,Sales_Date,ITEM_ID,QTY,Price,TotalPrice,Cost,TotalCost,Vat,TotalVat,ExprDate, Terminal) VALUES " +
                                                             " ( '" + txtInvoiceNo.Text + "' ,'" + dtpSalesDate.Value.Date.ToString("yyyy-MM-dd") + "' , '" + ITEM_ID + "', '" + QTY + "', '" + Price + "','" + QTY * Price + "','" + Cost + "','" + QTY * Cost + "','" + UnitVatAmount + "','" + QTY * UnitVatAmount + "', '" + ExpiryDate + "', 'POS') ");

                                }
                            }
                            
                            clsUtility.ExecuteSQLQuery(" UPDATE   Stock SET Quantity = Quantity - '" + QTY + "' WHERE ITEM_ID ='" + ITEM_ID + "' AND WarehouseID='" + WarehouseID + "'  ");
                        }
                    }
                    else { }

                    //End Warehouse
                }
            }
        }

        private void CustomerDisplay() {
            if (Properties.Settings.Default.App_ItemDisplay) {
                serialPort1.PortName = Properties.Settings.Default.Port_Name;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                serialPort1.WriteLine(txtGrandTotal.Text);
                serialPort1.Close();
                serialPort1.Dispose();
            }
        }


        private void DeleteSalesItem(string DATA_ROW_ID, double QTY)
        {

            clsUtility.ExecuteSQLQuery(" SELECT * FROM Sales  WHERE ID = '" + DATA_ROW_ID + "' ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                double ITEM_ID = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["ITEM_ID"]);
                double Cost = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["Cost"]);
                double Price = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["Price"]);
                double Vat = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["Vat"]);

                clsUtility.ExecuteSQLQuery(" SELECT *  FROM   ItemInformation  WHERE  ITEM_ID = '" + ITEM_ID + "' ");
                double WarehouseID = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["WarehouseID"]);

                clsUtility.ExecuteSQLQuery(" SELECT *  FROM  Sales  WHERE ID = '" + DATA_ROW_ID + "' AND ITEM_ID = '" + ITEM_ID + "' AND QTY = '" + QTY + "' ");
                if (clsUtility.sqlDT.Rows.Count > 0)
                {
                    clsUtility.ExecuteSQLQuery(" DELETE FROM Sales WHERE ID =  '" + DATA_ROW_ID + "' ");
                    clsUtility.ExecuteSQLQuery(" UPDATE   Stock SET Quantity = Quantity + '" + QTY + "' WHERE ITEM_ID ='" + ITEM_ID + "' AND WarehouseID='" + WarehouseID + "'  ");
                }
                else
                {
                    clsUtility.ExecuteSQLQuery(" UPDATE  Sales SET QTY = QTY - '" + QTY + "' ,TotalPrice= TotalPrice -'" + QTY * Price + "' ,TotalCost= TotalCost -'" + QTY * Cost + "', TotalVat= TotalVat - '" + QTY * Vat + "' " +
                                               " WHERE ID = '" + DATA_ROW_ID + "' ");

                    clsUtility.ExecuteSQLQuery(" UPDATE   Stock SET Quantity = Quantity + '" + QTY + "' WHERE ITEM_ID ='" + ITEM_ID + "' AND WarehouseID='" + WarehouseID + "'  ");
                }
            }
        }


        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }



        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsUtility.ExecuteSQLQuery(" SELECT  * FROM   Users  WHERE   USER_ID = '" + clsUtility.UserID + "' AND   Can_Add = 'Y' ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                ///////////////////////////////////////////
                if (e.KeyChar == Convert.ToChar(Keys.Return))
                {
                    if (string.IsNullOrWhiteSpace(txtBarcode.Text)) { errorProvider.SetError(txtBarcode, "Required"); }
                    else
                    {
                        errorProvider.Clear();
                        double ITEM_ID;
                        clsUtility.ExecuteSQLQuery("SELECT * FROM ItemInformation WHERE  (Barcode LIKE '%" + txtBarcode.Text + "%')   ");
                        if (clsUtility.sqlDT.Rows.Count > 0)
                        {
                            errorProvider.Clear();
                            ITEM_ID = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["ITEM_ID"]);
                            InsertSalesItem(ITEM_ID.ToString(), 1);
                            LoadSalesItem();
                            txtBarcode.Text = "";
                            txtBarcode.Focus();
                        }
                        else
                        {
                            clsUtility.MesgBoxShow("msgNotFound", "info");
                        }
                    }
                }
                ///////////////////////////////////////////
            }
            else
            {
                clsUtility.MesgBoxShow("msgPermission", "err");
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            clsUtility.ExecuteSQLQuery(" SELECT  * FROM   Users  WHERE   USER_ID = '" + clsUtility.UserID + "' AND   Can_Print = 'Y' ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                ///////////////////////////////////////////
                btnSave.PerformClick();
                frmInvoicePrint frmInvoicePrint = new frmInvoicePrint(txtInvoiceNo.Text, "POS");
                frmInvoicePrint.ShowDialog();
                ///////////////////////////////////////////
            }
            else
            {
                clsUtility.MesgBoxShow("msgPermission", "err");
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            int dvd;
            double points = 0;
            if (!string.IsNullOrEmpty(point.Text))
            {
                points = double.Parse(point.Text);
            }


            double resvalue =0;
            clsUtility.ExecuteSQLQuery("SELECT * FROM loyaltypoints");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                dvd = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["pointvalue"]);

                int amount1 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout1"]);
                int amount2 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout2"]);
                int amount3 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout3"]);
                int amount4 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout4"]);
                int amount5 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout5"]);
                int amount6 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout6"]);
                int amount7 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout7"]);
                int amount8 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout8"]);
                int amount9 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout9"]);
                int amount10 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["amout10"]);
                int point1 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points1"]);
                int point2 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points2"]);
                int point3 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points3"]);
                int point4 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points4"]);
                int point5 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points5"]);
                int point6 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points6"]);
                int point7 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points7"]);
                int point8 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points8"]);
                int point9 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points9"]);
                int point10 = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points10"]);

                
                
                clsUtility.ExecuteSQLQuery(" SELECT * FROM Sales WHERE SALES_ID='" + txtInvoiceNo.Text + "' ");
                if (clsUtility.sqlDT.Rows.Count > 0)
                {
                    double total = double.Parse(txtCash.Text) + double.Parse(txtCard.Text);

                    if (!string.IsNullOrEmpty(txtCustomerID.Text) && !string.IsNullOrEmpty(loyaltyno.Text))
                    {
                        resvalue = points / dvd;

                        if (double.Parse(txtCash.Text) + resvalue + double.Parse(txtCard.Text) < double.Parse(txtGrandTotal.Text))
                        {

                            MessageBox.Show("Please confirm the payment.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult msg = new DialogResult();
                            msg = MessageBox.Show("Confirm?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (msg == DialogResult.Yes)
                            {
                                if (!string.IsNullOrEmpty(point.Text))
                                {
                                    clsUtility.ExecuteSQLQuery("  UPDATE loyalty SET points = points - '" + Convert.ToInt32(point.Text) + "' WHERE cust_id ='" + txtCustomerID.Text + "'");
                                    clsUtility.ExecuteSQLQuery("  UPDATE salesinfo SET redeem_pt = '" + resvalue + "'    WHERE (SALES_ID = '" + txtInvoiceNo.Text + "')");
                                }

                                if (amount1 != 0)
                                {
                                    if (total >= amount1)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point1 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }
                                }
                                if (amount2 != 0)
                                {
                                    if (total >= amount2)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point2 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }
                                }
                                if (amount3 != 0)
                                {

                                    if (total >= amount3)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point3 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }
                                }
                                if (amount4 != 0)
                                {
                                    if (total >= amount3)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point4 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }
                                }
                                if (amount5 != 0)
                                {
                                    if (total >= amount3)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point5 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }
                                }
                                if (amount6 != 0)
                                {
                                    if (total >= amount3)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point6 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }

                                }
                                if (amount7 != 0)
                                {
                                    if (total >= amount3)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point7 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }
                                }
                                if (amount8 != 0)
                                {
                                    if (total >= amount3)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point8 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }
                                }
                                if (amount9 != 0)
                                {
                                    if (total >= amount3)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point9 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }
                                }
                                if (amount10 != 0)
                                {
                                    if (total >= amount3)
                                    {
                                        clsUtility.ExecuteSQLQuery(" UPDATE loyalty SET points = points + '" + point10 + "' WHERE cust_id ='" + txtCustomerID.Text + "' ");
                                    }
                                }


                                btnSave.PerformClick();
                                btnReceipt.PerformClick();
                                CreateNewInvoice();
                                txtDue.Text = null;
                                loyaltyno.Text = null;
                                ptval.Text = null;
                                LoadSalesItem();
                                txtBarcode.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Empty.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }

                        }

                    }
                 
                    else
                    {
                      
                        if (double.Parse(txtCash.Text) + double.Parse(txtCard.Text) < double.Parse(txtGrandTotal.Text))
                        
                        {
                            MessageBox.Show("Please confirm the payment.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult msg = new DialogResult();
                            msg = MessageBox.Show("Confirm?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (msg == DialogResult.Yes)
                            {
                                btnSave.PerformClick();
                                btnReceipt.PerformClick();
                                CreateNewInvoice();
                                txtDue.Text = null;
                                loyaltyno.Text = null;
                                ptval.Text = null;
                                LoadSalesItem();
                               
                                txtBarcode.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Empty.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }

                        }
                    }
                   
                }
            }

           
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCash.Text)) { txtCash.Text = "0"; }
            else { LoadCalculaion(); }
        }

        private void txtCard_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCard.Text)) { txtCard.Text = "0"; }
            else { LoadCalculaion(); }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtDiscount.Text)) { txtDiscount.Text = "0"; }
            else {
                
               LoadCalculaion(); 
            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                clsUtility.ExecuteSQLQuery("SELECT * FROM Sales WHERE ID =  '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' ");
                double ITEM_ID = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["ITEM_ID"]);
                InsertSalesItem(ITEM_ID.ToString(), 1);
                LoadSalesItem();
            }
            else if (e.ColumnIndex == 1)
            {
                DeleteSalesItem(dataGridView1.CurrentRow.Cells[3].Value.ToString(), 1);
                LoadSalesItem();
            }
            else if (e.ColumnIndex == 2)
            {
                DialogResult msg = new DialogResult();
                msg = MessageBox.Show("Do you really want to delete item?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    clsUtility.ExecuteSQLQuery("SELECT * FROM Sales WHERE ID =  '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' ");
                    double ITEM_ID = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["ITEM_ID"]);
                    clsUtility.ExecuteSQLQuery(" SELECT *  FROM   ItemInformation  WHERE  ITEM_ID = '" + ITEM_ID + "' ");
                    double WarehouseID = Convert.ToDouble(clsUtility.sqlDT.Rows[0]["WarehouseID"]);
                    clsUtility.ExecuteSQLQuery(" UPDATE Stock SET  Quantity = Quantity + '" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "'  WHERE ITEM_ID = '" + ITEM_ID + "' AND WarehouseID = '" + WarehouseID + "' ");
                    clsUtility.ExecuteSQLQuery(" DELETE FROM Sales WHERE ID =  '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' ");
                    LoadSalesItem();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clsUtility.ExecuteSQLQuery(" SELECT  * FROM   Users  WHERE   USER_ID = '" + clsUtility.UserID + "' AND   Can_Add = 'Y' ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                ///////////////////////////////////////////
                DialogResult msg = new DialogResult();
                msg = MessageBox.Show("Confirm?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                    CreateNewInvoice();
                    LoadSalesItem();
                }
                ///////////////////////////////////////////
            }
            else
            {
                clsUtility.MesgBoxShow("msgPermission", "err");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsUtility.ExecuteSQLQuery(" SELECT  * FROM   Users  WHERE   USER_ID = '" + clsUtility.UserID + "' AND   Can_Edit = 'Y' ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                ///////////////////////////////////////////
                int dvd;
                double points = 0;
                if (!string.IsNullOrEmpty(point.Text))
                {
                    points = double.Parse(point.Text);
                }


                double resvalue;
                clsUtility.ExecuteSQLQuery("SELECT * FROM loyaltypoints");
                if (clsUtility.sqlDT.Rows.Count > 0)
                {
                    dvd = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["pointvalue"]);
                    resvalue = points / dvd;
                    clsUtility.ExecuteSQLQuery(" UPDATE  SalesInfo  SET ItemPrice='" + clsUtility.num_repl(txtNetAmount.Text) + "', Discount='" + clsUtility.num_repl(txtDiscount.Text) + "' " +
                                           " , GrandTotal= '" + clsUtility.num_repl(txtGrandTotal.Text) + "', VAT= '" + clsUtility.num_repl(txtVAT.Text) + "', CashPay= '" + clsUtility.num_repl(txtCash.Text) + "', CardPay= '" + clsUtility.num_repl(txtCard.Text) + "' , Due ='" + clsUtility.num_repl(txtDue.Text) + "' , CUST_ID ='" + clsUtility.num_repl(txtCustomerID.Text) + "', redeem_pt ='" + resvalue + "'   WHERE (SALES_ID = '" + clsUtility.num_repl(txtInvoiceNo.Text) + "') ");
                ///////////////////////////////////////////
                }
            }
            else
            {
                clsUtility.MesgBoxShow("msgPermission", "err");
            }
        }

        private void chkCustomerDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomerDisplay.Checked)
            {
                Properties.Settings.Default.App_CustomerDisplay = true;
                Properties.Settings.Default.Save();
            }
            else {
                Properties.Settings.Default.App_CustomerDisplay = false;
                Properties.Settings.Default.Save();
            }
        }

        private void chkItemDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItemDisplay.Checked) {
                Properties.Settings.Default.App_ItemDisplay = true;
                Properties.Settings.Default.Save();
            }
            else {
                Properties.Settings.Default.App_ItemDisplay = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmCustomerDisplay frmCustomerDisplay = new frmCustomerDisplay();
            frmCustomerDisplay.ShowDialog ();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            { btnClose.PerformClick(); }
            else if (keyData == (Keys.Control | Keys.P))
            { btnReceipt.PerformClick(); }
            else if (keyData == (Keys.F5))
            { btnComplete.PerformClick(); }
            else if (keyData == (Keys.F6))
            { btnSave.PerformClick(); }
            else if (keyData == (Keys.F7))
            { btnNew.PerformClick(); }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbItemName.SelectedValue == null | cmbItemName.SelectedIndex == -1)
            { errorProvider.SetError(cmbItemName, "Required");  }
            else
            {
                errorProvider.Clear();
                InsertSalesItem(cmbItemName.SelectedValue.ToString(), 1);
                LoadSalesItem();
                txtBarcode.Text = "";
                txtBarcode.Focus();
            }
        }                                                                              

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            //Customer Information
            frmCustomerInfo frmCustomerInfo = Application.OpenForms["frmCustomerInfo"] as frmCustomerInfo;
            if (frmCustomerInfo != null)
            {
                frmCustomerInfo.WindowState = FormWindowState.Normal;
                frmCustomerInfo.BringToFront();
                frmCustomerInfo.Activate();
            }
            else
            {
                frmCustomerInfo = new frmCustomerInfo();
                frmCustomerInfo.MdiParent = this.ParentForm;
                frmCustomerInfo.Dock = DockStyle.Fill;
                frmCustomerInfo.Show();
            }
        }

        private void txtDiscountPercent_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtDiscountPercent.Text)) { txtDiscountPercent.Text = "0"; }
            else {
                try
                {
                    txtDiscount.Text = (Math.Round(((double.Parse(txtNetAmount.Text) + double.Parse(txtVAT.Text)) * double.Parse(txtDiscountPercent.Text)) / 100, 2)).ToString();
                }
                catch (Exception )
                {  }
   
            }
        }

        private void txtDiscountPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            string points, loyalty;
            clsUtility.ExecuteSQLQuery(" SELECT  * FROM  loyalty WHERE cust_id='" + txtCustomerID.Text + "' ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                points = clsUtility.sqlDT.Rows[0]["points"].ToString();
                loyalty = clsUtility.sqlDT.Rows[0]["loyalty_no"].ToString();
                ptval.Text = points;
                loyaltyno.Text = loyalty;

            }
        }

        private void loyaltyno_TextChanged(object sender, EventArgs e)
        {
            string points, cust_id;
            clsUtility.ExecuteSQLQuery(" SELECT  * FROM  loyalty WHERE loyalty_no='" + loyaltyno.Text + "' ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                points = clsUtility.sqlDT.Rows[0]["points"].ToString();
                cust_id = clsUtility.sqlDT.Rows[0]["cust_id"].ToString();
                ptval.Text = points;
                txtCustomerID.Text = cust_id;
            }
        }

        private void point_TextChanged(object sender, EventArgs e)
        {
            int points;
            if (point.Text != "")
            {

                clsUtility.ExecuteSQLQuery(" SELECT  * FROM  loyalty WHERE loyalty_no='" + loyaltyno.Text + "' ");
                if (clsUtility.sqlDT.Rows.Count > 0)
                {
                    points = Convert.ToInt32(clsUtility.sqlDT.Rows[0]["points"]);
                    if (Convert.ToInt32(point.Text) > points)
                    {
                        MessageBox.Show("you have enough points.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        point.Text = "0";
                    }
                }
                if (string.IsNullOrWhiteSpace(this.point.Text)) { point.Text = "0"; }
                else { LoadCalculaion(); }
            }
        }

    }
}
