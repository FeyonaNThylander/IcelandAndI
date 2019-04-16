using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace IcelandAndI.Models.Blocks
{
    [ContentType(DisplayName = "About Us Block", GUID = "10fce1a3-5a47-43d2-83b5-d620038802c5", Description = "")]
    public class AboutUsBlock : BlockData
    {
        [CultureSpecific]
        [Display(
             Name = "Title",
             Description = "Topic",
             GroupName = SystemTabNames.Content,
             Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Main Body",
           Description = "Text about the topic",
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