using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TravelProject_DataAccess.Entities;



namespace TravelProject_DataAccess.Tables
{
    public class VacanciesHotel
    {

        SqlConnection conn;
        public VacanciesHotel(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool insert(VacancyHotel vchtl)
        {
            string query = string.Format("insert into Vacancies_Hotel values ('{0}','{1}','{2}','{3}','{4}')", vchtl.hotelName,vchtl.location,vchtl.roomType,vchtl.availableRooms,vchtl.rentPerRoom);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public bool update(VacancyHotel vchtl)
        {
            string query = string.Format("Update Vacancies_Hotel set Hotel_Name='{0}' , Room_Type='{1}' , Available_Rooms='{2}' , Rent_Per_Room='{3}' where ID='{4}'", vchtl.hotelName, vchtl.roomType, vchtl.availableRooms, vchtl.rentPerRoom,vchtl.id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool delete(int id)
        {
            string query = string.Format("delete from Vacancies_Hotel where ID='{0}'",id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query,conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) return true;
            return false;

        }
        public List<VacancyHotel> getAllHotels()
        {
            string query = "select * from Vacancies_Hotel";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<VacancyHotel> data = new List<VacancyHotel>();
            while (reader.Read())
            {
                VacancyHotel vchtl = new VacancyHotel();
                vchtl.id = reader.GetInt32(reader.GetOrdinal("ID"));
                vchtl.hotelName = reader.GetString(reader.GetOrdinal("Hotel_Name"));
                vchtl.location = reader.GetString(reader.GetOrdinal("Location"));
                vchtl.roomType = reader.GetString(reader.GetOrdinal("Room_Type"));
                vchtl.availableRooms = reader.GetInt32(reader.GetOrdinal("Available_Rooms"));
                vchtl.rentPerRoom = reader.GetInt32(reader.GetOrdinal("Rent_Per_Room"));
                data.Add(vchtl);
            }
            conn.Close();
            return data;

        }
        public VacancyHotel search(int id) 
        {
            string query = string.Format("select * from Vacancies_Hotel where ID='{0}'",id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            VacancyHotel vchtl = null;
            while (reader.Read())
            {
                vchtl = new VacancyHotel();
                vchtl.id = reader.GetInt32(reader.GetOrdinal("ID"));
                vchtl.hotelName = reader.GetString(reader.GetOrdinal("Hotel_Name"));
                vchtl.location = reader.GetString(reader.GetOrdinal("Location"));
                vchtl.roomType = reader.GetString(reader.GetOrdinal("Room_Type"));
                vchtl.availableRooms = reader.GetInt32(reader.GetOrdinal("Available_Rooms"));
                vchtl.rentPerRoom = reader.GetInt32(reader.GetOrdinal("Rent_Per_Room"));     
            }
            conn.Close();
            return vchtl;

        }

        public bool checkManagerType(string username)
        {
            string query = string.Format("select Manager_Type from Managers where Username='{0}' ", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(string.Format("{0}",reader["Manager_Type"]) == "Hotel Manager")
                return true;
            }
            conn.Close();
            return false;
        }
    }
}
