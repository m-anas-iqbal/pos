
namespace Kodev.Forms.Dashboard
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.priceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbOrionDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbOrionDataSet1 = new Kodev.dbOrionDataSet1();
            this.priceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbOrionDataSet = new Kodev.dbOrionDataSet();
            this.Purchase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dayPurchaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dayPurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.daysalesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.daysalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Credit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dayCreditBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dayCreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quantity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.quantityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quantityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Return = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dayReturnBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dayReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new Kodev.dbOrionDataSetTableAdapters.salesTableAdapter();
            this.day_PurchaseTableAdapter = new Kodev.dbOrionDataSetTableAdapters.Day_PurchaseTableAdapter();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.day_ReturnTableAdapter = new Kodev.dbOrionDataSetTableAdapters.Day_ReturnTableAdapter();
            this.day_salesTableAdapter = new Kodev.dbOrionDataSetTableAdapters.day_salesTableAdapter();
            this.day_CreditTableAdapter = new Kodev.dbOrionDataSetTableAdapters.Day_CreditTableAdapter();
            this.priceTableAdapter = new Kodev.dbOrionDataSetTableAdapters.priceTableAdapter();
            this.quantityTableAdapter = new Kodev.dbOrionDataSetTableAdapters.QuantityTableAdapter();
            this.day_salesTableAdapter1 = new Kodev.dbOrionDataSet1TableAdapters.day_salesTableAdapter();
            this.day_PurchaseTableAdapter1 = new Kodev.dbOrionDataSet1TableAdapters.Day_PurchaseTableAdapter();
            this.day_CreditTableAdapter1 = new Kodev.dbOrionDataSet1TableAdapters.Day_CreditTableAdapter();
            this.priceTableAdapter1 = new Kodev.dbOrionDataSet1TableAdapters.priceTableAdapter();
            this.quantityTableAdapter1 = new Kodev.dbOrionDataSet1TableAdapters.QuantityTableAdapter();
            this.day_ReturnTableAdapter1 = new Kodev.dbOrionDataSet1TableAdapters.Day_ReturnTableAdapter();
            this.dsOrion = new Kodev.dsOrion();
            this.daysalesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.day_salesTableAdapter2 = new Kodev.dsOrionTableAdapters.day_salesTableAdapter();
            this.dayCreditBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.day_CreditTableAdapter2 = new Kodev.dsOrionTableAdapters.Day_CreditTableAdapter();
            this.priceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.priceTableAdapter2 = new Kodev.dsOrionTableAdapters.priceTableAdapter();
            this.dsOrionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayPurchaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.day_PurchaseTableAdapter2 = new Kodev.dsOrionTableAdapters.Day_PurchaseTableAdapter();
            this.dayReturnBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.day_ReturnTableAdapter2 = new Kodev.dsOrionTableAdapters.Day_ReturnTableAdapter();
            this.quantityBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quantityTableAdapter2 = new Kodev.dsOrionTableAdapters.QuantityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrionDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Purchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPurchaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysalesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Credit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCreditBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayReturnBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysalesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCreditBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPurchaseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayReturnBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Price
            // 
            chartArea1.Name = "ChartArea1";
            this.Price.ChartAreas.Add(chartArea1);
            this.Price.DataSource = this.priceBindingSource2;
            legend1.Name = "Legend1";
            this.Price.Legends.Add(legend1);
            resources.ApplyResources(this.Price, "Price");
            this.Price.Name = "Price";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Price";
            this.Price.Series.Add(series1);
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Price";
            this.Price.Titles.Add(title1);
            // 
            // priceBindingSource1
            // 
            this.priceBindingSource1.DataMember = "price";
            this.priceBindingSource1.DataSource = this.dbOrionDataSet1BindingSource;
            // 
            // dbOrionDataSet1BindingSource
            // 
            this.dbOrionDataSet1BindingSource.DataSource = this.dbOrionDataSet1;
            this.dbOrionDataSet1BindingSource.Position = 0;
            // 
            // dbOrionDataSet1
            // 
            this.dbOrionDataSet1.DataSetName = "dbOrionDataSet1";
            this.dbOrionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceBindingSource
            // 
            this.priceBindingSource.DataMember = "price";
            this.priceBindingSource.DataSource = this.dbOrionDataSet;
            // 
            // dbOrionDataSet
            // 
            this.dbOrionDataSet.DataSetName = "dbOrionDataSet";
            this.dbOrionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Purchase
            // 
            chartArea2.Name = "ChartArea1";
            this.Purchase.ChartAreas.Add(chartArea2);
            this.Purchase.Cursor = System.Windows.Forms.Cursors.Default;
            this.Purchase.DataSource = this.dayPurchaseBindingSource2;
            legend2.Name = "Legend1";
            this.Purchase.Legends.Add(legend2);
            resources.ApplyResources(this.Purchase, "Purchase");
            this.Purchase.Name = "Purchase";
            this.Purchase.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Purchase";
            this.Purchase.Series.Add(series2);
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Purchase";
            this.Purchase.Titles.Add(title2);
            // 
            // dayPurchaseBindingSource1
            // 
            this.dayPurchaseBindingSource1.DataMember = "Day_Purchase";
            this.dayPurchaseBindingSource1.DataSource = this.dbOrionDataSet1BindingSource;
            // 
            // dayPurchaseBindingSource
            // 
            this.dayPurchaseBindingSource.DataMember = "Day_Purchase";
            this.dayPurchaseBindingSource.DataSource = this.dbOrionDataSet;
            // 
            // Sales
            // 
            chartArea3.Name = "ChartArea1";
            this.Sales.ChartAreas.Add(chartArea3);
            this.Sales.DataSource = this.daysalesBindingSource2;
            legend3.Name = "Legend1";
            this.Sales.Legends.Add(legend3);
            resources.ApplyResources(this.Sales, "Sales");
            this.Sales.Name = "Sales";
            this.Sales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Sales";
            this.Sales.Series.Add(series3);
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Sales";
            this.Sales.Titles.Add(title3);
            // 
            // daysalesBindingSource1
            // 
            this.daysalesBindingSource1.DataMember = "day_sales";
            this.daysalesBindingSource1.DataSource = this.dbOrionDataSet1BindingSource;
            // 
            // daysalesBindingSource
            // 
            this.daysalesBindingSource.DataMember = "day_sales";
            this.daysalesBindingSource.DataSource = this.dbOrionDataSet;
            // 
            // Credit
            // 
            chartArea4.Name = "ChartArea1";
            this.Credit.ChartAreas.Add(chartArea4);
            this.Credit.DataSource = this.dayCreditBindingSource2;
            legend4.Name = "Legend1";
            this.Credit.Legends.Add(legend4);
            resources.ApplyResources(this.Credit, "Credit");
            this.Credit.Name = "Credit";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Credit";
            this.Credit.Series.Add(series4);
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Credit";
            this.Credit.Titles.Add(title4);
            // 
            // dayCreditBindingSource1
            // 
            this.dayCreditBindingSource1.DataMember = "Day_Credit";
            this.dayCreditBindingSource1.DataSource = this.dbOrionDataSet1BindingSource;
            // 
            // dayCreditBindingSource
            // 
            this.dayCreditBindingSource.DataMember = "Day_Credit";
            this.dayCreditBindingSource.DataSource = this.dbOrionDataSet;
            // 
            // Quantity
            // 
            chartArea5.Name = "ChartArea1";
            this.Quantity.ChartAreas.Add(chartArea5);
            this.Quantity.DataSource = this.quantityBindingSource2;
            legend5.Name = "Legend1";
            this.Quantity.Legends.Add(legend5);
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.Name = "Quantity";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Quantity";
            series5.Points.Add(dataPoint1);
            this.Quantity.Series.Add(series5);
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Quantity";
            this.Quantity.Titles.Add(title5);
            // 
            // quantityBindingSource1
            // 
            this.quantityBindingSource1.DataMember = "Quantity";
            this.quantityBindingSource1.DataSource = this.dbOrionDataSet1BindingSource;
            // 
            // quantityBindingSource
            // 
            this.quantityBindingSource.DataMember = "Quantity";
            this.quantityBindingSource.DataSource = this.dbOrionDataSet;
            // 
            // Return
            // 
            chartArea6.Name = "ChartArea1";
            this.Return.ChartAreas.Add(chartArea6);
            this.Return.Cursor = System.Windows.Forms.Cursors.Default;
            this.Return.DataSource = this.dayReturnBindingSource2;
            legend6.Name = "Legend1";
            this.Return.Legends.Add(legend6);
            resources.ApplyResources(this.Return, "Return");
            this.Return.Name = "Return";
            this.Return.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Return";
            this.Return.Series.Add(series6);
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Return";
            this.Return.Titles.Add(title6);
            // 
            // dayReturnBindingSource1
            // 
            this.dayReturnBindingSource1.DataMember = "Day_Return";
            this.dayReturnBindingSource1.DataSource = this.dbOrionDataSet1BindingSource;
            // 
            // dayReturnBindingSource
            // 
            this.dayReturnBindingSource.DataMember = "Day_Return";
            this.dayReturnBindingSource.DataSource = this.dbOrionDataSet;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.dbOrionDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // day_PurchaseTableAdapter
            // 
            this.day_PurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "sales";
            this.salesBindingSource1.DataSource = this.dbOrionDataSet;
            // 
            // day_ReturnTableAdapter
            // 
            this.day_ReturnTableAdapter.ClearBeforeFill = true;
            // 
            // day_salesTableAdapter
            // 
            this.day_salesTableAdapter.ClearBeforeFill = true;
            // 
            // day_CreditTableAdapter
            // 
            this.day_CreditTableAdapter.ClearBeforeFill = true;
            // 
            // priceTableAdapter
            // 
            this.priceTableAdapter.ClearBeforeFill = true;
            // 
            // quantityTableAdapter
            // 
            this.quantityTableAdapter.ClearBeforeFill = true;
            // 
            // day_salesTableAdapter1
            // 
            this.day_salesTableAdapter1.ClearBeforeFill = true;
            // 
            // day_PurchaseTableAdapter1
            // 
            this.day_PurchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // day_CreditTableAdapter1
            // 
            this.day_CreditTableAdapter1.ClearBeforeFill = true;
            // 
            // priceTableAdapter1
            // 
            this.priceTableAdapter1.ClearBeforeFill = true;
            // 
            // quantityTableAdapter1
            // 
            this.quantityTableAdapter1.ClearBeforeFill = true;
            // 
            // day_ReturnTableAdapter1
            // 
            this.day_ReturnTableAdapter1.ClearBeforeFill = true;
            // 
            // dsOrion
            // 
            this.dsOrion.DataSetName = "dsOrion";
            this.dsOrion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daysalesBindingSource2
            // 
            this.daysalesBindingSource2.DataMember = "day_sales";
            this.daysalesBindingSource2.DataSource = this.dsOrion;
            // 
            // day_salesTableAdapter2
            // 
            this.day_salesTableAdapter2.ClearBeforeFill = true;
            // 
            // dayCreditBindingSource2
            // 
            this.dayCreditBindingSource2.DataMember = "Day_Credit";
            this.dayCreditBindingSource2.DataSource = this.dsOrion;
            // 
            // day_CreditTableAdapter2
            // 
            this.day_CreditTableAdapter2.ClearBeforeFill = true;
            // 
            // priceBindingSource2
            // 
            this.priceBindingSource2.DataMember = "price";
            this.priceBindingSource2.DataSource = this.dsOrion;
            // 
            // priceTableAdapter2
            // 
            this.priceTableAdapter2.ClearBeforeFill = true;
            // 
            // dsOrionBindingSource
            // 
            this.dsOrionBindingSource.DataSource = this.dsOrion;
            this.dsOrionBindingSource.Position = 0;
            // 
            // dayPurchaseBindingSource2
            // 
            this.dayPurchaseBindingSource2.DataMember = "Day_Purchase";
            this.dayPurchaseBindingSource2.DataSource = this.dsOrion;
            // 
            // day_PurchaseTableAdapter2
            // 
            this.day_PurchaseTableAdapter2.ClearBeforeFill = true;
            // 
            // dayReturnBindingSource2
            // 
            this.dayReturnBindingSource2.DataMember = "Day_Return";
            this.dayReturnBindingSource2.DataSource = this.dsOrion;
            // 
            // day_ReturnTableAdapter2
            // 
            this.day_ReturnTableAdapter2.ClearBeforeFill = true;
            // 
            // quantityBindingSource2
            // 
            this.quantityBindingSource2.DataMember = "Quantity";
            this.quantityBindingSource2.DataSource = this.dsOrion;
            // 
            // quantityTableAdapter2
            // 
            this.quantityTableAdapter2.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            //this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrionDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Purchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPurchaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysalesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Credit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCreditBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayReturnBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysalesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCreditBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPurchaseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayReturnBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Price;
        private System.Windows.Forms.DataVisualization.Charting.Chart Purchase;
        private System.Windows.Forms.DataVisualization.Charting.Chart Sales;
        private System.Windows.Forms.DataVisualization.Charting.Chart Credit;
        private System.Windows.Forms.DataVisualization.Charting.Chart Quantity;
        private System.Windows.Forms.DataVisualization.Charting.Chart Return;
        private dbOrionDataSet dbOrionDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private dbOrionDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource dayPurchaseBindingSource;
        private dbOrionDataSetTableAdapters.Day_PurchaseTableAdapter day_PurchaseTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private System.Windows.Forms.BindingSource dayReturnBindingSource;
        private dbOrionDataSetTableAdapters.Day_ReturnTableAdapter day_ReturnTableAdapter;
        private System.Windows.Forms.BindingSource daysalesBindingSource;
        private dbOrionDataSetTableAdapters.day_salesTableAdapter day_salesTableAdapter;
        private System.Windows.Forms.BindingSource dayCreditBindingSource;
        private dbOrionDataSetTableAdapters.Day_CreditTableAdapter day_CreditTableAdapter;
        private System.Windows.Forms.BindingSource priceBindingSource;
        private dbOrionDataSetTableAdapters.priceTableAdapter priceTableAdapter;
        private System.Windows.Forms.BindingSource quantityBindingSource;
        private dbOrionDataSetTableAdapters.QuantityTableAdapter quantityTableAdapter;
        private System.Windows.Forms.BindingSource dbOrionDataSet1BindingSource;
        private dbOrionDataSet1 dbOrionDataSet1;
        private System.Windows.Forms.BindingSource daysalesBindingSource1;
        private dbOrionDataSet1TableAdapters.day_salesTableAdapter day_salesTableAdapter1;
        private System.Windows.Forms.BindingSource dayPurchaseBindingSource1;
        private dbOrionDataSet1TableAdapters.Day_PurchaseTableAdapter day_PurchaseTableAdapter1;
        private System.Windows.Forms.BindingSource dayCreditBindingSource1;
        private dbOrionDataSet1TableAdapters.Day_CreditTableAdapter day_CreditTableAdapter1;
        private System.Windows.Forms.BindingSource priceBindingSource1;
        private dbOrionDataSet1TableAdapters.priceTableAdapter priceTableAdapter1;
        private System.Windows.Forms.BindingSource quantityBindingSource1;
        private dbOrionDataSet1TableAdapters.QuantityTableAdapter quantityTableAdapter1;
        private System.Windows.Forms.BindingSource dayReturnBindingSource1;
        private dbOrionDataSet1TableAdapters.Day_ReturnTableAdapter day_ReturnTableAdapter1;
        private dsOrion dsOrion;
        private System.Windows.Forms.BindingSource daysalesBindingSource2;
        private dsOrionTableAdapters.day_salesTableAdapter day_salesTableAdapter2;
        private System.Windows.Forms.BindingSource dayCreditBindingSource2;
        private dsOrionTableAdapters.Day_CreditTableAdapter day_CreditTableAdapter2;
        private System.Windows.Forms.BindingSource priceBindingSource2;
        private dsOrionTableAdapters.priceTableAdapter priceTableAdapter2;
        private System.Windows.Forms.BindingSource dsOrionBindingSource;
        private System.Windows.Forms.BindingSource dayPurchaseBindingSource2;
        private dsOrionTableAdapters.Day_PurchaseTableAdapter day_PurchaseTableAdapter2;
        private System.Windows.Forms.BindingSource dayReturnBindingSource2;
        private dsOrionTableAdapters.Day_ReturnTableAdapter day_ReturnTableAdapter2;
        private System.Windows.Forms.BindingSource quantityBindingSource2;
        private dsOrionTableAdapters.QuantityTableAdapter quantityTableAdapter2;
    }
}