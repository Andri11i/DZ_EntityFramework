using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_EntityFramework.Models
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Stars { get; set; }


        public virtual ICollection<Room> Rooms { get; set; }
    }

}
