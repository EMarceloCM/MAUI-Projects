using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.Libraries.Storages;
using ShoppingCenter.Models;

namespace ShoppingCenter.ViewModels.Tickets
{
    [QueryProperty(nameof(Ticket), "ticket")]
    public partial class PayPageViewModel : ObservableObject
    {
        private Ticket ticket;
        public Ticket Ticket
        {
            get { return ticket; }

            set
            {
                GenerateDateOut(value);
                GeneratePrice(value);
                SetProperty(ref ticket, value);
            }

        }

        [ObservableProperty]
        private string pixCode = "00020126360014BR.GOV.BCB.PIX0114+5561999...";

        [RelayCommand]
        private async void CopyAndPaste()
        {
            await Clipboard.Default.SetTextAsync(PixCode);
            await Task.Delay(3000);

            var storage = App.Current.Handler.MauiContext.Services.GetService<TicketPreferenceStorage>();
            storage.Save(Ticket);

            var param = new Dictionary<string, object>
            {
                { "ticket", Ticket }
            };
            await Shell.Current.GoToAsync("../result", param);
        }
        private void GenerateDateOut(Ticket ticket)
        {
            var rd = new Random();
            var hour = rd.Next(0, 12);
            var min = rd.Next(0, 60);

            ticket.DateOut = ticket.DateIn.AddHours(hour).AddMinutes(min);
            ticket.DateTolerance = ticket.DateOut.AddMinutes(30);
        }

        private double hourValue = 0.08;
        private void GeneratePrice(Ticket ticket)
        {
            var dif = new TimeSpan(ticket.DateOut.Ticks - ticket.DateIn.Ticks);

            ticket.Price = dif.TotalMinutes * hourValue;
        }
    }
}
