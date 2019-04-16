using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using IcelandAndI.Business.ExtensionMethods;
using IcelandAndI.Models.Pages;
using IcelandAndI.Models.ViewModels;

namespace IcelandAndI.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        protected readonly IContentLoader loader;

        public PageControllerBase(IContentLoader loader)
        {
            this.loader = loader;
        }


        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(TPage currentPage) where TPage : SitePageData
        {

            var viewmodel = PageViewModel.Create(currentPage);

            viewmodel.StartPage = loader.Get<StartPage>(ContentReference.StartPage);

            viewmodel.MenuPages = FilterForVisitor.Filter(loader.GetChildren<SitePageData>(ContentReference.StartPage)).Cast<SitePageData>().Where(page => page.VisibleInMenu).ToList();

            viewmodel.Section = currentPage.ContentLink.GetSection();


            var pages = new List<SitePageData>();
            pages.Add(viewmodel.StartPage);
            pages.AddRange(loader.GetChildren<SitePageData>(ContentReference.StartPage));

            var FilteredListOnPages = FilterForVisitor.Filter(pages).Cast<SitePageData>().Where(page => page.VisibleInMenu == true).ToList();
            
            viewmodel.MenuPages = FilteredListOnPages;

            return viewmodel;
        }
    }
}