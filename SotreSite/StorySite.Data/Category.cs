using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Serial { get; set; }
    }
}
