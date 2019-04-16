using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace IcelandAndI.Models.Blocks
{
    [ContentType(DisplayName = "ActivitiesBlock",
        GroupName = SiteGroupNames.Block,
        GUID = "149995d2-70cb-4702-afe6-c55a0341ce8c",
        Description = "")]
    public class ActivitiesBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Name of the activity.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Main Body",
           Description = "Name of the activity.",
           GroupName = SystemTabNames.Content,
           Order = 2)]
        public virtual string MainBody { get; set; }

        [Display(Name = "Page image",
             GroupName = SystemTabNames.Content,
             Order = 3)]
        [UIHint(UIHint.Image)] // filters to only show images         
        public virtual ContentReference PageImage { get; set; }

        [Display(Name = "Page link",
           GroupName = SystemTabNames.Content,
           Order = 4)]
        [Required]
        public virtual Url BlockLink { get; set; }
    }
}