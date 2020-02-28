namespace Nivaes.ConfigurationFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    public static class ConfigurationStreamProvider
    {
        public static Task<Stream> GetFileStream(string fileName)
        {
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            return Task.FromResult<Stream>(fileStream);
        }
    }
}
