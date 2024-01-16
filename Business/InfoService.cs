using Microsoft.EntityFrameworkCore;
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
    public async List<Info> GetAll()
    {
        var db = new ApplicationDbContext();
        var data = await db.infos.OrderBy(x => x.Name).ToListAsync();
        return data;
    }

    public async Info GetById(int id)
    {
        var db = new ApplicationDbContext();
        var data = await db.infos.Where(s => s.Id == id).ToListAsync();
        return data;
    }
}
