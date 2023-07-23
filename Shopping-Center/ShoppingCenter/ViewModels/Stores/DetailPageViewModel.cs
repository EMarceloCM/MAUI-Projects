using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.Models;

namespace ShoppingCenter.ViewModels.Stores
{
    [QueryProperty(nameof(Establishment), "establishment")]
    public partial class DetailPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Establishment establishment;

        [RelayCommand]
        private void OnTapToBack()
        {
            Shell.Current.GoToAsync("..");
        }
    }
}
