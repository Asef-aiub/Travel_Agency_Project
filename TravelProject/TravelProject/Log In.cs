using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelProject_DataAccess;

namespace TravelProject
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void btnBacktoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            Database db = new Database();
            bool rs = db.Managers.checkLogIn(username, password);
            if (rs==true)
            {
                this.Hide();
                new Dashboard(username).Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            Dashboard dashboard = new Dashboard(username);

        }
    }
}
