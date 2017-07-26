using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class Comment
    {
        public Guid ID { get; set; }
        public string CommentText { get; set; }
    }
}
