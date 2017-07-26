using StorySite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotreSite.Models
{
    public class NewStoryModel : IStoryModel
    {
        public void CreateStory(string title, string body)
        {
            var comment = new Comment();
            comment.ID = Guid.NewGuid();
            comment.CommentText = "test comment";

            var story = new Story();
            story.ID = Guid.NewGuid();
            story.CreatedOn = DateTime.Now;
            story.Active = true;
            story.Rating = 3;
            story.Title = "hello";
            story.Comments = new List<Comment>();
            story.Comments.Add(comment);

            StoryContext context = new StoryContext();
            context.Story.Add(story);


            context.SaveChanges();
        }
    }
}