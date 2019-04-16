using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace IcelandAndI.Models.Blocks
{
    [ContentType(DisplayName = "Event Block", 
        GUID = "70051c43-1c18-4c6b-b2e0-678ab7a03927", 
        Description = "")]
    public class EventBlock : BlockData
    {
        public virtual string EventName { get; set; }
        public virtual string EventLocation { get; set; }
        public virtual DateTime EventDateTime { get; set; }


    }
}