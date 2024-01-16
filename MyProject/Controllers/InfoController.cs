using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class InfoController : Controller
    {
        private static List<Info> PersonInfos = new List<Info>()
        {
            new Info()
            {
                Id = 1,
                Name = "Ramin"
            },

            new Info()
            {
                Id = 2,
                Name = "Amir"
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            var db = new ApplicationDbContext();
            var data = db.infos.Where()
        }
    }
}
