using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_EntityFramework.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public int HotelID { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }

}
