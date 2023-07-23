using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.Models;

namespace ShoppingCenter.ViewModels.Cinemas
{
    [QueryProperty(nameof(Movie), "movie")]
    public partial class DetailPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Movie movie;

        [RelayCommand]
        private void OnTapCloseGoBackToList(MediaElement player)
        {
            player.Stop();
            Shell.Current.GoToAsync("..");
        }
    }
}
