using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Foundation.Infrastructure;
using Foundation.Features.Shared;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.Web;
using System;

namespace Foundation.Features.Blocks.KOtherBlock
{
    [ContentType(DisplayName = "Karins Other Block", // Blockets namn
           GUID = "26f721fe-33dd-4bf6-8c6a-184cb19f33ca", // Måste vara unik
           Description = "DateTime picker block",  // Beskrivning av blocket
           GroupName = GroupNames.Content)] // -- 
    [ImageUrl("/icons/cms/blocks/CMS-icon-block-22.png")] // Bilden/ Ikonen för blocket
    public class KOtherBlock : FoundationBlockData
    {
        [CultureSpecific]
        [Display(Name = "MyDateTime", Order = 10)] // Bra att sätta order i 10 intervaller om man vill lägga in mer senare.
        public virtual System.DateTime MyDateTime { get; set; } // Datum

        [Display(Name = "MyBoolean", Order = 20)]
        public virtual bool MyBoolean { get; set; }
    }
}
