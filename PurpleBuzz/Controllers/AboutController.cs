using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.About;

namespace PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var ours = new List<Our>
             {
                 new Our {Id = 1, Title="Our Vision" , Description="Vision desc", PhotoPath="bxs-bulb"},
                 new Our {Id = 2, Title="Our Mission" , Description="Mission desc", PhotoPath="bx-revision"},
                 new Our {Id = 3, Title="Our Goal" , Description="Goal desc", PhotoPath="bxs-select-multiple"}
             };

            ViewBag.WorksTitle = "bx-revision";

            var model = new AboutIndexVM
            {
                Ours = ours
            };
            return View(model);
        }
    }
}
