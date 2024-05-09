namespace AniDb.Api.Infrastracture
{
    internal class RateLimitingHandler(TimeSpan rateLimitInterval, int maxRequestsPerInterval) : DelegatingHandler
    {
        private readonly SemaphoreSlim semaphore = new(maxRequestsPerInterval, maxRequestsPerInterval);
        private readonly TimeSpan rateLimitInterval = rateLimitInterval;
        private readonly int maxRequestsPerInterval = maxRequestsPerInterval;
        private readonly Queue<DateTime> requestTimestamps = new();

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            await this.EnforceRateLimit();
            var response = await base.SendAsync(request, cancellationToken);
            this.requestTimestamps.Enqueue(DateTime.UtcNow);

            return response;
        }

        private async Task EnforceRateLimit()
        {
            await this.semaphore.WaitAsync();

            try
            {
                while (this.requestTimestamps.Count > 0 && DateTime.UtcNow - this.requestTimestamps.Peek() > this.rateLimitInterval)
                {
                    this.requestTimestamps.Dequeue();
                }

                if (this.requestTimestamps.Count >= this.maxRequestsPerInterval)
                {
                    var delay = this.rateLimitInterval - (DateTime.UtcNow - this.requestTimestamps.Peek());
                    await Task.Delay(delay);
                }
            }
            finally
            {
                this.semaphore.Release();
            }
        }
    }
}
