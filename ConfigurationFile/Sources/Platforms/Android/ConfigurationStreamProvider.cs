namespace Nivaes.ConfigurationFile
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Android.Content;
    using Android.Content.Res;

    public static class ConfigurationStreamProvider
    {
        private static Lazy<Context> mContextLazy;

        public static void Initialize(Func<Context> contextFactory)
        {
            mContextLazy = new Lazy<Context>(contextFactory);
        }

        public static ValueTask<Stream> GetFileStream(string fileName)
        {
            if (mContextLazy == null) throw new Exception("ConfigurationStreamProvider not initialize. call o Initialize.");

            AssetManager assets = mContextLazy.Value.Assets;

            var stream = assets.Open(fileName);

            return new ValueTask<Stream>(stream);
        }
    }
}
