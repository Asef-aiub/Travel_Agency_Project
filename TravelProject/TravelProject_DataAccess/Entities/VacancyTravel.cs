using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelProject_DataAccess.Entities
{
    public class VacancyTravel
    {
        public int id { get; set; }
        public string companyName { get; set; }
        public string route { get; set; }
        public string seatType { get; set; }
        public int availableSeats { get; set; }
        public int pricePerSeat { get; set; }
    }
}
