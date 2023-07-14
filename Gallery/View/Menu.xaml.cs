using Gallery.Models;
using Gallery.Repositories;
using System.Runtime.CompilerServices;

namespace Gallery.View;

public partial class Menu : ContentPage
{
	private IGroupComponentRepository _repository;
	public Menu()
	{
		InitializeComponent();

		//TODO - DI - Dependency Injection
		_repository = new GroupComponentRepository();

		MenuCollection.ItemsSource = _repository.GetGroupComponents();
	}
    private void OnTapComponent(object sender, TappedEventArgs e)
    {
        var component = (Component)e.Parameter;

        if(component.IsReplacementPage == false)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(component.page));
            ((FlyoutPage)App.Current.MainPage).IsPresented = false; //esconde o menu
        }
        else
        {
            App.Current.MainPage = (Page)Activator.CreateInstance(component.page);
        }
        
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Gallery.View.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}