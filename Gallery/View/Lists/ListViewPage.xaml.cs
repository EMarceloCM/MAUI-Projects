using Gallery.View.Lists.Models;

namespace Gallery.View.Lists;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        ListViewControl.ItemsSource = MovieList.GetGroupList().Take(1);
    }

    private void ListViewControl_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Movie movie = (Movie)e.SelectedItem;
        App.Current.MainPage.DisplayAlert("Filme selecionado!", $"O filme selecionado é: {movie.Name}!", "Ok");
    }

    private async void ListViewControl_Refreshing(object sender, EventArgs e)
    {
        ListViewControl.IsRefreshing = true;
        await Task.Delay(3000);
        ListViewControl.ItemsSource = MovieList.GetGroupList();

        ListViewControl.IsRefreshing = false;
    }
}