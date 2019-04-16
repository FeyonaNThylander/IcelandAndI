using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace IcelandAndI.Models.Media
{
    [ContentType(DisplayName = "Any File", 
        GUID = "5953e55e-4f0a-403e-9b74-792972b6f038", 
        Description = "Use this to upload any type of file.")]
    public class AnyFile : MediaData
    {
        /*
                [CultureSpecific]
                [Editable(true)]
                [Display(
                    Name = "Description",
                    Description = "Description field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Description { get; set; }
         */
    }
}