using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Foundation.Infrastructure;
using Foundation.Features.Shared;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.Web;

namespace Foundation.Features.Blocks.KNumberBlock
{
    [ContentType(DisplayName = "Karins Number Block", // Blockets namn
            GUID = "bef2d934-4980-4f97-b85f-83231e9376d4", // Måste vara unik
            Description = "Number block",  // Beskrivning av blocket
            GroupName = GroupNames.Content)] // -- 
    [ImageUrl("/icons/cms/blocks/CMS-icon-block-22.png")] // Bilden/ Ikonen för blocket

    public class KNumberBlock : FoundationBlockData
    {
        [Display(Name = "NumberINT", Order = 10)] // Bra att sätta order i 10 intervaller om man vill lägga in mer senare.
        public virtual int NumberINT { get; set; } // String = ingen text redigering

        [Display(Name = "NumberDouble", Order = 20)] // Bra att sätta order i 10 intervaller om man vill lägga in mer senare.
        public virtual double NumberDouble { get; set; } // String = ingen text redigering
    }
}
