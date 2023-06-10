
namespace TravelProject
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Label2 = new System.Windows.Forms.Label();
            this.btnLogIn1 = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label2.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Maroon;
            this.Label2.Location = new System.Drawing.Point(528, 173);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.Label2.Size = new System.Drawing.Size(194, 32);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "SIGN UP / LOG IN";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogIn1
            // 
            this.btnLogIn1.AutoSize = true;
            this.btnLogIn1.Location = new System.Drawing.Point(722, 335);
            this.btnLogIn1.Name = "btnLogIn1";
            this.btnLogIn1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.btnLogIn1.Size = new System.Drawing.Size(113, 40);
            this.btnLogIn1.TabIndex = 6;
            this.btnLogIn1.Text = "LOG IN";
            this.btnLogIn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogIn1.UseVisualStyleBackColor = true;
            this.btnLogIn1.Click += new System.EventHandler(this.btnLogIn1_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Location = new System.Drawing.Point(422, 335);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.btnSignUp.Size = new System.Drawing.Size(113, 40);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label1.Font = new System.Drawing.Font("Mimmo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Maroon;
            this.Label1.Location = new System.Drawing.Point(390, 77);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.Label1.Size = new System.Drawing.Size(467, 41);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Welcome To Manager Home Page";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnLogIn1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.Label1);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnLogIn1;
        internal System.Windows.Forms.Button btnSignUp;
        internal System.Windows.Forms.Label Label1;
    }
}

