using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_EntityFramework.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }

}
