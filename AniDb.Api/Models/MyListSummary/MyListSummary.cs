using System.Xml.Serialization;

namespace AniDb.Api.Models.MyListSummary
{
    [XmlRoot(ElementName = "mylistsummary")]
    public record MyListSummary
    {
        [XmlAttribute(AttributeName = "uid")]
        public int UserId { get; set; }

        [XmlElement("mylistitem")]
        public MyListItem[] MyListItems { get; set; }
    }
}