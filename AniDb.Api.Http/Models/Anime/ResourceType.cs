using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public enum ResourceType
    {
        [XmlEnum("11")]
        DotLain = 11,
        [XmlEnum("9")]
        Allcinema = 9,
        [XmlEnum("48")]
        AmazonPrimeVideo = 48,
        [XmlEnum("32")]
        AmazonVideo = 32,
        [XmlEnum("16")]
        Animemorial = 16,
        [XmlEnum("1")]
        AnimeNewsNetwork = 1,
        [XmlEnum("3")]
        AnimeNFO = 3,
        [XmlEnum("10")]
        Anison = 10,
        [XmlEnum("33")]
        BaiduBaike = 33,
        [XmlEnum("38")]
        Bangumi = 38,
        [XmlEnum("47")]
        BiliBili = 47,
        [XmlEnum("20")]
        ChineseWikipedia = 20,
        [XmlEnum("28")]
        Crunchyroll = 28,
        [XmlEnum("39")]
        Douban = 39,
        [XmlEnum("6")]
        EnglishWikipedia = 6,
        [XmlEnum("22")]
        Facebook = 22,
        [XmlEnum("45")]
        Funimation = 45,
        [XmlEnum("42")]
        HiDive = 42,
        [XmlEnum("43")]
        IMDB = 43,
        [XmlEnum("7")]
        JapaneseWikipedia = 7,
        [XmlEnum("19")]
        KoreanWikipedia = 19,
        [XmlEnum("15")]
        Marumegane = 15,
        [XmlEnum("31")]
        MediaArtDatabase = 31,
        [XmlEnum("2")]
        MyAnimeList = 2,
        [XmlEnum("41")]
        Netflix = 41,
        [XmlEnum("35")]
        OfficialBlog = 35,
        [XmlEnum("5")]
        OfficialEnglishWebsite = 5,
        [XmlEnum("34")]
        OfficialStream = 34,
        [XmlEnum("4")]
        OfficialWebsite = 4,
        [XmlEnum("46")]
        QQ = 46,
        [XmlEnum("8")]
        Syoboi = 8,
        [XmlEnum("44")]
        TMDB = 44,
        [XmlEnum("17")]
        TvAnimationMuseum = 17,
        [XmlEnum("23")]
        Twitter = 23,
        [XmlEnum("14")]
        VisualNovelDatabase = 14,
        [XmlEnum("26")]
        YouTube = 26,
    }
}