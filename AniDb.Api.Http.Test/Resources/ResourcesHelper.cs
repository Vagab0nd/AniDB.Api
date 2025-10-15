using System.Reflection;

namespace AniDb.Api.Http.Test.Resources
{
    internal static class ResourcesHelper
    {
        public static string GetStringResource(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using Stream stream = assembly.GetManifestResourceStream($"AniDb.Api.Http.Test.Resources.{fileName}") ?? throw new InvalidOperationException($"File {fileName} not found.");
            using StreamReader reader = new(stream);
            return reader.ReadToEnd();
        }
        public static byte[] GetByteResource(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using Stream stream = assembly.GetManifestResourceStream($"AniDb.Api.Http.Test.Resources.{fileName}") ?? throw new InvalidOperationException($"File {fileName} not found.");
            using (MemoryStream memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
