using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace IcelandAndI.Models.Blocks
{
    [ContentType(DisplayName = "Listing", 
        GroupName = SiteGroupNames.Common,
        GUID = "81ccef8d-7934-4b17-b4ff-445d40feb13d", 
        Description = "Choose a page in the tree, and its children will be listed, with a heading.")]
    //[SiteBlockIcon]
    public class ListingBlock : BlockData
    {
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }

        [Display(Name = "Show children of this page", Order = 20)]
        public virtual PageReference ShowChildrenOfThisPage { get; set; }
    }
}