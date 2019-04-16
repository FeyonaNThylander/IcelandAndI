using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace IcelandAndI.Models.Pages
{
    [ContentType(DisplayName = "Activities Archive",
        GUID = "99e06008-abdd-4664-b553-4eb87c9798f9",
        GroupName = SiteGroupNames.Specialized,
        Description = "Landing page for the Activities archive")]
    public class ActivitiesArchivePage : StandardPage
    {
        [CultureSpecific]
        [Display(Name = "Activities Main content area",
           Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
           GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(BlockData))]
        public virtual ContentArea ActivitiesMainContentArea { get; set; }

    }
}