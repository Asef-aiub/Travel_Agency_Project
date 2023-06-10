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
    public partial class Dashboard : Form
    {
        public string username;

        public Dashboard(String username)
        {
            InitializeComponent();
            this.username = username;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }

        private void btnCrtUpdtVacancy_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            bool rs = db.VacanciesHotel.checkManagerType(username);
            if (rs == true)
            {
                this.Hide();
                new VacancyHotelMngr().Show();
            }
            else
            {
                this.Hide();
                new VacancyTravelMngr ().Show();
            }
        }

        private void btnUpdtPrsnlInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Update_Personal_Information(username).Show();            
            
           
        }

        private void btmCrtAdOffer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdOffer().Show();
        }

        
    }
}
