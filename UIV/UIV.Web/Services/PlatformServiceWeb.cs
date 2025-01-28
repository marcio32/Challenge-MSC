using UI.Shared.Interfaces;

namespace UI.Web.Services
{
    public class PlatformServiceWeb : IPlatformService
    {
        public string GetPlatform()
        {
            return "Web";
        }
    }
}
