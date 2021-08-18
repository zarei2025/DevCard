using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "طلایی"),
            new Service(2, "نقره ای"),
            new Service(3, "پلاتینی"),
            new Service(4, "الماسی"),
        };

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                model = new Contact()
                {
                    Services = new SelectList(_services, "Id", "Name")
                };
                ModelState.Clear();
                ViewBag.success = "نظر شما با موفقیت ارسال شد.باتشکر";
                return View(model);
            }

            model.Services = new SelectList(_services, "Id", "Name");
            ViewBag.error = "مشکلی رخ داده است دوباره تلاش کنید.";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}