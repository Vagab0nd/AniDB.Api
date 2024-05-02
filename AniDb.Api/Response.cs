namespace AniDb.Api
{
    public record Response<T> where T : class
    {
        public T? Data { get; init; }

        public int Problem { get; set; }
    }
}
