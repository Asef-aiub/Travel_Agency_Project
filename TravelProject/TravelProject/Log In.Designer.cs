
namespace TravelProject
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBacktoHome = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label2.Font = new System.Drawing.Font("Mimmo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Maroon;
            this.Label2.Location = new System.Drawing.Point(554, 72);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.Label2.Size = new System.Drawing.Size(148, 49);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "LOG IN";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(602, 298);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(211, 26);
            this.tbPassword.TabIndex = 22;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(420, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "PASSWORD :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBacktoHome
            // 
            this.btnBacktoHome.Location = new System.Drawing.Point(409, 434);
            this.btnBacktoHome.Name = "btnBacktoHome";
            this.btnBacktoHome.Size = new System.Drawing.Size(114, 36);
            this.btnBacktoHome.TabIndex = 24;
            this.btnBacktoHome.Text = "Back";
            this.btnBacktoHome.UseVisualStyleBackColor = true;
            this.btnBacktoHome.Click += new System.EventHandler(this.btnBacktoHome_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(738, 434);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(114, 36);
            this.btnLogIn.TabIndex = 25;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(602, 242);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(211, 26);
            this.tbUsername.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Mimmo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(422, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "USERNAME :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 563);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnBacktoHome);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label2);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox tbPassword;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBacktoHome;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbUsername;
        internal System.Windows.Forms.Label label6;
    }
}