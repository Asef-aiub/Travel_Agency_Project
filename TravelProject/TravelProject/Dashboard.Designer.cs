
namespace TravelProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Label1 = new System.Windows.Forms.Label();
            this.btmCrtAdOffer = new System.Windows.Forms.Button();
            this.btnCrtUpdtVacancy = new System.Windows.Forms.Button();
            this.btnUpdtPrsnlInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label1.Font = new System.Drawing.Font("Mimmo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Maroon;
            this.Label1.Location = new System.Drawing.Point(453, 17);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.Label1.Size = new System.Drawing.Size(339, 41);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Welcome To Dashboard";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btmCrtAdOffer
            // 
            this.btmCrtAdOffer.Location = new System.Drawing.Point(470, 353);
            this.btmCrtAdOffer.Name = "btmCrtAdOffer";
            this.btmCrtAdOffer.Size = new System.Drawing.Size(311, 47);
            this.btmCrtAdOffer.TabIndex = 6;
            this.btmCrtAdOffer.Text = "Create Advertisement / Offer";
            this.btmCrtAdOffer.UseVisualStyleBackColor = true;
            this.btmCrtAdOffer.Click += new System.EventHandler(this.btmCrtAdOffer_Click);
            // 
            // btnCrtUpdtVacancy
            // 
            this.btnCrtUpdtVacancy.Location = new System.Drawing.Point(470, 255);
            this.btnCrtUpdtVacancy.Name = "btnCrtUpdtVacancy";
            this.btnCrtUpdtVacancy.Size = new System.Drawing.Size(311, 47);
            this.btnCrtUpdtVacancy.TabIndex = 7;
            this.btnCrtUpdtVacancy.Text = "Create / Update Vacancy";
            this.btnCrtUpdtVacancy.UseVisualStyleBackColor = true;
            this.btnCrtUpdtVacancy.Click += new System.EventHandler(this.btnCrtUpdtVacancy_Click);
            // 
            // btnUpdtPrsnlInfo
            // 
            this.btnUpdtPrsnlInfo.Location = new System.Drawing.Point(470, 160);
            this.btnUpdtPrsnlInfo.Name = "btnUpdtPrsnlInfo";
            this.btnUpdtPrsnlInfo.Size = new System.Drawing.Size(311, 47);
            this.btnUpdtPrsnlInfo.TabIndex = 8;
            this.btnUpdtPrsnlInfo.Text = "Update Personal Information";
            this.btnUpdtPrsnlInfo.UseVisualStyleBackColor = true;
            this.btnUpdtPrsnlInfo.Click += new System.EventHandler(this.btnUpdtPrsnlInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(566, 468);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "LOG OUT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdtPrsnlInfo);
            this.Controls.Add(this.btnCrtUpdtVacancy);
            this.Controls.Add(this.btmCrtAdOffer);
            this.Controls.Add(this.Label1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btmCrtAdOffer;
        private System.Windows.Forms.Button btnCrtUpdtVacancy;
        private System.Windows.Forms.Button btnUpdtPrsnlInfo;
        private System.Windows.Forms.Button btnExit;
    }
}