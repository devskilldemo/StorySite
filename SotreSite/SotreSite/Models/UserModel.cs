using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SotreSite.Models;
using System.Collections.Generic;

namespace SotreSite.Models
{
    public class UserModel
    {
        private ApplicationUserManager applicationUserManager;
        
        public UserModel(ApplicationUserManager applicationUserManager)
        {
            this.applicationUserManager = applicationUserManager;
        }

        public List<ApplicationUser> GetUsers()
        {
            return applicationUserManager.Users.ToList();
        }
    }
}