using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace IcelandAndI.Models.Pages
{
    [ContentType(DisplayName = "Start", 
        GUID = "de046ffb-2860-47ed-94e5-1cb6f90d8c7c", 
        Description = "The home page for a website with an area for blocks and partial pages")]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Heading",
            Description = "",
            GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Highlight Title",
          Description = "",
          GroupName = SystemTabNames.Content, Order = 21)]
        public virtual string HighlightTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Activity Highlight Title",
          Description = "",
          GroupName = SystemTabNames.Content, Order = 22)]
        public virtual string ActivityHighlightTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Activity Highlight Text",
            Description = "",
            GroupName = SystemTabNames.Content, Order = 23)]
        public virtual XhtmlString ActivityHighlightText { get; set; }

        [CultureSpecific]
        [Display(Name = "Recent Activities Title",
            Description = "",
            GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string RecentActivitiesTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Recent Activities Text",
            Description = "",
            GroupName = SystemTabNames.Content, Order = 40)]
        public virtual XhtmlString RecentActivitiesText { get; set; }

        [CultureSpecific]
        [Display(Name = "Content Block Area",
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SystemTabNames.Content, Order = 70)]
        [AllowedTypes(typeof(BlockData))]
        public virtual ContentArea ContentBlockArea { get; set; }

        [CultureSpecific]
        [Display(Name = "Listing Content Area", 
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.", 
            GroupName = SystemTabNames.Content, Order = 70)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea ListingContentArea { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer text",
            Description = "The footer text will be shown at the bottom of every page.",
            GroupName = SiteTabNames.SiteSettings, Order = 80)]
        public virtual string FooterText { get; set; }

        //LOGOTEXT
        [CultureSpecific]
        [Display(Name = "Logo text 1",
           Description = "Text for logo",
           GroupName = SystemTabNames.Content, Order = 2000)]
        public virtual string LogoTextOne { get; set; }

        [CultureSpecific]
        [Display(Name = "Logo text 2",
           Description = "Text for logo",
           GroupName = SystemTabNames.Content, Order = 2001)]
        public virtual string LogoTextTwo { get; set; }

        [CultureSpecific]
        [Display(Name = "Logo text 3",
           Description = "Text for logo",
           GroupName = SystemTabNames.Content, Order = 2002)]
        public virtual string LogoTextThree { get; set; }


        //SLIDER

        //1
        [Display(Name = "Slider One Image",
            GroupName = SystemTabNames.Content, Order = 1000)]
        [UIHint(UIHint.Image)] // filters to only show images         
        public virtual ContentReference SliderOneImage { get; set; }

        [CultureSpecific]
        [Display(Name = "Slider One Number",
                 Description = "",
                 GroupName = SystemTabNames.Content, Order = 1001)]
        public virtual string SliderOneNumber { get; set; }

        [CultureSpecific]
        [Display(Name = "Slider One Header",
                  Description = "",
                  GroupName = SystemTabNames.Content, Order = 1002)]
        public virtual string SliderOneHeader { get; set; }

        [CultureSpecific]
        [Display(Name = "Slider One Mainbody",
                Description = "",
                GroupName = SystemTabNames.Content, Order = 1003)]
        public virtual XhtmlString SliderOneMainbody { get; set; }

        //2
        [Display(Name = "Slider Two Image",
            GroupName = SystemTabNames.Content, Order = 1004)]
        [UIHint(UIHint.Image)] // filters to only show images         
        public virtual ContentReference SliderTwoImage { get; set; }

        [CultureSpecific]
        [Display(Name = "Slider Two Number",
                 Description = "",
                 GroupName = SystemTabNames.Content, Order = 1005)]
        public virtual string SliderTwoNumber { get; set; }

        [CultureSpecific]
        [Display(Name = "Slider Two Header",
                  Description = "",
                  GroupName = SystemTabNames.Content, Order = 1006)]
        public virtual string SliderTwoHeader { get; set; }

        [CultureSpecific]
        [Display(Name = "Slider Two Mainbody",
                Description = "",
                GroupName = SystemTabNames.Content, Order = 1007)]
        public virtual XhtmlString SliderTwoMainbody { get; set; }

        //3
        [Display(Name = "Slider Three Image",
            GroupName = SystemTabNames.Content, Order = 1008)]
        [UIHint(UIHint.Image)] // filters to only show images         
        public virtual ContentReference SliderThreeImage { get; set; }

        [CultureSpecific]
        [Display(Name = "Slider Three Number",
                 Description = "",
                 GroupName = SystemTabNames.Content, Order = 1009)]
        public virtual string SliderThreeNumber { get; set; }

        [CultureSpecific]
        [Display(Name = "Slider Three Header",
                  Description = "",
                  GroupName = SystemTabNames.Content, Order = 1010)]
        public virtual string SliderThreeHeader { get; set; }

        [CultureSpecific]
        [Display(Name = "Slider Three Mainbody",
                Description = "",
                GroupName = SystemTabNames.Content, Order = 1011)]
        public virtual XhtmlString SliderThreeMainbody { get; set; }

    }
}