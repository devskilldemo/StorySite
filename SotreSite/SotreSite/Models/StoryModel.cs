using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StorySite.Data;

namespace SotreSite.Models
{
    public class StoryModel : IStoryModel
    {
        public void CreateStory(string title, string body)
        {
            
        }

        public IEnumerable<Story> GetStories()
        {
            throw new NotImplementedException();
        }
    }
}