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
        private FileAccessor _fileAccessor = new FileAccessor();

        public ActionResult Index()
        {
            RenderMarkdownContent("Home");

            return View();
        }

        [Route("Articles/{articleShortName}")]
        public ActionResult Articles(string articleShortName)
        {
            RenderMarkdownContent(articleShortName);

            return View("~/Views/Home/Index.cshtml");
        }

        private void RenderMarkdownContent(string articleShortName)
        {
            string filePath = Server.MapPath(Url.Content($"~/Content/{articleShortName}.md"));

            string content = _fileAccessor.Access(filePath);

            ViewBag.Content = Markdown.ToHtml(content);
        }
    }
}