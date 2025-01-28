using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIV.Shared.Interfaces
{
    public interface ILocalNotificationService
    {
        void ShowNotification(string title, string message);
    }
}
