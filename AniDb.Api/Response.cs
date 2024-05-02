namespace AniDb.Api
{
    public record Response<T> where T : class
    {
        public T? Data { get; init; }

        public string? ErrorMessage { get; init; }
    }
}
