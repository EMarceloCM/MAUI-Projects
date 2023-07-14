namespace Gallery.View.Shells.Pages;

public partial class Page01Step02 : ContentPage
{
	public Page01Step02()
	{
		InitializeComponent();
	}

    private void GoToRegisterStep02(object sender, EventArgs e)
    {
		//Rota Atual pg1/Page01Step02

		//Relativa
		//Shell.Current.GoToAsync("../../cadastro/passo2");

		//Absoluta
		Shell.Current.GoToAsync("//cadastro/passo2");
    }

    private void GoToWSearch(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("///passo1");
    }
}