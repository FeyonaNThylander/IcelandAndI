using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace IcelandAndI.Models.Blocks
{
    [ContentType(DisplayName = "Facts Block",
        GroupName = SiteGroupNames.Block,
        GUID = "f9a645a6-232c-4ecd-b1e1-7729eba83092",
        Description = "")]
    public class FactsBlock : BlockData
    {
        [CultureSpecific]
        public virtual string HighestPeakText { get; set; }
        public virtual string HighestPeakNumber { get; set; }

        [CultureSpecific]
        public virtual string AreaText { get; set; }
        public virtual string AreaNumber { get; set; }

        [CultureSpecific]
        public virtual string PopulationText { get; set; }
        public virtual string PopulationNumber { get; set; }



    }
}