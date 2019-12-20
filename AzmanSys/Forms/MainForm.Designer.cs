namespace AzmanSys
{
    partial class MainForm
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
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageFlights = new System.Windows.Forms.Button();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAvailabilityForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCustomers.Location = new System.Drawing.Point(304, 208);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(103, 52);
            this.btnManageCustomers.TabIndex = 0;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageFlights
            // 
            this.btnManageFlights.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageFlights.Location = new System.Drawing.Point(434, 208);
            this.btnManageFlights.Name = "btnManageFlights";
            this.btnManageFlights.Size = new System.Drawing.Size(94, 52);
            this.btnManageFlights.TabIndex = 1;
            this.btnManageFlights.Text = "Manage Flights";
            this.btnManageFlights.UseVisualStyleBackColor = true;
            this.btnManageFlights.Click += new System.EventHandler(this.btnManageFlights_Click);
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageBookings.Location = new System.Drawing.Point(563, 208);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(102, 52);
            this.btnManageBookings.TabIndex = 2;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.UseVisualStyleBackColor = true;
            this.btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AzmanSys.Properties.Resources.airplane_1010247_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 260);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "BT Flight Systems";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAvailabilityForm
            // 
            this.btnAvailabilityForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvailabilityForm.Location = new System.Drawing.Point(332, 120);
            this.btnAvailabilityForm.Name = "btnAvailabilityForm";
            this.btnAvailabilityForm.Size = new System.Drawing.Size(302, 39);
            this.btnAvailabilityForm.TabIndex = 5;
            this.btnAvailabilityForm.Text = "Search for flight availability";
            this.btnAvailabilityForm.UseVisualStyleBackColor = true;
            this.btnAvailabilityForm.Click += new System.EventHandler(this.btnAvailabilityForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 293);
            this.Controls.Add(this.btnAvailabilityForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnManageBookings);
            this.Controls.Add(this.btnManageFlights);
            this.Controls.Add(this.btnManageCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "BT Flight System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageFlights;
        private System.Windows.Forms.Button btnManageBookings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAvailabilityForm;
    }
}

