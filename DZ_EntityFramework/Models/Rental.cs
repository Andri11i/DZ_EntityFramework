using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_EntityFramework.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int BookID { get; set; }
        public int UserID { get; set; }
     
        public virtual Book Book { get; set; }

        public virtual User User { get; set; }
    }

}
