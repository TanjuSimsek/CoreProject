using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotificaiton:ViewComponent
    {

        public IViewComponentResult Invoke() {



            return View();
        }

    }
}
