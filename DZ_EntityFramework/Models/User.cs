using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_EntityFramework.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        
        public virtual ICollection<Rental> Rentals { get; set; }
    }

}
