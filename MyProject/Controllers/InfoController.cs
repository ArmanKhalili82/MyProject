using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class InfoController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var db = new ApplicationDbContext();
            ViewBag.Data = db.infos.OrderBy(x => x.Name).ToList();
            return View(ViewBag.Data);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Info model)
        {
            var db = new ApplicationDbContext();
            Random random = new Random();
            int id = random.Next(3, 100);
            model.Id = id;
            db.infos.Add(model);
            return Ok();
        }
    }
}
