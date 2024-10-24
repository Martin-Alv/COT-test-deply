using eaton.Handlers;
using eaton.Web;
using System.Web.Configuration;

namespace eaton.Services
{
    public class AppFrameworkConfig
    {

        public virtual void Initialize()
        {
            ApplicationServices.FrameworkAppName = "<div class=\"app-name-under-logo\">COOPER - Replenishment System</div>";
            ApplicationServices.Version = "8.9.23.286";
            ApplicationServices.HostVersion = "1.2.5.0";
            var compilation = ((CompilationSection)(WebConfigurationManager.GetSection("system.web/compilation")));
            var releaseMode = !compilation.Debug;
            AquariumExtenderBase.EnableMinifiedScript = releaseMode;
            AquariumExtenderBase.EnableCombinedScript = releaseMode;
            ApplicationServices.EnableMinifiedCss = releaseMode;
            ApplicationServices.EnableCombinedCss = releaseMode;
            BlobFactoryConfig.Initialize();
        }
    }
}
