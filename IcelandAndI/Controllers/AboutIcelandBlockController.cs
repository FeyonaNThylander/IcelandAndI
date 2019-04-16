using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using IcelandAndI.Models.Blocks;

namespace IcelandAndI.Controllers
{
    public class AboutIcelandBlockController : BlockController<AboutIcelandBlock>
    {
        public override ActionResult Index(AboutIcelandBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
