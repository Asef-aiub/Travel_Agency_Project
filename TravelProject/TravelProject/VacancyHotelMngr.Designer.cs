
namespace TravelProject
{
    partial class VacancyHotelMngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacancyHotelMngr));
            this.label2 = new System.Windows.Forms.Label();
            this.HotelView = new System.Windows.Forms.DataGridView();
            this.tbAvailableRooms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHotelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRentPerRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBacktoDashboard = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HotelView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Mimmo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(448, 27);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label2.Size = new System.Drawing.Size(348, 41);
            this.label2.TabIndex = 31;
            this.label2.Text = "Create / Update Vacancy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HotelView
            // 
            this.HotelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotelView.Location = new System.Drawing.Point(825, 105);
            this.HotelView.Name = "HotelView";
            this.HotelView.RowHeadersWidth = 62;
            this.HotelView.RowTemplate.Height = 28;
            this.HotelView.Size = new System.Drawing.Size(410, 349);
            this.HotelView.TabIndex = 32;
            // 
            // tbAvailableRooms
            // 
            this.tbAvailableRooms.Location = new System.Drawing.Point(307, 315);
            this.tbAvailableRooms.Name = "tbAvailableRooms";
            this.tbAvailableRooms.Size = new System.Drawing.Size(211, 26);
            this.tbAvailableRooms.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(44, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "AVAILABLE ROOMS :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHotelName
            // 
            this.tbHotelName.Location = new System.Drawing.Point(307, 149);
            this.tbHotelName.Name = "tbHotelName";
            this.tbHotelName.Size = new System.Drawing.Size(211, 26);
            this.tbHotelName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(102, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "HOTEL NAME :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(307, 203);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(211, 26);
            this.tbLocation.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(131, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "LOCATION :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(307, 260);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(211, 26);
            this.tbRoomType.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(116, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "ROOM TYPE :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRentPerRoom
            // 
            this.tbRentPerRoom.Location = new System.Drawing.Point(307, 369);
            this.tbRentPerRoom.Name = "tbRentPerRoom";
            this.tbRentPerRoom.Size = new System.Drawing.Size(211, 26);
            this.tbRentPerRoom.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(65, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "RENT PER ROOM :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(435, 459);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(114, 36);
            this.btnCreate.TabIndex = 46;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBacktoDashboard
            // 
            this.btnBacktoDashboard.Location = new System.Drawing.Point(106, 459);
            this.btnBacktoDashboard.Name = "btnBacktoDashboard";
            this.btnBacktoDashboard.Size = new System.Drawing.Size(114, 36);
            this.btnBacktoDashboard.TabIndex = 45;
            this.btnBacktoDashboard.Text = "Back";
            this.btnBacktoDashboard.UseVisualStyleBackColor = true;
            this.btnBacktoDashboard.Click += new System.EventHandler(this.btnBacktoDashboard_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(972, 489);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 41);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update Vacancy";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // VacancyHotelMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBacktoDashboard);
            this.Controls.Add(this.tbRentPerRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRoomType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAvailableRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHotelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HotelView);
            this.Controls.Add(this.label2);
            this.Name = "VacancyHotelMngr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacancy";
            ((System.ComponentModel.ISupportInitialize)(this.HotelView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView HotelView;
        private System.Windows.Forms.TextBox tbAvailableRooms;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHotelName;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLocation;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRoomType;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRentPerRoom;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBacktoDashboard;
        private System.Windows.Forms.Button btnUpdate;
    }
}