using Gallery.Libraries.Fix;
using Gallery.Models;
using Gallery.Repositories;
using System.Collections.ObjectModel;

namespace Gallery.View;

public partial class MainPage : ContentPage
{
    private IGroupComponentRepository _repository;
	List<Component> _fullList;
    ObservableCollection<Component> _filtedList;
    public MainPage()
	{
		InitializeComponent();

        _repository = new GroupComponentRepository();
        _fullList = _repository.GetComponents();
        _filtedList = new ObservableCollection<Component>(_fullList);

        ComponentCollection.ItemsSource = _filtedList;
	}

    private void OnTapComponent(object sender, TappedEventArgs e)
    {
        KeyboardFix.HideKeyBoard();

        var component = (Component)e.Parameter;

        if (component.IsReplacementPage == false)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(component.page));
            ((FlyoutPage)App.Current.MainPage).IsPresented = false; //esconde o menu
        }
        else
        {
            App.Current.MainPage = (Page)Activator.CreateInstance(component.page);
        }
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var word = e.NewTextValue.ToLower();

        ClearWithoutRendering();

        Search(word);
    }

    private void ClearWithoutRendering()
    {
        var limit = _filtedList.Count;

        for (int i = 0; i < limit; i++)
        {
            _filtedList.RemoveAt(0);
        }
    }

    private void Search(string word)
    {
        var filtedList = _fullList.Where(a => a.Name.ToLower().Contains(word)).ToList();

        foreach (var component in filtedList)
        {
            _filtedList.Add(component);
        }
    }
}