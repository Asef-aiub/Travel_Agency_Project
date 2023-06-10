using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        private void btnLogIn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }
    }
}
