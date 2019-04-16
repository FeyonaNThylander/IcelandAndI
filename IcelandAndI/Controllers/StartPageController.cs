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
    public class StartPageController : PageControllerBase<StartPage>
    {

        public StartPageController(IContentLoader loader) : base(loader)
        { }


        public ActionResult Index(StartPage currentPage)
        {
            //var items = new List<BlockData>();

            //if (currentPage != null && currentPage.HeaderSlideBlockArea != null && currentPage.HeaderSlideBlockArea.Items.Any())
            //{
            //    foreach (var contentItem in currentPage.HeaderSlideBlockArea.Items)
            //    {
            //        //var item = loader.Get<BlockData>(contentItem.ContentLink);
            //        IContentData item;
            //        if (!loader.TryGet(contentItem.ContentLink, out item))
            //        {
            //            continue;
            //        }
            //        if (item is BlockData)
            //        {
            //            items.Add((BlockData)item);
            //        }

            //        return (items.ToList())
            //    }
            //}
            return View(CreatePageViewModel(currentPage));
        }
    }
}