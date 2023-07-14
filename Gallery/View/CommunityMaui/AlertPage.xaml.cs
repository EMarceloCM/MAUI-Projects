using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Gallery.View.CommunityMaui;

public partial class AlertPage : ContentPage
{
	public AlertPage()
	{
		InitializeComponent();
	}

	private void ShowSnackBar(object sender, EventArgs e)
	{
		//Config Visual, varia do SO
		var options = new SnackbarOptions
		{
			BackgroundColor = Colors.White,
			TextColor = Colors.Green,
		};

		//Instanciar
		var snackBar = Snackbar.Make("Ocorreu um erro inesperado", null, "Ok", TimeSpan.FromSeconds(5), options);

		//Apresentar a Snack
		snackBar.Show();
    }

    private void ShowToast(object sender, EventArgs e)
    {
		var toast = Toast.Make("Ocorreu um erro inesperado", ToastDuration.Long, textSize: 18).Show();
		//toast.Show();
    }
}