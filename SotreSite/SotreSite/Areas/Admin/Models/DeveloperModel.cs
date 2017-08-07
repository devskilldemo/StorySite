using StorySite.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace SotreSite.Areas.Admin.Models
{
    public class DeveloperModel
    {
        public Guid  ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Role { get; set; }
        public string PhotoUrl { get; set; }
        [Required]
        public HttpPostedFileBase PhotoFile { get; set; }
        public string FacebookID { get; set; }
        public string GitHubID { get; set; }
        public string StackoverflowID { get; set; }
        public string LinkedInID { get; set; }

        private IStorySiteUnitOfWork _unitOfWork;
        public DeveloperModel(IStorySiteUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DeveloperModel()
        {

        }

        internal void CreateDeveloper()
        {
            Random rand = new Random(DateTime.Now.Second);
            int key = rand.Next(1000, 9999);
            string filePath = HttpContext.Current.Server.MapPath("~/Upload");
            string fileName = Path.Combine(filePath, String.Format("{0}_{1}", key, PhotoFile.FileName));
            PhotoFile.SaveAs(fileName);

            _unitOfWork.DeveloperRepository.Insert(new Developer()
            {
                Name = this.Name,
                Role =  this.Role,
                FacebookID = this.FacebookID,
                GitHubID = this.GitHubID,
                LinkedInID = this.LinkedInID,
                StackoverflowID = this.StackoverflowID,
                PhotoUrl = string.Format("{0}/{1}_{2}", "/Upload", key, PhotoFile.FileName)
            });
            _unitOfWork.Save();

            HttpContext.Current.Session["Alert"] = "Developer Add Successful!";
        }

        internal void LoadData(Guid id)
        {
            var developer = _unitOfWork.DeveloperRepository.GetByID(id);
            if(developer != null)
            {
                this.ID = id;
                this.Name = developer.Name;
                this.Role = developer.Role;
                this.PhotoUrl = developer.PhotoUrl;
                this.StackoverflowID = developer.StackoverflowID;
                this.FacebookID = developer.FacebookID;
                this.GitHubID = developer.GitHubID;
                this.LinkedInID = developer.LinkedInID;
            }
        }

        internal void Edit()
        {
            var developer = _unitOfWork.DeveloperRepository.GetByID(ID);
            if (developer != null)
            {
                if (PhotoFile != null)
                {
                    File.Delete(HttpContext.Current.Server.MapPath(developer.PhotoUrl));

                    Random rand = new Random(DateTime.Now.Second);
                    int key = rand.Next(1000, 9999);
                    string filePath = HttpContext.Current.Server.MapPath("~/Upload");
                    string fileName = Path.Combine(filePath, String.Format("{0}_{1}", key, PhotoFile.FileName));
                    PhotoFile.SaveAs(fileName);
                    
                    developer.PhotoUrl = string.Format("{0}/{1}_{2}", "/Upload", key, PhotoFile.FileName);
                }

                developer.Name = this.Name;
                developer.Role = this.Role;
                developer.FacebookID = this.FacebookID;
                developer.GitHubID = this.GitHubID;
                developer.LinkedInID = this.LinkedInID;
                developer.StackoverflowID = this.StackoverflowID;

                _unitOfWork.Save();

                HttpContext.Current.Session["Alert"] = "Developer Update Successful!";
            }
        }

        internal bool Delete(Guid id)
        {
            try
            {
                var developer = _unitOfWork.DeveloperRepository.GetByID(id);
                File.Delete(HttpContext.Current.Server.MapPath(developer.PhotoUrl));

                _unitOfWork.DeveloperRepository.Delete(developer);
                _unitOfWork.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal void SetUnitOfWork(IStorySiteUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Developer> GetDevelopers()
        {
            return _unitOfWork.DeveloperRepository.Get().ToList();
        }
    }
}