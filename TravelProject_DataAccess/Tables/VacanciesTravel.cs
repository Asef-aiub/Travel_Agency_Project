using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TravelProject_DataAccess.Entities;


namespace TravelProject_DataAccess.Tables
{
    public class VacanciesTravel
    {

        SqlConnection conn;
        public VacanciesTravel(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool insert(VacancyTravel vctvl)
        {
            string query = string.Format("insert into Vacancies_Travel values ('{0}','{1}','{2}','{3}','{4}')", vctvl.companyName, vctvl.route, vctvl.seatType, vctvl.availableSeats, vctvl.pricePerSeat);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public bool update(VacancyTravel vctvl)
        {
            string query = string.Format("Update Vacancies_Travel set Company_Name='{0}' , Route='{1}' , Available_Seats='{2}' , Price_Per_Seat='{3}' where ID='{4}'", vctvl.companyName, vctvl.route, vctvl.availableSeats, vctvl.pricePerSeat, vctvl.id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool delete(int id)
        {
            string query = string.Format("delete from Vacancies_Travel where ID='{0}'", id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) return true;
            return false;

        }
        public List<VacancyTravel> getAllTravels()
        {
            string query = "select * from Vacancies_Travel";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<VacancyTravel> data = new List<VacancyTravel>();
            while (reader.Read())
            {
                VacancyTravel vctvl = new VacancyTravel();
                vctvl.id = reader.GetInt32(reader.GetOrdinal("ID"));
                vctvl.companyName = reader.GetString(reader.GetOrdinal("Company_Name"));
                vctvl.route = reader.GetString(reader.GetOrdinal("Route"));
                vctvl.seatType = reader.GetString(reader.GetOrdinal("Seat_Type"));
                vctvl.availableSeats = reader.GetInt32(reader.GetOrdinal("Available_Seats"));
                vctvl.pricePerSeat = reader.GetInt32(reader.GetOrdinal("Price_Per_Seat"));
                data.Add(vctvl);
            }
            conn.Close();
            return data;

        }
        public VacancyTravel search(int id)
        {
            string query = string.Format("select * from Vacancies_Travel where ID='{0}'", id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            VacancyTravel vctvl = null;
            while (reader.Read())
            {
                vctvl = new VacancyTravel();
                vctvl.id = reader.GetInt32(reader.GetOrdinal("ID"));
                vctvl.companyName = reader.GetString(reader.GetOrdinal("Company_Name"));
                vctvl.route = reader.GetString(reader.GetOrdinal("Route"));
                vctvl.seatType = reader.GetString(reader.GetOrdinal("Seat_Type"));
                vctvl.availableSeats = reader.GetInt32(reader.GetOrdinal("Available_Seats"));
                vctvl.pricePerSeat = reader.GetInt32(reader.GetOrdinal("Price_Per_Seat"));
            }
            conn.Close();
            return vctvl;

        }

 
        
    }
}
