using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context)
            :base(context)
        {

        }
    }
}
