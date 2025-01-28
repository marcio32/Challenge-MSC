using UI.Shared.Interfaces;

namespace UI.Services
{
    public class PlatformServiceMAUI : IPlatformService
    {
        public string GetPlatform()
        {
            if (DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.Android)
            {
                return "Mobile";
            }
            else if (DeviceInfo.Platform == DevicePlatform.WinUI)
            {
                return "Desktop";
            }
            else
            {
                return "Web";
            }
        }
    }
}
