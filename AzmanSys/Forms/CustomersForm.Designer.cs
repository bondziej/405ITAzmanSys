﻿namespace AzmanSys
{
    partial class CustomersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustID = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCusNationality = new System.Windows.Forms.TextBox();
            this.CustomersToMenu = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 195);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(496, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(496, 76);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(496, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone Number";
            // 
            // tbCustID
            // 
            this.tbCustID.Enabled = false;
            this.tbCustID.Location = new System.Drawing.Point(179, 33);
            this.tbCustID.Name = "tbCustID";
            this.tbCustID.ReadOnly = true;
            this.tbCustID.Size = new System.Drawing.Size(100, 20);
            this.tbCustID.TabIndex = 8;
            this.tbCustID.TextChanged += new System.EventHandler(this.TbCustID_TextChanged);
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(179, 65);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(100, 20);
            this.tbFName.TabIndex = 9;
            this.tbFName.TextChanged += new System.EventHandler(this.TbFName_TextChanged);
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(179, 101);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(100, 20);
            this.tbLName.TabIndex = 10;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(179, 139);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(100, 20);
            this.tbTel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nationality";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // tbCusNationality
            // 
            this.tbCusNationality.Location = new System.Drawing.Point(377, 33);
            this.tbCusNationality.Name = "tbCusNationality";
            this.tbCusNationality.Size = new System.Drawing.Size(100, 20);
            this.tbCusNationality.TabIndex = 13;
            this.tbCusNationality.TextChanged += new System.EventHandler(this.TbCusNationality_TextChanged);
            // 
            // CustomersToMenu
            // 
            this.CustomersToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustomersToMenu.Location = new System.Drawing.Point(604, 36);
            this.CustomersToMenu.Name = "CustomersToMenu";
            this.CustomersToMenu.Size = new System.Drawing.Size(127, 23);
            this.CustomersToMenu.TabIndex = 14;
            this.CustomersToMenu.Text = "Main Menu";
            this.CustomersToMenu.UseVisualStyleBackColor = true;
            this.CustomersToMenu.Click += new System.EventHandler(this.CustomersToMenu_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBtn.Location = new System.Drawing.Point(604, 76);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(127, 23);
            this.ResetBtn.TabIndex = 15;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.CustomersToMenu);
            this.Controls.Add(this.tbCusNationality);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.tbCustID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CustomersForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustID;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCusNationality;
        private System.Windows.Forms.Button CustomersToMenu;
        private System.Windows.Forms.Button ResetBtn;
    }
}