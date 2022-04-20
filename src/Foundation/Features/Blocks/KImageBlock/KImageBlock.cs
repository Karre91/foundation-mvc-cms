using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Foundation.Infrastructure;
using Foundation.Features.Shared;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.Web;

namespace Foundation.Features.Blocks.KImageBlock
{
    [ContentType(DisplayName = "Karins Image Block", // Blockets namn
            GUID = "f30baca0-86f9-4007-b9a0-404dd28d6885", // Måste vara unik
            Description = "Image block with overlay for text",  // Beskrivning av blocket
            GroupName = GroupNames.Content)] // -- 
    [ImageUrl("/icons/cms/blocks/CMS-icon-block-22.png")] // Bilden/ Ikonen för blocket

    public class KImageBlock : FoundationBlockData
    {
        [UIHint(UIHint.Image)]
        [Display(Name = "Image", Order = 10)]
        public virtual ContentReference Image { get; set; } // to link to a single content of a specified type

        [UIHint(UIHint.Video)]
        [Display(Name = "Video", Order = 20)]
        public virtual ContentReference Video { get; set; } // to link to a single content of a specified type

    }
}
