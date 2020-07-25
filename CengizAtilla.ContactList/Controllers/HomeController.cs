using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CengizAtilla.ContactList.Models;
using Microsoft.AspNetCore.Mvc;

namespace CengizAtilla.ContactList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult addNewContactRecord()
        {
            return View(new ContactCard() { });
        }
    }
}
