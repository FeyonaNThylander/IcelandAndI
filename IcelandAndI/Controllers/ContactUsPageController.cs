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
    public class ContactUsPageController : PageControllerBase<ContactUsPage>
    {
        public ContactUsPageController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(ContactUsPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}