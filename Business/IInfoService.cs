using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Models;

namespace Business;

public interface IInfoService
{
    List<Info> GetAll();
    Info GetById(int id);
}
