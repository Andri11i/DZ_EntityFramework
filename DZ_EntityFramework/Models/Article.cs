using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_EntityFramework.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorID { get; set; }
        public int Rating { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }

}
