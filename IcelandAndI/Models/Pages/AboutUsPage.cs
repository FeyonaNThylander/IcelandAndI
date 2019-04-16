using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace IcelandAndI.Models.Pages
{
    [ContentType(DisplayName = "About Us", 
        GroupName = SiteGroupNames.Specialized,
        GUID = "2ef7278c-1208-4eda-8a85-4b9902be4e39", 
        Description = "")]
    public class AboutUsPage : StandardPage
    {

        [CultureSpecific]
        [Display(Name = "Content Block Area",
          Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
          GroupName = SystemTabNames.Content, Order = 70)]
        [AllowedTypes(typeof(BlockData))]
        public virtual ContentArea ContentBlockArea { get; set; }

        [CultureSpecific]
        [Display(Name = "Videos Title",
           Description = "",
           GroupName = SystemTabNames.Content, Order = 50)]
        public virtual string VideosTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Videos Text",
            Description = "",
            GroupName = SystemTabNames.Content, Order = 60)]
        public virtual XhtmlString VideosText { get; set; }

    }
}