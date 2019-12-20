namespace AzmanSys.Forms
{
    partial class FlightAvailabilityForm
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
            this.Flight_Form_Title = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FromLabel = new System.Windows.Forms.Label();
            this.To_Label = new System.Windows.Forms.Label();
            this.DepatureTimeLabel = new System.Windows.Forms.Label();
            this.ArrivalTimeLabel = new System.Windows.Forms.Label();
            this.ArrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearchFlights = new System.Windows.Forms.Button();
            this.tbFromLocation = new System.Windows.Forms.TextBox();
            this.tbToLocation = new System.Windows.Forms.TextBox();
            this.sFormToMain = new System.Windows.Forms.Button();
            this.ViewAvailableFlights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAvailableFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // Flight_Form_Title
            // 
            this.Flight_Form_Title.AutoSize = true;
            this.Flight_Form_Title.Font = new System.Drawing.Font("Felix Titling", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flight_Form_Title.Location = new System.Drawing.Point(173, 24);
            this.Flight_Form_Title.Name = "Flight_Form_Title";
            this.Flight_Form_Title.Size = new System.Drawing.Size(458, 40);
            this.Flight_Form_Title.TabIndex = 0;
            this.Flight_Form_Title.Text = "Flight Searching Tool";
            this.Flight_Form_Title.Click += new System.EventHandler(this.Label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(372, 138);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(44, 18);
            this.FromLabel.TabIndex = 2;
            this.FromLabel.Text = "From";
            this.FromLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // To_Label
            // 
            this.To_Label.AutoSize = true;
            this.To_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_Label.Location = new System.Drawing.Point(372, 184);
            this.To_Label.Name = "To_Label";
            this.To_Label.Size = new System.Drawing.Size(26, 18);
            this.To_Label.TabIndex = 3;
            this.To_Label.Text = "To";
            // 
            // DepatureTimeLabel
            // 
            this.DepatureTimeLabel.AutoSize = true;
            this.DepatureTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepatureTimeLabel.Location = new System.Drawing.Point(372, 241);
            this.DepatureTimeLabel.Name = "DepatureTimeLabel";
            this.DepatureTimeLabel.Size = new System.Drawing.Size(117, 18);
            this.DepatureTimeLabel.TabIndex = 5;
            this.DepatureTimeLabel.Text = "Depature Time : ";
            this.DepatureTimeLabel.Click += new System.EventHandler(this.DepatureTimeLabel_Click);
            // 
            // ArrivalTimeLabel
            // 
            this.ArrivalTimeLabel.AutoSize = true;
            this.ArrivalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalTimeLabel.Location = new System.Drawing.Point(372, 296);
            this.ArrivalTimeLabel.Name = "ArrivalTimeLabel";
            this.ArrivalTimeLabel.Size = new System.Drawing.Size(97, 18);
            this.ArrivalTimeLabel.TabIndex = 6;
            this.ArrivalTimeLabel.Text = "Arrival Time : ";
            // 
            // ArrivalTimePicker
            // 
            this.ArrivalTimePicker.Location = new System.Drawing.Point(495, 296);
            this.ArrivalTimePicker.Name = "ArrivalTimePicker";
            this.ArrivalTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ArrivalTimePicker.TabIndex = 7;
            this.ArrivalTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // DepartTimePicker
            // 
            this.DepartTimePicker.Location = new System.Drawing.Point(495, 241);
            this.DepartTimePicker.Name = "DepartTimePicker";
            this.DepartTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DepartTimePicker.TabIndex = 8;
            // 
            // btnSearchFlights
            // 
            this.btnSearchFlights.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchFlights.Location = new System.Drawing.Point(375, 389);
            this.btnSearchFlights.Name = "btnSearchFlights";
            this.btnSearchFlights.Size = new System.Drawing.Size(144, 40);
            this.btnSearchFlights.TabIndex = 9;
            this.btnSearchFlights.Text = "Search";
            this.btnSearchFlights.UseVisualStyleBackColor = true;
            this.btnSearchFlights.Click += new System.EventHandler(this.BtnSearchFlights_Click);
            // 
            // tbFromLocation
            // 
            this.tbFromLocation.Location = new System.Drawing.Point(495, 138);
            this.tbFromLocation.Name = "tbFromLocation";
            this.tbFromLocation.Size = new System.Drawing.Size(200, 20);
            this.tbFromLocation.TabIndex = 10;
            // 
            // tbToLocation
            // 
            this.tbToLocation.Location = new System.Drawing.Point(495, 185);
            this.tbToLocation.Name = "tbToLocation";
            this.tbToLocation.Size = new System.Drawing.Size(200, 20);
            this.tbToLocation.TabIndex = 11;
            // 
            // sFormToMain
            // 
            this.sFormToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sFormToMain.Location = new System.Drawing.Point(538, 389);
            this.sFormToMain.Name = "sFormToMain";
            this.sFormToMain.Size = new System.Drawing.Size(157, 40);
            this.sFormToMain.TabIndex = 12;
            this.sFormToMain.Text = "Main Menu";
            this.sFormToMain.UseVisualStyleBackColor = true;
            this.sFormToMain.Click += new System.EventHandler(this.SFormToMain_Click);
            // 
            // ViewAvailableFlights
            // 
            this.ViewAvailableFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAvailableFlights.Location = new System.Drawing.Point(26, 138);
            this.ViewAvailableFlights.Name = "ViewAvailableFlights";
            this.ViewAvailableFlights.Size = new System.Drawing.Size(319, 291);
            this.ViewAvailableFlights.TabIndex = 13;
            this.ViewAvailableFlights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewAvailableFlights_CellContentClick);
            // 
            // FlightAvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewAvailableFlights);
            this.Controls.Add(this.sFormToMain);
            this.Controls.Add(this.tbToLocation);
            this.Controls.Add(this.tbFromLocation);
            this.Controls.Add(this.btnSearchFlights);
            this.Controls.Add(this.DepartTimePicker);
            this.Controls.Add(this.ArrivalTimePicker);
            this.Controls.Add(this.ArrivalTimeLabel);
            this.Controls.Add(this.DepatureTimeLabel);
            this.Controls.Add(this.To_Label);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.Flight_Form_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FlightAvailabilityForm";
            this.Text = "FlightAvailabilityForm";
            this.Load += new System.EventHandler(this.FlightAvailabilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewAvailableFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Flight_Form_Title;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label To_Label;
        private System.Windows.Forms.Label DepatureTimeLabel;
        private System.Windows.Forms.Label ArrivalTimeLabel;
        private System.Windows.Forms.DateTimePicker ArrivalTimePicker;
        private System.Windows.Forms.DateTimePicker DepartTimePicker;
        private System.Windows.Forms.Button btnSearchFlights;
        private System.Windows.Forms.TextBox tbFromLocation;
        private System.Windows.Forms.TextBox tbToLocation;
        private System.Windows.Forms.Button sFormToMain;
        private System.Windows.Forms.DataGridView ViewAvailableFlights;
    }
}