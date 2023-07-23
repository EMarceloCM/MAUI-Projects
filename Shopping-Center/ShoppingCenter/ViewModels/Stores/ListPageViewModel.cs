﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.Models;
using ShoppingCenter.Services;

namespace ShoppingCenter.ViewModels.Stores
{
    public partial class ListPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string textSearch;

        private List<Establishment> establishmentsFull;

        [ObservableProperty]
        private List<Establishment> establishmentsFiltered;

        public ListPageViewModel()
        {
            var service = App.Current.Handler.MauiContext.Services.GetService<StoreService>();
            establishmentsFull = service.GetStores();
            establishmentsFiltered = establishmentsFull.ToList();
        }

        [RelayCommand]
        private void OnTextSearchChangedFilterList()
        {
            EstablishmentsFiltered = establishmentsFull.Where(a => a.Name.ToLower().Contains(TextSearch.ToLower())).ToList();
        }

        [RelayCommand]
        private async void OnTapEstablishmentGoToDetailPage(Establishment establishment)
        {
            var navigationParameter = new Dictionary<string, object>()
            {
                { "establishment", establishment }
            };
            await Shell.Current.GoToAsync("detail", navigationParameter);
        }
    }
}
