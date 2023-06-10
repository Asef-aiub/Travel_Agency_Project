
namespace TravelProject
{
    partial class Update_Personal_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Personal_Information));
            this.tbPhNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBacktoDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPhNumber
            // 
            this.tbPhNumber.Location = new System.Drawing.Point(632, 250);
            this.tbPhNumber.Name = "tbPhNumber";
            this.tbPhNumber.Size = new System.Drawing.Size(211, 26);
            this.tbPhNumber.TabIndex = 25;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(632, 197);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(211, 26);
            this.tbName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(399, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "PHONE NUMBER :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(505, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "NAME :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(632, 309);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(211, 26);
            this.tbAddress.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(468, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "ADDRESS :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(775, 436);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 36);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBacktoDashboard
            // 
            this.btnBacktoDashboard.Location = new System.Drawing.Point(446, 436);
            this.btnBacktoDashboard.Name = "btnBacktoDashboard";
            this.btnBacktoDashboard.Size = new System.Drawing.Size(114, 36);
            this.btnBacktoDashboard.TabIndex = 28;
            this.btnBacktoDashboard.Text = "Back";
            this.btnBacktoDashboard.UseVisualStyleBackColor = true;
            this.btnBacktoDashboard.Click += new System.EventHandler(this.btnBacktoDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Mimmo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(516, 57);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label2.Size = new System.Drawing.Size(334, 41);
            this.label2.TabIndex = 30;
            this.label2.Text = "Update My Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Update_Personal_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBacktoDashboard);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPhNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Update_Personal_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPhNumber;
        private System.Windows.Forms.TextBox tbName;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBacktoDashboard;
        internal System.Windows.Forms.Label label2;
    }
}