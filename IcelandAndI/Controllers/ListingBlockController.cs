using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using IcelandAndI.Models.Blocks;
using IcelandAndI.Models.ViewModels;

namespace IcelandAndI.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        private readonly IContentLoader loader;

        public ListingBlockController(IContentLoader loader)
        {
            this.loader = loader;
        }

        public override ActionResult Index(ListingBlock currentBlock)
        {
            var viewmodel = new ListingBlockViewModel
            {
                Heading = currentBlock.Heading
            };

            if (currentBlock.ShowChildrenOfThisPage != null)
            {
                IEnumerable<PageData> children = loader.GetChildren<PageData>(currentBlock.ShowChildrenOfThisPage);

                IEnumerable<IContent> filteredChildren = 
                    FilterForVisitor.Filter(children);

                viewmodel.Pages = filteredChildren.Cast<PageData>().Where(page => page.VisibleInMenu);
            }

                return PartialView(viewmodel);
        }
    }
}
