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
    public partial class Registration : Form
    {
        public Registration()
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var phoneNumber = tbPhNumber.Text;
            var gender = cbGender.Text;
            var managerType = "";
            if(rbHotelMngr.Checked)
            {
                managerType = rbHotelMngr.Text;
            }
            if(rbTravelMngr.Checked)
            {
                managerType = rbTravelMngr.Text;
            }
            var username = tbUsername.Text;
            var password = tbPassword.Text;
            var address = tbAddress.Text;
            Manager mngr = new Manager();
            mngr.name = name;
            mngr.phoneNumber = phoneNumber;
            mngr.gender = gender;
            mngr.managerType = managerType;
            mngr.username = username;
            mngr.password = password;
            mngr.address = address;
            Database db = new Database();
            bool rs = db.Managers.checkUsername(username);
            if (rs == true)
            {
                MessageBox.Show("Username Already Taken, Change");
            }
            else 
            {
                var r = db.Managers.insert(mngr);
                if (r)
                {
                    MessageBox.Show("Congratulation\nYou are successfully registered");
                    this.Hide();
                    new LogIn().Show();
                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
              


        }
    }
}
