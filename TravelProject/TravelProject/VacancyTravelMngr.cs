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
    public partial class VacancyTravelMngr : Form
    {
        private string username;

        public VacancyTravelMngr()
        {
            InitializeComponent();
            Database db = new Database();
            TravelView.DataSource = db.VacanciesTravel.getAllTravels();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var companyName = tbCompanyName.Text;
            var route = tbRoute.Text;
            var seatType = tbSeatType.Text;
            int availableSeats = int.Parse(tbAvailableSeats.Text);
            int pricePerSeat = int.Parse(tbPricePerSeat.Text);
            VacancyTravel vctvl = new VacancyTravel();
            vctvl.companyName = companyName;
            vctvl.route = route;
            vctvl.seatType = seatType;
            vctvl.availableSeats = availableSeats;
            vctvl.pricePerSeat = pricePerSeat;
            Database db = new Database();
            var r = db.VacanciesTravel.insert(vctvl);
            if (r)
            {
                MessageBox.Show("Inserted");
                TravelView.DataSource = db.VacanciesTravel.getAllTravels();
            }
            else
            {
                MessageBox.Show("Error");
            }






        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Update_Vacancy_Travel().Show();
        }

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard(username).Show();
        }
    }
}
