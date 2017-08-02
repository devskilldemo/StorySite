using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Library
{
    public class Rating
    {
        public double CurrentRating { get; private set; }
        public int TotalUpVote { get; private set; }
        public int TotalDownVote { get; private set; }

        public void UpVote()
        {
            TotalUpVote++;
            CalculateRating();
        }

        public void DownVote()
        {
            TotalDownVote++;
            CalculateRating();
        }

        private void CalculateRating()
        {
            CurrentRating = (double)TotalUpVote / TotalDownVote;
        }
    }
}
