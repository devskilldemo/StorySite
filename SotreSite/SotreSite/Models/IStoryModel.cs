using StorySite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotreSite.Models
{
    public interface IStoryModel
    {
        Story CreateStory(string title, string body);
        IEnumerable<Story> GetStories();
        Story GetStory(Guid id);
        void DeleteStory(Guid id);
        void UpdateStory(Guid id, string title, string body);
    }
}
