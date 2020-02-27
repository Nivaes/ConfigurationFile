using System.Reflection;
using Xunit.Runners.UI;

namespace Nivaes.ConfigurationFile.UnitTest.UAP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : RunnerApplication
    {
        protected override void OnInitializeRunner()
        {
            AddTestAssembly(typeof(App).GetTypeInfo().Assembly);
        }
    }
}
