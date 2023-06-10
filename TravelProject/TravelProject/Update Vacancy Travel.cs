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
    public partial class Update_Vacancy_Travel : Form
    {
        private string username;

        public Update_Vacancy_Travel()
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

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VacancyTravelMngr().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbID.Text);

            Database db = new Database();
            VacancyTravel vctvl = db.VacanciesTravel.search(id);
            if (vctvl == null)
            {
                MessageBox.Show("Not Found");

            }
            else
            {
                tbCompanyName.Text = vctvl.companyName;
                tbRoute.Text = vctvl.route;
                tbAvailableSeats.Text = Convert.ToString(vctvl.availableSeats);
                tbPricePerSeat.Text = Convert.ToString(vctvl.pricePerSeat);
                TravelView.DataSource = db.VacanciesTravel.getAllTravels();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int upId = int.Parse(tbID.Text);

            string updatedCompanyName = tbCompanyName.Text;
            string updatedRoute = tbRoute.Text;
            int upAvailableSeats = int.Parse(tbAvailableSeats.Text);
            int upPriceperSeat = int.Parse(tbPricePerSeat.Text);

            VacancyTravel vctvl = new VacancyTravel();
            vctvl.companyName = updatedCompanyName;
            vctvl.route = updatedRoute;
            vctvl.availableSeats = upAvailableSeats;
            vctvl.pricePerSeat = upPriceperSeat;
            vctvl.id = upId;


            Database db = new Database();
            bool rs = db.VacanciesTravel.update(vctvl);
            if (rs)
            {
                TravelView.DataSource = db.VacanciesTravel.getAllTravels();
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbID.Text);
            Database db = new Database();
            bool rs = db.VacanciesTravel.delete(id);
            if (rs)
            {
                TravelView.DataSource = db.VacanciesTravel.getAllTravels();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }
    }
}
