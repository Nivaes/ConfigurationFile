﻿//namespace Nivaes.ConfigurationFile
//{
//    using System;
//    using System.Collections.Generic;
//    using System.IO;
//    using System.Text;
//    using System.Threading.Tasks;

//    public static class ConfigurationStreamProvider
//    {
//        public static Task<Stream> GetFileStream(string fileName)
//        {
//            ReleaseUnmanagedResources();
//            _readingStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

//            return Task.FromResult(_readingStream);
//        }
//    }
//}
