namespace Nivaes.ConfigurationFile
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    public static class ConfigurationStreamProvider
    {
        public static async Task<Stream> GetFileStream(string fileName)
        {
            var filePath = $"ms-appx:///Assets/{fileName}";

            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(filePath));

            var inputStream = await file.OpenReadAsync();
            var readingStream = inputStream.AsStreamForRead();

            return _readingStream;
        }
    }
}
