using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace IcelandAndI.Models.Pages
{
    [ContentType(DisplayName = "Article Page",
        GroupName = SiteGroupNames.Specialized,
        GUID = "ed22f5c4-4cc1-409f-a69f-184ad9d870c9",
        Description = "Use this for creating blog posts")]
    public class ArticlePage : StandardPage
    {

    }
}