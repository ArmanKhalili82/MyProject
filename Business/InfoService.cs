using MyProject.Data;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public class InfoService : IInfoService
{
    public List<Info> GetAll()
    {
        var db = new ApplicationDbContext();
        var data = db.infos.OrderBy(x => x.Name).ToList();
        return data;
    }

    public Info GetById(int id)
    {
        var db = new ApplicationDbContext();
        var data = db.infos.Where(s => s.Id == id).FirstOrDefault();
        return data;
    }
}
