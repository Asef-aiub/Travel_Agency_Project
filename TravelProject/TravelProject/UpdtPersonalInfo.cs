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
using TravelProject_DataAccess.Entities;

namespace TravelProject
{
    public partial class Update_Personal_Information : Form
    {
        string username;
        public Update_Personal_Information(string username)
        {
            InitializeComponent();
            this.username = username;
            Database db = new Database();
            Manager mngr = db.Managers.GetManager(username);
            tbName.Text = mngr.name;
            tbPhNumber.Text = mngr.phoneNumber;
            tbAddress.Text = mngr.address;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatedName = tbName.Text;
            string updatedPhoneNumber = tbPhNumber.Text;
            string updatedAddress = tbAddress.Text;
            string uname = this.username;
            
            Manager mngr = new Manager();
            mngr.name = updatedName;
            mngr.phoneNumber = updatedPhoneNumber;
            mngr.address = updatedAddress;
            mngr.username = uname;

            Database db = new Database();
            bool rs = db.Managers.update(mngr);
            if (rs)
            {

                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("failed");
            }


        }
    }
}
