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
    public partial class AdOffer : Form
    {
        private string username;

        public AdOffer()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard(username).Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string ad = tbAd.Text;
            string offer = tbOffer.Text;
            MessageBox.Show("Advertisement Created\n" + ad + "\nOffer :" + offer+"Taka");
        }
    }
}
