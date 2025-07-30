using System.IO;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.SystemWeb;
using Microsoft.Extensions.DependencyInjection;

namespace WingtipToys.AdminUI
{
    public class AppDataProtectionStartup : DataProtectionStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            var path = Path.Combine(Path.GetTempPath(), "sharedkeys", "WingtipToys.Admin");

            services.AddDataProtection()
                .SetApplicationName("WingtipToys.Admin")
                .PersistKeysToFileSystem(new DirectoryInfo(path));
        }
    }
}