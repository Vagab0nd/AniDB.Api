namespace AniDb.Api.Models.Anime
{
    public record Ratings
    {
        public int PermanentCount { get; set; }

        public decimal PermanentValue { get; set; }

        public int TemporaryCount { get; set; }

        public decimal TemporaryValue { get; set; }

        public int ReviewCount { get; set; }

        public decimal ReviewValue { get; set; }
    }




}
