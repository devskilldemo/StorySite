using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context)
            :base(context)
        {

        }
    }
}
