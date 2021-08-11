using Markdig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrovoWebsite.Models;

namespace TrovoWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string filePath = Server.MapPath(Url.Content("~/Content/Home.md"));

            FileAccessor fileAccessor = new FileAccessor();

            string content = fileAccessor.Access(filePath);
            
            ViewBag.Content = Markdown.ToHtml(content);
            
            return View();
        }
    }
}