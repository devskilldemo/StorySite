using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class Contact : Entity
    {
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}
