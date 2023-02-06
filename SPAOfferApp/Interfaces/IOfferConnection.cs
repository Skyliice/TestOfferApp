using SPA_Offer_App.Models;

namespace SPA_Offer_App.Interfaces;

public interface IOfferConnection
{
    public Task<Offer> GetSingleOffer(int offerId);
    public Task AddOffer(Offer offer);
}