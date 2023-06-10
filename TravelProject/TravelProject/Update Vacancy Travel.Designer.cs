
namespace TravelProject
{
    partial class Update_Vacancy_Travel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Vacancy_Travel));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBacktoCreate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TravelView = new System.Windows.Forms.DataGridView();
            this.tbPricePerSeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRoute = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAvailableSeats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TravelView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(495, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 36);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(182, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 36);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBacktoCreate
            // 
            this.btnBacktoCreate.Location = new System.Drawing.Point(32, 505);
            this.btnBacktoCreate.Name = "btnBacktoCreate";
            this.btnBacktoCreate.Size = new System.Drawing.Size(114, 36);
            this.btnBacktoCreate.TabIndex = 67;
            this.btnBacktoCreate.Text = "Back";
            this.btnBacktoCreate.UseVisualStyleBackColor = true;
            this.btnBacktoCreate.Click += new System.EventHandler(this.btnBacktoDashboard_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(578, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 36);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TravelView
            // 
            this.TravelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelView.Location = new System.Drawing.Point(794, 88);
            this.TravelView.Name = "TravelView";
            this.TravelView.RowHeadersWidth = 62;
            this.TravelView.RowTemplate.Height = 28;
            this.TravelView.Size = new System.Drawing.Size(410, 349);
            this.TravelView.TabIndex = 57;
            // 
            // tbPricePerSeat
            // 
            this.tbPricePerSeat.Location = new System.Drawing.Point(318, 328);
            this.tbPricePerSeat.Name = "tbPricePerSeat";
            this.tbPricePerSeat.Size = new System.Drawing.Size(211, 26);
            this.tbPricePerSeat.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(76, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 76;
            this.label2.Text = "PRICE PER SEAT :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRoute
            // 
            this.tbRoute.Location = new System.Drawing.Point(318, 229);
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(211, 26);
            this.tbRoute.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(176, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 72;
            this.label7.Text = "ROUTE :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAvailableSeats
            // 
            this.tbAvailableSeats.Location = new System.Drawing.Point(318, 274);
            this.tbAvailableSeats.Name = "tbAvailableSeats";
            this.tbAvailableSeats.Size = new System.Drawing.Size(211, 26);
            this.tbAvailableSeats.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(64, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 22);
            this.label8.TabIndex = 70;
            this.label8.Text = "AVAILABLE SEATS :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(318, 86);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(211, 26);
            this.tbID.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(223, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 78;
            this.label3.Text = "ID :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(318, 184);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(211, 26);
            this.tbCompanyName.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(85, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 80;
            this.label1.Text = "COMPANY NAME :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Update_Vacancy_Travel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPricePerSeat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRoute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAvailableSeats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBacktoCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TravelView);
            this.Name = "Update_Vacancy_Travel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Vacancy";
            ((System.ComponentModel.ISupportInitialize)(this.TravelView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBacktoCreate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView TravelView;
        private System.Windows.Forms.TextBox tbPricePerSeat;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRoute;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAvailableSeats;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbID;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCompanyName;
        internal System.Windows.Forms.Label label1;
    }
}