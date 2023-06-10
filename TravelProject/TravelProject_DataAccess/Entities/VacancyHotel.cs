using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelProject_DataAccess.Entities
{
    public class VacancyHotel
    {
        public int id { get; set; }
        public string hotelName { get; set; }
        public string location { get; set; }
        public string roomType { get; set; }
        public int availableRooms { get; set; }
        public int rentPerRoom { get; set; }

    }
}
