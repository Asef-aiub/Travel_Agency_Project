
namespace TravelProject
{
    partial class Update_Vacancy_Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Vacancy_Hotel));
            this.HotelView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbRentPerRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAvailableRooms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBacktoCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHotelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HotelView)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelView
            // 
            this.HotelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotelView.Location = new System.Drawing.Point(794, 88);
            this.HotelView.Name = "HotelView";
            this.HotelView.RowHeadersWidth = 62;
            this.HotelView.RowTemplate.Height = 28;
            this.HotelView.Size = new System.Drawing.Size(410, 349);
            this.HotelView.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(578, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 36);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbRentPerRoom
            // 
            this.tbRentPerRoom.Location = new System.Drawing.Point(318, 331);
            this.tbRentPerRoom.Name = "tbRentPerRoom";
            this.tbRentPerRoom.Size = new System.Drawing.Size(211, 26);
            this.tbRentPerRoom.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(76, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 22);
            this.label4.TabIndex = 52;
            this.label4.Text = "RENT PER ROOM :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(318, 226);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(211, 26);
            this.tbRoomType.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(127, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 50;
            this.label6.Text = "ROOM TYPE :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAvailableRooms
            // 
            this.tbAvailableRooms.Location = new System.Drawing.Point(318, 277);
            this.tbAvailableRooms.Name = "tbAvailableRooms";
            this.tbAvailableRooms.Size = new System.Drawing.Size(211, 26);
            this.tbAvailableRooms.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(55, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "AVAILABLE ROOMS :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(182, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 36);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBacktoCreate
            // 
            this.btnBacktoCreate.Location = new System.Drawing.Point(32, 505);
            this.btnBacktoCreate.Name = "btnBacktoCreate";
            this.btnBacktoCreate.Size = new System.Drawing.Size(114, 36);
            this.btnBacktoCreate.TabIndex = 54;
            this.btnBacktoCreate.Text = "Back";
            this.btnBacktoCreate.UseVisualStyleBackColor = true;
            this.btnBacktoCreate.Click += new System.EventHandler(this.btnBacktoCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(495, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 36);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(318, 86);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(211, 26);
            this.tbID.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(225, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHotelName
            // 
            this.tbHotelName.Location = new System.Drawing.Point(318, 182);
            this.tbHotelName.Name = "tbHotelName";
            this.tbHotelName.Size = new System.Drawing.Size(211, 26);
            this.tbHotelName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(113, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 59;
            this.label1.Text = "HOTEL NAME :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Update_Vacancy_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.tbHotelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBacktoCreate);
            this.Controls.Add(this.tbRentPerRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRoomType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAvailableRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.HotelView);
            this.Name = "Update_Vacancy_Hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Vacancy";
            ((System.ComponentModel.ISupportInitialize)(this.HotelView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HotelView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbRentPerRoom;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRoomType;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAvailableRooms;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBacktoCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbID;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHotelName;
        internal System.Windows.Forms.Label label1;
    }
}