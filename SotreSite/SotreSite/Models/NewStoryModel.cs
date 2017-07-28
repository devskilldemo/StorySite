using StorySite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotreSite.Models
{
    public class NewStoryModel : IStoryModel
    {
        private IStorySiteUnitOfWork unitOfWork;
        public NewStoryModel(IStorySiteUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void CreateStory(string title, string body)
        {
            //var comment = new Comment();
            //comment.ID = Guid.NewGuid();
            //comment.CommentText = "test comment";
            //comment.StoryID = new Guid("d6c71ba1-d29a-48a1-a7ac-3b3a110c7319");

            //var story = new Story();
            //story.ID = Guid.NewGuid();
            //story.CreatedOn = DateTime.Now;
            //story.Active = true;
            //story.Rating = 3;
            //story.Title = "hello";
            //story.Comments = new List<Comment>();
            //story.Comments.Add(comment);

            //unitOfWork.StoryRepository.Insert(story);

            //unitOfWork.CommentRepository.Insert(comment);

            User user = new User();
            user.Email = "jalal.exe@gmail.com";
            user.FullName = "Jalal Uddin";
            user.ID = Guid.NewGuid();
            user.IsActive = true;
            user.Password = "1234";
            unitOfWork.UserRepository.Insert(user);
            unitOfWork.Save();
        }
    }
}