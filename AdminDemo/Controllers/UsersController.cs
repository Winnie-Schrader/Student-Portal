using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminDemo.Data;
using AdminDemo.Models;
using AdminDemo.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminDemo.Controllers
{
    
    public class UsersController : Controller
    {
        private readonly IUserRepository _context;

        public UsersController(IUserRepository context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(UsersModel users)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        UsersModel newusers = _context.Add(users);
        //        return RedirectToAction(nameof(Index));

        //    }
        //    return View();


        //}
    }
}

      

