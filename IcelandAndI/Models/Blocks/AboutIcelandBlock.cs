using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace IcelandAndI.Models.Blocks
{
    [ContentType(DisplayName = "AboutIcelandBlock", 
        GUID = "b6f991c9-9344-4ecc-8648-5bcaaa465c98", 
        Description = "")]
    public class AboutIcelandBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Tile",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}