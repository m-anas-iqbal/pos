namespace Orion
{
    partial class frmEmployeePayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbl1113 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl1114 = new System.Windows.Forms.Label();
            this.lbl1065 = new System.Windows.Forms.Label();
            this.lbl1115 = new System.Windows.Forms.Label();
            this.dtpPaidDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lbl1116 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbl1080 = new System.Windows.Forms.Label();
            this.lbl1081 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lbl1004 = new System.Windows.Forms.Label();
            this.lbl1005 = new System.Windows.Forms.Label();
            this.lbl1104 = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(524, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlter.FlatAppearance.BorderSize = 0;
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.ForeColor = System.Drawing.Color.White;
            this.btnAlter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlter.Location = new System.Drawing.Point(612, 241);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(86, 32);
            this.btnAlter.TabIndex = 6;
            this.btnAlter.Text = "ALTER";
            this.btnAlter.UseVisualStyleBackColor = false;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(435, 241);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 32);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(347, 241);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 32);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(259, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 32);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(701, 241);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 32);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "SAVE";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbl1113
            // 
            this.lbl1113.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl1113.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1113.Location = new System.Drawing.Point(342, 4);
            this.lbl1113.Name = "lbl1113";
            this.lbl1113.Size = new System.Drawing.Size(449, 30);
            this.lbl1113.TabIndex = 14;
            this.lbl1113.Text = "Employee Payment";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(614, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 17);
            this.label12.TabIndex = 146;
            this.label12.Text = ":";
            // 
            // lbl1114
            // 
            this.lbl1114.ForeColor = System.Drawing.Color.DimGray;
            this.lbl1114.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1114.Location = new System.Drawing.Point(342, 34);
            this.lbl1114.Name = "lbl1114";
            this.lbl1114.Size = new System.Drawing.Size(449, 17);
            this.lbl1114.TabIndex = 15;
            this.lbl1114.Text = "It contains the following fields to maintain employee payment records:\r\n";
            // 
            // lbl1065
            // 
            this.lbl1065.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1065.Location = new System.Drawing.Point(625, 59);
            this.lbl1065.Name = "lbl1065";
            this.lbl1065.Size = new System.Drawing.Size(150, 17);
            this.lbl1065.TabIndex = 145;
            this.lbl1065.Text = "Date";
            // 
            // lbl1115
            // 
            this.lbl1115.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1115.Location = new System.Drawing.Point(625, 182);
            this.lbl1115.Name = "lbl1115";
            this.lbl1115.Size = new System.Drawing.Size(150, 17);
            this.lbl1115.TabIndex = 129;
            this.lbl1115.Text = "Description";
            // 
            // dtpPaidDate
            // 
            this.dtpPaidDate.CustomFormat = "MMM-dd-yyyy";
            this.dtpPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaidDate.Location = new System.Drawing.Point(481, 56);
            this.dtpPaidDate.Name = "dtpPaidDate";
            this.dtpPaidDate.RightToLeftLayout = true;
            this.dtpPaidDate.Size = new System.Drawing.Size(130, 25);
            this.dtpPaidDate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(614, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 127;
            this.label5.Text = ":";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescription.Location = new System.Drawing.Point(344, 180);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 25);
            this.txtDescription.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(614, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 130;
            this.label7.Text = ":";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(481, 210);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(130, 25);
            this.txtPaidAmount.TabIndex = 4;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPhoneNo.Location = new System.Drawing.Point(344, 148);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.ReadOnly = true;
            this.txtPhoneNo.Size = new System.Drawing.Size(267, 25);
            this.txtPhoneNo.TabIndex = 125;
            // 
            // lbl1116
            // 
            this.lbl1116.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1116.Location = new System.Drawing.Point(625, 213);
            this.lbl1116.Name = "lbl1116";
            this.lbl1116.Size = new System.Drawing.Size(150, 17);
            this.lbl1116.TabIndex = 132;
            this.lbl1116.Text = "Paid Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(614, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 17);
            this.label3.TabIndex = 124;
            this.label3.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(614, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 17);
            this.label14.TabIndex = 121;
            this.label14.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(614, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 17);
            this.label10.TabIndex = 133;
            this.label10.Text = ":";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAddress.Location = new System.Drawing.Point(344, 117);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(267, 25);
            this.txtAddress.TabIndex = 122;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.cmbEmployee);
            this.panel3.Controls.Add(this.dateFrom);
            this.panel3.Controls.Add(this.lbl1004);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.lbl1005);
            this.panel3.Controls.Add(this.lbl1080);
            this.panel3.Controls.Add(this.lbl1104);
            this.panel3.Controls.Add(this.txtPaymentID);
            this.panel3.Controls.Add(this.lbl1081);
            this.panel3.Controls.Add(this.lbl1113);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.lbl1114);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.lbl1065);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.lbl1115);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.dtpPaidDate);
            this.panel3.Controls.Add(this.dateTo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnAlter);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.txtPaidAmount);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtPhoneNo);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.lbl1116);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(125, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 482);
            this.panel3.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 313);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(797, 169);
            this.panel7.TabIndex = 149;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(797, 169);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EMP_PAY_ID";
            this.Column1.HeaderText = "EMP_PAY_ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EmployeeName";
            this.Column2.HeaderText = "Employee Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PhoneNo";
            this.Column4.HeaderText = "Phone No";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PaidDate";
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Description";
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PaidAmount";
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "MMM-dd-yyyy";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(565, 282);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.RightToLeftLayout = true;
            this.dateFrom.Size = new System.Drawing.Size(130, 25);
            this.dateFrom.TabIndex = 153;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(246, 282);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 25);
            this.btnSearch.TabIndex = 153;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbl1080
            // 
            this.lbl1080.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1080.Location = new System.Drawing.Point(701, 286);
            this.lbl1080.Name = "lbl1080";
            this.lbl1080.Size = new System.Drawing.Size(90, 17);
            this.lbl1080.TabIndex = 149;
            this.lbl1080.Text = "From";
            // 
            // lbl1081
            // 
            this.lbl1081.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1081.Location = new System.Drawing.Point(471, 286);
            this.lbl1081.Name = "lbl1081";
            this.lbl1081.Size = new System.Drawing.Size(88, 17);
            this.lbl1081.TabIndex = 154;
            this.lbl1081.Text = "To";
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "MMM-dd-yyyy";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(335, 282);
            this.dateTo.Name = "dateTo";
            this.dateTo.RightToLeftLayout = true;
            this.dateTo.Size = new System.Drawing.Size(130, 25);
            this.dateTo.TabIndex = 155;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(344, 85);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(267, 25);
            this.cmbEmployee.TabIndex = 150;
            // 
            // lbl1004
            // 
            this.lbl1004.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1004.Location = new System.Drawing.Point(626, 119);
            this.lbl1004.Name = "lbl1004";
            this.lbl1004.Size = new System.Drawing.Size(150, 17);
            this.lbl1004.TabIndex = 148;
            this.lbl1004.Text = "Address";
            // 
            // lbl1005
            // 
            this.lbl1005.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1005.Location = new System.Drawing.Point(626, 150);
            this.lbl1005.Name = "lbl1005";
            this.lbl1005.Size = new System.Drawing.Size(150, 17);
            this.lbl1005.TabIndex = 149;
            this.lbl1005.Text = "Phone No. ";
            // 
            // lbl1104
            // 
            this.lbl1104.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1104.Location = new System.Drawing.Point(625, 90);
            this.lbl1104.Name = "lbl1104";
            this.lbl1104.Size = new System.Drawing.Size(150, 17);
            this.lbl1104.TabIndex = 147;
            this.lbl1104.Text = "Employee Name ";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPaymentID.Location = new System.Drawing.Point(447, 56);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.ReadOnly = true;
            this.txtPaymentID.Size = new System.Drawing.Size(33, 25);
            this.txtPaymentID.TabIndex = 117;
            this.txtPaymentID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 482);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 23);
            this.panel1.TabIndex = 10;
            // 
            // frmEmployeePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 505);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeePayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Employee Payment";
            this.Load += new System.EventHandler(this.frmEmployeePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbl1113;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl1114;
        private System.Windows.Forms.Label lbl1065;
        private System.Windows.Forms.Label lbl1115;
        private System.Windows.Forms.DateTimePicker dtpPaidDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lbl1116;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl1080;
        private System.Windows.Forms.Label lbl1081;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label lbl1104;
        private System.Windows.Forms.Label lbl1004;
        private System.Windows.Forms.Label lbl1005;
        private System.Windows.Forms.ComboBox cmbEmployee;
    }
}