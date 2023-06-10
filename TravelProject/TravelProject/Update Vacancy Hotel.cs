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
    public partial class Update_Vacancy_Hotel : Form
    {
        private string username;

        public Update_Vacancy_Hotel()
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

      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbID.Text);
            
            Database db = new Database();
            VacancyHotel vchtl = db.VacanciesHotel.search(id);
            if (vchtl==null)
            {
                MessageBox.Show("Not Found");
                
            }
            else
            {                             
                tbHotelName.Text = vchtl.hotelName;
                tbRoomType.Text = vchtl.roomType;
                tbAvailableRooms.Text = Convert.ToString(vchtl.availableRooms);
                tbRentPerRoom.Text = Convert.ToString(vchtl.rentPerRoom);               
                HotelView.DataSource = db.VacanciesHotel.getAllHotels();  
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int upId = int.Parse(tbID.Text);

            string updatedHotelName = tbHotelName.Text;
            string updatedRoomType = tbRoomType.Text;
            int upAvailableRooms = int.Parse(tbAvailableRooms.Text);
            int upRentPerRoom = int.Parse(tbRentPerRoom.Text);
            
            VacancyHotel vchtl = new VacancyHotel();
            vchtl.hotelName=updatedHotelName;
            vchtl.roomType=updatedRoomType;
            vchtl.availableRooms=upAvailableRooms;
            vchtl.rentPerRoom=upRentPerRoom;
            vchtl.id = upId;
           

            Database db = new Database();
            bool rs = db.VacanciesHotel.update(vchtl);
            if (rs)
            {
                HotelView.DataSource = db.VacanciesHotel.getAllHotels();
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
            bool rs = db.VacanciesHotel.delete(id);
            if(rs)
            {
                HotelView.DataSource = db.VacanciesHotel.getAllHotels();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }

        private void btnBacktoCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VacancyHotelMngr().Show();
        }
    }
}
