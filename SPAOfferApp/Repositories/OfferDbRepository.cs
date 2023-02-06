using Microsoft.EntityFrameworkCore;
using SPA_Offer_App.Interfaces;
using SPA_Offer_App.Models;

namespace SPA_Offer_App.Repositories;

public class OfferDbRepository : IOfferConnection
{
    private AppDbContext _context;
    
    public OfferDbRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<Offer> GetSingleOffer(int offerId)
    {
        var offer = await _context.Offers.FirstOrDefaultAsync(o=>o.OfferId==offerId);
        return offer;
    }

    public async Task AddOffer(Offer offer)
    {
        await _context.Offers.AddAsync(offer);
        await _context.SaveChangesAsync();
    }
}