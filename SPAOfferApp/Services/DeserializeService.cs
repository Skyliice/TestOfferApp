using System.Text;
using System.Xml;
using System.Xml.Serialization;
using SPA_Offer_App.Models;

namespace SPA_Offer_App.Services;

public class DeserializeService
{
    private string url = "https://yastatic.net/market-export/_/partner/help/YML.xml";
    public Offer DeserializeOffer(string offerId)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var settings = new XmlReaderSettings();
        settings.DtdProcessing = DtdProcessing.Parse;
        var xmlDocument = XmlReader.Create(url,settings);
        do
        {
            xmlDocument.ReadToFollowing("offer");
            xmlDocument.MoveToFirstAttribute();
        } while (xmlDocument.Value!=offerId);

        var serializer = new XmlSerializer(typeof(Offer));
        var offer = (Offer)serializer.Deserialize(xmlDocument);
        xmlDocument.Close();
        return offer;
    }
}