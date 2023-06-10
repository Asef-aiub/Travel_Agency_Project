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
    public partial class VacancyHotelMngr : Form
    {
        private string username;

        public VacancyHotelMngr()
        {
            InitializeComponent();
            Database db = new Database();
            HotelView.DataSource = db.VacanciesHotel.getAllHotels();

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var hotelName = tbHotelName.Text;
            var location = tbLocation.Text;
            var roomType = tbRoomType.Text;
            int availableRooms = int.Parse(tbAvailableRooms.Text);
            int rentPerRoom = int.Parse(tbRentPerRoom.Text);
            VacancyHotel vchtl = new VacancyHotel();
            vchtl.hotelName = hotelName;
            vchtl.location = location;
            vchtl.roomType = roomType;
            vchtl.availableRooms = availableRooms;
            vchtl.rentPerRoom = rentPerRoom;
            Database db = new Database();
            var r = db.VacanciesHotel.insert(vchtl);
            if (r)
            {
                MessageBox.Show("Inserted");
                HotelView.DataSource = db.VacanciesHotel.getAllHotels();
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Update_Vacancy_Hotel().Show();
        }

     
    }
}
