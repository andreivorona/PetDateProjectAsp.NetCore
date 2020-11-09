using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsDate.Controllers
{
    public class UserpageController : Controller
    {
        //[Authorize]
        public IActionResult Collection()
        {
            return this.View();
        }

        //[Authorize]
        public IActionResult CreateCard()
        {
            return this.View();
        }
    }
}
