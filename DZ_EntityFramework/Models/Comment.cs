using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_EntityFramework.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public int ArticleID { get; set; }
        public string UserName { get; set; }
        public virtual Article Article { get; set; }
    }

}
