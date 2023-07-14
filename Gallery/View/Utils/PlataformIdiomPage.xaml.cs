namespace Gallery.View.Utils;

public partial class PlataformIdiomPage : ContentPage
{
    [Obsolete]
    public PlataformIdiomPage()
	{
		InitializeComponent();
		
		if(Device.RuntimePlatform == Device.WinUI)
		{
			DisplayAlert("Windows", "Mensagem exclusiva do windows", "Ok");
		}
		if (Device.Idiom == TargetIdiom.Phone)
		{
			DisplayAlert("Smarthphone", "Mensagem exclusiva para celulares", "Ok");
		}

#if WINDOWS
	DisplayAlert("Condicao de compilacao", "Mensagem exclusiva do windows durante compilacao", "Ok");
#endif
	}
}