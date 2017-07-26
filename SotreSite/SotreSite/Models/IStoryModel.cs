using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotreSite.Models
{
    public interface IStoryModel
    {
        void CreateStory(string title, string body);
    }
}
