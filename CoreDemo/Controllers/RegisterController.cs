using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager vm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer w) {

            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(w);
            if (result.IsValid)
            {

                w.WriterAbout = "Deneme";
                w.WriterStatus = true;
                vm.WriterAdd(w);

                return RedirectToAction("Index", "Blog");
            }
            else {

                foreach (var item in result.Errors) {

                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                
                }
            }
            return View();
            
            //35.Derste Kaldım
        
        }


    }
}
