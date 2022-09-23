using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
        public IActionResult Check(UserModel model)
        {
            if (model.Login == null || model.Password == null) 
            { 
                return RedirectToAction("Index"); 
            }
            foreach(var record in UserData.getData())
            {
                if (record.Login == model.Login && record.Password == model.Password)
                {
                    model.IsAdmin = record.IsAdmin;
                    model.IsLogged = true;
                    break;
                }
            }
            return View("Check",model);
        }
    }
}
