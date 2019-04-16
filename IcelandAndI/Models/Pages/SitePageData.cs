using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace IcelandAndI.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [CultureSpecific]
        [Display(Name = "Meta title",
            GroupName = SiteTabNames.SEO,
            Order = 100)]
        [StringLength(60, MinimumLength = 5)]
        public virtual string MetaTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta keywords",
            GroupName = SiteTabNames.SEO,
            Order = 200)]
        public virtual string MetaKeywords { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta description",
            GroupName = SiteTabNames.SEO,
            Order = 300)]
        [UIHint(UIHint.Textarea)] // multi-row text editor         
        public virtual string MetaDescription { get; set; }

        [Display(Name = "Page image",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)] // filters to only show images         
        public virtual ContentReference PageImage { get; set; }

        [CultureSpecific]
        [Display(Name = "Introduction",
                  Description = "If the Heading is not set, the page falls back to showing the Name.",
                  GroupName = SystemTabNames.Content, Order = 2)]
        public virtual string Introduction { get; set; }

        [CultureSpecific]
        [Display(Name = "Page Title",
             Description = "If the Heading is not set, the page falls back to showing the Name.",
             GroupName = SystemTabNames.Content, Order = 1)]
        public virtual string PageTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Contact Block",
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SiteTabNames.SiteSettings, Order = 100)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea ContactBlockArea { get; set; }

        //[CultureSpecific]
        //[Display(Name = "Address Block",
        //    Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
        //    GroupName = SiteTabNames.SiteSettings, Order = 200)]
        //[AllowedTypes(typeof(BlockData))]
        //public virtual ContentArea AddressBlockArea { get; set; }

        [CultureSpecific]
        [Display(Name = "About Iceland Block",
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SiteTabNames.SiteSettings, Order = 300)]
        [AllowedTypes(typeof(BlockData))]
        public virtual ContentArea AboutIcelandBlockArea { get; set; }

        //[CultureSpecific]
        //[Display(Name = "Header Slider Block",
        //    Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
        //    GroupName = SiteTabNames.SiteSettings, Order = 300)]
        //[AllowedTypes(typeof(BlockData))]
        //public virtual ContentArea HeaderSlideBlockArea { get; set; }

        //[CultureSpecific]
        //[Display(Name = "Logo Block",
        //    Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
        //    GroupName = SiteTabNames.SiteSettings, Order = 300)]
        //[AllowedTypes(typeof(BlockData))]
        //public virtual ContentArea LogoBlockArea { get; set; }

    }
}