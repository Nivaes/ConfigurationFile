namespace Nivaes.ConfigurationFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    public class ConfigurationStreamProvider
        : IConfigurationStreamProvider
    {
        public Task<Stream> GetFileStream(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
