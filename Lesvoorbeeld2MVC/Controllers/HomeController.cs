using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lesvoorbeeld2MVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string name)
        {
            return $"Hallo {name}";
        }
    }
}