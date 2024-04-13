using Flurl.Http;
using System.IO.Compression;

namespace AniDb.Api.Infrastracture
{
    public static class FlurlResponseExtensions
    {
        public static async Task<IFlurlResponse> UnpackGzip(this Task<IFlurlResponse> responseTask)
        {
            var response = await responseTask;
            var responseStream = await response.GetStreamAsync();
            var memoryStream = new MemoryStream();
            using (var gzipStream = new GZipStream(responseStream, CompressionMode.Decompress))
            {
                await gzipStream.CopyToAsync(memoryStream);
            }
            memoryStream.Seek(0, SeekOrigin.Begin);
            response.ResponseMessage.Content = new StreamContent(memoryStream);
            response.ResponseMessage.Content.Headers.ContentType = response.ResponseMessage.Content.Headers.ContentType;
            response.ResponseMessage.Content.Headers.ContentLength = memoryStream.Length;
            response.ResponseMessage.Content.Headers.ContentEncoding.Clear();
            response.ResponseMessage.Content.Headers.ContentEncoding.Add("identity");
            response.ResponseMessage.Content.Headers.ContentEncoding.Add("deflate");

            // Remove gzip header
            response.ResponseMessage.Content.Headers.Remove("Content-Encoding");
            return response;
        }
    }
}
