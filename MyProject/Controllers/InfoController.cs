using Business;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Controllers;

public class InfoController : Controller
{
    private IInfoService _infoService;
    public InfoController(IInfoService infoService)
    {
        _infoService = infoService;
    }

    [HttpGet]
    public IActionResult GetAll(string name)
    {
        var data = _infoService.GetAll();
        return View(data);
    }

    [HttpGet]
    public IActionResult GetById(int id)
    {
        var data = _infoService.GetById(id);
        return View(data);
    }
}
