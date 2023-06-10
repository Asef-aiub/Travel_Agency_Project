
namespace TravelProject
{
    partial class VacancyTravelMngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacancyTravelMngr));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBacktoDashboard = new System.Windows.Forms.Button();
            this.tbPricePerSeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSeatType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRoute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAvailableSeats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TravelView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TravelView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(978, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 41);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "Update Vacancy";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(441, 462);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(114, 36);
            this.btnCreate.TabIndex = 61;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBacktoDashboard
            // 
            this.btnBacktoDashboard.Location = new System.Drawing.Point(112, 462);
            this.btnBacktoDashboard.Name = "btnBacktoDashboard";
            this.btnBacktoDashboard.Size = new System.Drawing.Size(114, 36);
            this.btnBacktoDashboard.TabIndex = 60;
            this.btnBacktoDashboard.Text = "Back";
            this.btnBacktoDashboard.UseVisualStyleBackColor = true;
            this.btnBacktoDashboard.Click += new System.EventHandler(this.btnBacktoDashboard_Click);
            // 
            // tbPricePerSeat
            // 
            this.tbPricePerSeat.Location = new System.Drawing.Point(313, 372);
            this.tbPricePerSeat.Name = "tbPricePerSeat";
            this.tbPricePerSeat.Size = new System.Drawing.Size(211, 26);
            this.tbPricePerSeat.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(71, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "PRICE PER SEAT :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSeatType
            // 
            this.tbSeatType.Location = new System.Drawing.Point(313, 263);
            this.tbSeatType.Name = "tbSeatType";
            this.tbSeatType.Size = new System.Drawing.Size(211, 26);
            this.tbSeatType.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(129, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 56;
            this.label6.Text = "SEAT TYPE :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRoute
            // 
            this.tbRoute.Location = new System.Drawing.Point(313, 206);
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(211, 26);
            this.tbRoute.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(171, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "ROUTE :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAvailableSeats
            // 
            this.tbAvailableSeats.Location = new System.Drawing.Point(313, 318);
            this.tbAvailableSeats.Name = "tbAvailableSeats";
            this.tbAvailableSeats.Size = new System.Drawing.Size(211, 26);
            this.tbAvailableSeats.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(59, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "AVAILABLE SEATS :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(313, 152);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(211, 26);
            this.tbCompanyName.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(80, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "COMPANY NAME :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TravelView
            // 
            this.TravelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelView.Location = new System.Drawing.Point(831, 108);
            this.TravelView.Name = "TravelView";
            this.TravelView.RowHeadersWidth = 62;
            this.TravelView.RowTemplate.Height = 28;
            this.TravelView.Size = new System.Drawing.Size(410, 349);
            this.TravelView.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Mimmo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(454, 30);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label2.Size = new System.Drawing.Size(348, 41);
            this.label2.TabIndex = 48;
            this.label2.Text = "Create / Update Vacancy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VacancyTravelMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBacktoDashboard);
            this.Controls.Add(this.tbPricePerSeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSeatType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbRoute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAvailableSeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TravelView);
            this.Controls.Add(this.label2);
            this.Name = "VacancyTravelMngr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacancy";
            ((System.ComponentModel.ISupportInitialize)(this.TravelView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBacktoDashboard;
        private System.Windows.Forms.TextBox tbPricePerSeat;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSeatType;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRoute;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAvailableSeats;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCompanyName;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TravelView;
        internal System.Windows.Forms.Label label2;
    }
}