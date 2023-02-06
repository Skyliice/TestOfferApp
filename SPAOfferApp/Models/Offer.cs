using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace SPA_Offer_App.Models;

[XmlRoot(ElementName = "offer")]
public class Offer
{
    public int Id { get; set; }
    [XmlAttribute(AttributeName = "id")]
    public int OfferId { get; set; }
    [XmlElement(ElementName = "price")]
    public decimal Price { get; set; }
    [XmlElement(ElementName = "currencyId")]
    public string CurrencyId { get; set; }
    [XmlElement(ElementName = "categoryId")]
    public int CategoryId { get; set; }
    [XmlElement(ElementName = "picture")]
    public string ImageUrl { get; set; }
    [XmlElement(ElementName = "delivery")]
    public bool CanBeDelivered { get; set; }
    [XmlElement(ElementName = "artist")]
    public string Artist { get; set; }
    [XmlElement(ElementName = "title")]
    public string Title { get; set; }
    [XmlElement(ElementName = "year")]
    public string Year { get; set; }
    [XmlElement(ElementName = "media")]
    public string MediaType { get; set; }
    [XmlElement(ElementName = "description")]
    public string Description { get; set; }
}