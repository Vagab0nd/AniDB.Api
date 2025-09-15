using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record EpisodeNumber
    {
        [XmlAttribute("type")]
        public EpisodeType Type { get; init; }

        /// <summary>
        /// Episode number value with format depending on episode type.
        /// </summary>
        [XmlText]
        public string Value { get; init; } = string.Empty;
    }
}