using Gallery.View.Lists.Models;
using System.Collections.ObjectModel;
using System.Text;

namespace Gallery.View.Lists;

public partial class CollectionViewPage : ContentPage
{
	ObservableCollection<Movie> movies = new();
	int countMovies = 0;
	public CollectionViewPage()
	{
		InitializeComponent();

		//AddMovies();
		CollectionViewControl.ItemsSource = MovieList.GetGroupList();
	}

    private async void RefreshView_Refreshing(object sender, EventArgs e)
    {
		((RefreshView)sender).IsRefreshing = true;

		await Task.Delay(3000);
		CollectionViewControl.ItemsSource = MovieList.GetGroupList();

		((RefreshView)sender).IsRefreshing = false;
    }

	private void AddMovies()
	{
		for (int i = 0; i < 20; i++)
		{
			Movie movie = new()
			{
				Id = countMovies++,
				Name = $"Movie: {countMovies}",
				Description = $"Description {countMovies}",
				LaunchYear = 2022,
				Duration = new TimeSpan(2,0,0)
			};
			movies.Add(movie);
		}
	}

    private void CollectionViewControl_RemainingItemsThresholdReached(object sender, EventArgs e)
    {
		AddMovies();
	}

    private void CollectionViewControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		StringBuilder sb = new();
		foreach (Movie movie in e.CurrentSelection)
		{
			sb.Append(movie.Name + "\n");
		}
		lblCollectionMovies.Text = sb.ToString();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		var group = (List<GroupMovie>)CollectionViewControl.ItemsSource;
		var item = group[2][0]; //indice do grupo + indice do filme

		//CollectionViewControl.ScrollTo(4, position: ScrollToPosition.Center);
		CollectionViewControl.ScrollTo(item, position: ScrollToPosition.Center);
    }

    private void CollectionViewControl_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		lblScrollStatus.Text = $"Posicionamento: {e.VerticalOffset}\nEspaçamento: {e.VerticalDelta}";
	}
}