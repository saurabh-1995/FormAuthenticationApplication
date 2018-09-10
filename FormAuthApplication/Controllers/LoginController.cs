using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormAuthApplication.DAL;
using FormAuthApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FormAuthApplication.Controllers
{
    
    public class LoginController : Controller
    {
        private DataBaseOperations dataBaseOperations = new DataBaseOperations();
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginDetailsModel loginDetailsModel)
        {
            List<LoginCredentials> userDetail = dataBaseOperations.GetCredentials();
            LoginCredentials user = userDetail.Where(x => x.UserID == loginDetailsModel.UserID && x.Password == loginDetailsModel.Password).FirstOrDefault();
            if(user!=null)
            {
                return RedirectToAction("Dashboard", "LoginCredentials", user);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Dashboard(LoginCredentials user)
        {
            if(user.UserID!=null)
            {
                return View(user);
            }
            return RedirectToAction("Index");
        }
    }
}