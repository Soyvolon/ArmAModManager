using ArmAModManager.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ArmAModManager;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
        if (Properties.Settings.Default.UpgradeSettings)
        {
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.UpgradeSettings = false;
        }

        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        ServiceCollection services = new();

        ConfigureServices(services);

        using var provider = services.BuildServiceProvider();

        Application.Run(provider.GetRequiredService<ClientMain>());
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        // Register Services
        services.AddSingleton<IManifestService, ManifestService>()
            .AddSingleton<IProfileService, ProfileService>();

        // Register Forms
        services.AddSingleton<ClientMain>();
    }
}