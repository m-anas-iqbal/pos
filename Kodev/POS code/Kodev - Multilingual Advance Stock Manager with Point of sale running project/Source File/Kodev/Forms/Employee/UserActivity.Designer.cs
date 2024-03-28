
namespace Kodev.Forms.Employee
{
    partial class UserActivity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.useract = new System.Windows.Forms.DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logout_Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useract)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.useract);
            this.panel1.Location = new System.Drawing.Point(89, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 293);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Activity";
            // 
            // useract
            // 
            this.useract.AllowUserToAddRows = false;
            this.useract.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.useract.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.useract.BackgroundColor = System.Drawing.SystemColors.Control;
            this.useract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.useract.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.useract.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.useract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.fullName,
            this.Login_Datetime,
            this.Logout_Datetime});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.useract.DefaultCellStyle = dataGridViewCellStyle4;
            this.useract.Dock = System.Windows.Forms.DockStyle.Left;
            this.useract.GridColor = System.Drawing.SystemColors.Control;
            this.useract.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.useract.Location = new System.Drawing.Point(0, 0);
            this.useract.MultiSelect = false;
            this.useract.Name = "useract";
            this.useract.ReadOnly = true;
            this.useract.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.useract.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.useract.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            this.useract.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.useract.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.useract.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.useract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.useract.ShowEditingIcon = false;
            this.useract.Size = new System.Drawing.Size(677, 293);
            this.useract.TabIndex = 112;
            // 
            // User_ID
            // 
            this.User_ID.DataPropertyName = "User_ID";
            this.User_ID.HeaderText = "User ID";
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            dataGridViewCellStyle3.Format = "MMM-dd-yyyy";
            this.fullName.DefaultCellStyle = dataGridViewCellStyle3;
            this.fullName.HeaderText = "User Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 180;
            // 
            // Login_Datetime
            // 
            this.Login_Datetime.DataPropertyName = "Login_Datetime";
            this.Login_Datetime.HeaderText = "Login time";
            this.Login_Datetime.Name = "Login_Datetime";
            this.Login_Datetime.ReadOnly = true;
            this.Login_Datetime.Width = 180;
            // 
            // Logout_Datetime
            // 
            this.Logout_Datetime.DataPropertyName = "Logout_Datetime";
            this.Logout_Datetime.HeaderText = "Logout time";
            this.Logout_Datetime.Name = "Logout_Datetime";
            this.Logout_Datetime.ReadOnly = true;
            this.Logout_Datetime.Width = 180;
            // 
            // UserActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserActivity";
            this.Text = "UserActivity";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.useract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView useract;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_Datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logout_Datetime;
    }
}