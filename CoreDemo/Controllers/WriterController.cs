﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    //[Authorize]
    public class WriterController : Controller
    {
        //[Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile() {

            return View();
        }
        //[Authorize]
        public IActionResult WriterMail() {


            return View();
        }
        [AllowAnonymous]
        public IActionResult Test() {


            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {


            return PartialView();


        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            //53.derste kaldım
            //Git Deneme
            //asd denem
            return PartialView();


        }
    }
}
