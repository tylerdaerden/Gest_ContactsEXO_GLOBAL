using Microsoft.AspNetCore.Mvc;





namespace GestContact_CQS.WebApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
