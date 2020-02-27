namespace Nivaes.ConfigurationFile.UnitTest.UAP
{
    using System.Reflection;
    using Xunit.Runners.UI;

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
