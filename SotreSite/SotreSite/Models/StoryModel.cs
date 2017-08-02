using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StorySite.Data;

namespace SotreSite.Models
{
    public class StoryModel : IStoryModel
    {
        private IStorySiteUnitOfWork unitOfWork;
        public StoryModel(IStorySiteUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Story CreateStory(string title, string body)
        {
            var story = new Story();
            story.ID = Guid.NewGuid();
            story.CreatedOn = DateTime.Now;
            story.Active = true;
            story.Rating = new StorySite.Library.Rating();
            story.Title = "hello";

            unitOfWork.StoryRepository.Insert(story);
            unitOfWork.Save();

            return story;
        }

        public IEnumerable<Story> GetStories()
        {
            return unitOfWork.StoryRepository.Get();
        }

        public Story GetStory(Guid id)
        {
            return unitOfWork.StoryRepository.GetByID(id);
        }

        public void DeleteStory(Guid id)
        {
            unitOfWork.StoryRepository.Delete(id);
            unitOfWork.Save();
        }

        public void UpdateStory(Guid id, string title, string body)
        {
            var story = unitOfWork.StoryRepository.GetByID(id);
            story.Title = title;
            story.StoryBody = body;
            unitOfWork.Save();
        }
    }
}