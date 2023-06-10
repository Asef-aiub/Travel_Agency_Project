
namespace TravelProject
{
    partial class AdOffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdOffer));
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOffer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnBacktoDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(636, 253);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(338, 26);
            this.tbAd.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(384, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 22);
            this.label7.TabIndex = 74;
            this.label7.Text = "ADVERTISEMENT :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOffer
            // 
            this.tbOffer.Location = new System.Drawing.Point(636, 322);
            this.tbOffer.Name = "tbOffer";
            this.tbOffer.Size = new System.Drawing.Size(211, 26);
            this.tbOffer.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(489, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 76;
            this.label1.Text = "OFFER :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Mimmo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(487, 37);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label2.Size = new System.Drawing.Size(407, 41);
            this.label2.TabIndex = 78;
            this.label2.Text = "Create Advertisement / Offer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "(deduct in cash)";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(780, 449);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(114, 36);
            this.btnDone.TabIndex = 81;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnBacktoDashboard
            // 
            this.btnBacktoDashboard.Location = new System.Drawing.Point(467, 449);
            this.btnBacktoDashboard.Name = "btnBacktoDashboard";
            this.btnBacktoDashboard.Size = new System.Drawing.Size(114, 36);
            this.btnBacktoDashboard.TabIndex = 80;
            this.btnBacktoDashboard.Text = "Back";
            this.btnBacktoDashboard.UseVisualStyleBackColor = true;
            this.btnBacktoDashboard.Click += new System.EventHandler(this.btnBacktoDashboard_Click);
            // 
            // AdOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnBacktoDashboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOffer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label7);
            this.Name = "AdOffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advertisement / Offer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAd;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOffer;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnBacktoDashboard;
    }
}