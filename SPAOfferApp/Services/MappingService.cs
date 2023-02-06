using SPA_Offer_App.Models;

namespace SPA_Offer_App.Services;

public static class MappingService
{
    public static OfferDTO MapToDTO(this Offer? offer)
    {
        if (offer == null)
            return null;
        OfferDTO offerDto = new()
        {
            Id = offer.OfferId,
            Artist = offer.Artist,
            CanBeDelivered = offer.CanBeDelivered ? "Yes" : "No",
            Description = offer.Description,
            ImageUrl = offer.ImageUrl,
            MediaType = offer.MediaType,
            Price = offer.Price,
            Title = offer.Title,
            Year = offer.Year
        };
        return offerDto;
    }
}