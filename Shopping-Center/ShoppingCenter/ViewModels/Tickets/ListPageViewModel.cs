using CommunityToolkit.Mvvm.ComponentModel;
using ShoppingCenter.Libraries.Storages;
using ShoppingCenter.Models;

namespace ShoppingCenter.ViewModels.Tickets
{
    public partial class ListPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<Ticket> tickets;

        public ListPageViewModel()
        {
            var storage = App.Current.Handler.MauiContext.Services.GetService<TicketPreferenceStorage>();

            this.Tickets = storage.Load();
        }
    }
}
