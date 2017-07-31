using SotreSite.Models;
using StorySite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SotreSite.Api
{
    public class StoryApiController : ApiController
    {
        private IStoryModel model;
        public StoryApiController()
        {
            this.model = new StoryModel(new StorySiteUnitOfWork(new StorySiteContext()));
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            List<string> titles = new List<string>();
            var stories = model.GetStories().ToList();
            for(int i =0; i<stories.Count; i++)
            {
                titles.Add(stories[i].Title);
            }
            return titles;
        }

        // GET api/<controller>/5
        public string Get(Guid id)
        {
            return model.GetStory(id).Title;
        }

        // POST api/<controller>
        public void Post([FromBody]string title, [FromBody]string body)
        {
            model.CreateStory(title, body);
        }

        // PUT api/<controller>/5
        public void Put(Guid id, [FromBody]string title, [FromBody]string body)
        {
            model.UpdateStory(id, title, "");
        }

        // DELETE api/<controller>/5
        public void Delete(Guid id)
        {
            model.DeleteStory(id);
        }
    }
}