using System;
using System.IO;
using System.Reflection;

namespace AniDb.Api.Test.Resources
{
    internal static class ResourcesHelper
    {
        public static string GetStringResource(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using Stream stream = assembly.GetManifestResourceStream($"AniDb.Api.Test.Resources.{fileName}") ?? throw new InvalidOperationException($"File {fileName} not found.");
            using StreamReader reader = new(stream);
            return reader.ReadToEnd();
        }
    }
}
