using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using IcelandAndI.Models.Pages;

namespace IcelandAndI.Controllers
{
    public class ArticlePageController : PageControllerBase<ArticlePage>
    {
        public ArticlePageController(IContentLoader loader) : base(loader)
        { }

        public ActionResult Index(ArticlePage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}