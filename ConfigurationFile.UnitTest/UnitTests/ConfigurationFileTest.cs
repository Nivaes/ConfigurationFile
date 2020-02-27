namespace Nivaes.ConfigurationFile.UnitTest
{
    using System.Threading.Tasks;
    using FluentAssertions;
    using Microsoft.Extensions.Configuration;
    using Xunit;
    using Nivaes.ConfigurationFile;

    public class ConfigurationFileTest
    {
        [Fact]
        public async Task LoadConfigurationFile()
        {
            var streamFile = await ConfigurationStreamProvider.GetFileStream("appsettings.json");
            streamFile.Should().NotBeNull();

            var builder = new ConfigurationBuilder().AddJsonStream(streamFile);
            builder.Should().NotBeNull();
            var configuration = builder.Build();
            var testValue = configuration.GetSection("TestConfiguration").GetValue<string>("Test1");

            testValue.Should().Be("Value1");
        }
    }
}
