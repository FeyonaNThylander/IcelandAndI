using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace IcelandAndI.Models.Blocks
{
    [ContentType(DisplayName = "ContactUsBlock", 
        GUID = "496e2b38-9bf3-43f5-b03f-723db3da46ab", 
        Description = "")]
    public class ContactUsBlock : BlockData
    {
        [CultureSpecific]
        public virtual string Address { get; set; }

        [CultureSpecific]
        public virtual string Telephone { get; set; }

        [CultureSpecific]
        public virtual string Email { get; set; }

        [CultureSpecific]
        public virtual string OurWebsite { get; set; }


    }
}