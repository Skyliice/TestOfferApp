namespace SPA_Offer_App.Models;

public class OfferDTO
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public string CanBeDelivered { get; set; }
    public string Artist { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string MediaType { get; set; }
    public string Description { get; set; }
}