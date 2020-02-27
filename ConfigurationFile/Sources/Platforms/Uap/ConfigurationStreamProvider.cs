namespace Nivaes.ConfigurationFile
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Windows.Storage;

    public static class ConfigurationStreamProvider
    {
        public static async Task<Stream> GetFileStream(string fileName)
        {
            var filePath = $"ms-appx:///Assets/{fileName}";

            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(filePath));

            var inputStream = await file.OpenReadAsync();
            var readingStream = inputStream.AsStreamForRead();

            return readingStream;
        }
    }
}
