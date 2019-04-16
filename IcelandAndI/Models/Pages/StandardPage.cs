using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace IcelandAndI.Models.Pages
{
    [ContentType(DisplayName = "Standard",
        GroupName = SiteGroupNames.Common,
        GUID = "53eb7e90-fae9-4ffd-b950-dcaa4713e4b5",
        Description = "Use this page type unless you need a more specialized one")]
    public class StandardPage : SitePageData
    {
        //[CultureSpecific]
        //[Display(Name = "Page Title",
        //            Description = "If the Heading is not set, the page falls back to showing the Name.",
        //            GroupName = SystemTabNames.Content, Order = 1)]
        //public virtual string PageTitle { get; set; }

      

        [CultureSpecific]
        [Display(Name = "Heading",
                    Description = "If the Heading is not set, the page falls back to showing the Name.",
                    GroupName = SystemTabNames.Content, Order = 3)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Main content area",
           Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
           GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea MainContentArea { get; set; }


    }
}