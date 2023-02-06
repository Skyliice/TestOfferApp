using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SPA_Offer_App.Models;
using SPA_Offer_App.Services;

namespace SPA_Offer_App.Controllers;

public class HomeController : Controller
{
    private OfferService _service;
    
    public HomeController(OfferService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var xml = new DeserializeService();
        var off = xml.DeserializeOffer("12344");
        await _service.AddOffer(off);
        var finalOffer = await _service.GetSingleOffer(off.OfferId);
        ViewData.Model = finalOffer;
        return  View();
    }
}