using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Foundation.Infrastructure;
using Foundation.Features.Shared;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.Web;

namespace Foundation.Features.Blocks.KTextBlock
{
    [ContentType(DisplayName = "Karins Text Block", // Blockets namn
            GUID = "2fab2d60-ca0d-4cec-b410-a33dcabb11f8", // Måste vara unik
            Description = "Text block",  // Beskrivning av blocket
            GroupName = GroupNames.Content)] // -- 
    [ImageUrl("/icons/cms/blocks/CMS-icon-block-22.png")] // Bilden/ Ikonen för blocket
    public class KTextBlock : FoundationBlockData
    {
        [CultureSpecific] // Viktig om man har text på tex Svenska OCH Engelska
        [Display(Name = "Text", Order = 10)] // Bra att sätta order i 10 intervaller om man vill lägga in mer senare.
        public virtual XhtmlString Text { get; set; } // XhtmlString Som word, med redigering

        [CultureSpecific] // Viktig om man har text på tex Svenska OCH Engelska
        [Display(Name = "Text2", Order = 20)] // Bra att sätta order i 10 intervaller om man vill lägga in mer senare.
        public virtual string Text2 { get; set; } // String = ingen text redigering

        [UIHint(UIHint.Textarea)]
        [CultureSpecific] // Viktig om man har text på tex Svenska OCH Engelska
        [StringLength(15, ErrorMessage = "DIN RÖV")]
        [Display(Name = "Text3", Order = 30)] // Bra att sätta order i 10 intervaller om man vill lägga in mer senare.
        public virtual string Text3 { get; set; } // String = ingen text redigering

        // Johan på sista.


    }
}
