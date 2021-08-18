using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class Test:Controller
    {
        public FileResult Index()
        {
            var fileB = System.IO.File.ReadAllBytes("wwwroot/TextFile.txt");
            const string filename = "file.txt";
            return File(fileB, MediaTypeNames.Text.Plain, filename);
        }
    }
}
