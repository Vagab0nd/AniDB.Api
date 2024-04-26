using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{
    public class Recommendation
    {
        [XmlElement("anime")]
        public AnimeRecommendation Anime { get; set; }  = new AnimeRecommendation();
    }
}
