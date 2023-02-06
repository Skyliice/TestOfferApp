using Microsoft.Identity.Client;
using SPA_Offer_App.Interfaces;
using SPA_Offer_App.Models;

namespace SPA_Offer_App.Services;

public class OfferService
{
    private IOfferConnection _context;

    public OfferService(IOfferConnection context)
    {
        _context = context;
    }

    public async Task<OfferDTO> GetSingleOffer(int offerId)
    {
        var offer = await _context.GetSingleOffer(offerId);
        var answer = MappingService.MapToDTO(offer);
        return answer;
    }

    public async Task AddOffer(Offer offer)
    {
        var off = await GetSingleOffer(offer.OfferId);
        if (off == null)
        {
            await _context.AddOffer(offer);
        }
    }
}