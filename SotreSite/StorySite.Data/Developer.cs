using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class Developer : Entity
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Role { get; set; }
        public string FacebookID { get; set; }
        public string GitHubID { get; set; }
        public string StackoverflowID { get; set; }
        public string LinkedInID { get; set; }
    }
}
