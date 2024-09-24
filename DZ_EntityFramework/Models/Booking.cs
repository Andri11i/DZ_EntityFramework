using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_EntityFramework.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoomID { get; set; }
        public string UserName { get; set; }
        public virtual Room Room { get; set; }
    }

}
