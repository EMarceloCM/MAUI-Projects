using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.Services;

namespace ShoppingCenter.ViewModels.Tickets
{
    public partial class CameraPageViewModel : ObservableObject
    {
        [RelayCommand]
        private void BarCodeDetected(string TicketNumber)
        {
            var service = App.Current.Handler.MauiContext.Services.GetService<TicketService>();
            var ticket = service.GetTicket(TicketNumber);

            if (ticket == null)
            {
                App.Current.MainPage.DisplayAlert("Ticket não encontrado!", $"Não foi localizado o ticket: {TicketNumber}", "OK");
                TicketNumber = string.Empty;
                return;
            }

            var param = new Dictionary<string, object>()
            {
                { "ticket", ticket }
            };

            //Rota atual: tickets/camera
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await Shell.Current.GoToAsync("../pay", param);
            });
        }
    }
}