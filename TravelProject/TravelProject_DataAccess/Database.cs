using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelProject_DataAccess.Tables;
using System.Data.SqlClient;

namespace TravelProject_DataAccess
{
    public class Database
    {
        public Managers Managers { get; set; }
        public VacanciesHotel VacanciesHotel { get; set; }
        public VacanciesTravel VacanciesTravel { get; set; }

        public Database()
        {
            string connStr = @"Server=ASEF\SQLEXPRESS;Database=TravelDatabase;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connStr);
            Managers = new Managers(conn);
            VacanciesHotel = new VacanciesHotel(conn);
            VacanciesTravel = new VacanciesTravel(conn);

        }
    }
}
