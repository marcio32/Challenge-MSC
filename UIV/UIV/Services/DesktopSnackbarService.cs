using UI.Shared.Interfaces;

namespace UIV.Services
{
    public class DesktopSnackbarService : INotificationService
    {
        public async void ShowSnackbar(string message)
        {
            var snackbarLabel = new Microsoft.Maui.Controls.Label
            {
                Text = message,
                BackgroundColor = Colors.Black,
                TextColor = Colors.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Padding = new Thickness(20)
            };

            await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Snackbar", message, "OK");
        }
    }
}
