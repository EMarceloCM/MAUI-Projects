using Gallery.Models;
using System.Web;

namespace Gallery.View.Shells.Pages;

public partial class Page02 : ContentPage
{
	public Page02()
	{
		InitializeComponent();
	}

    private void GoToStep1WParameters(object sender, EventArgs e)
    {
		//QueryString (?{parametro}={valor}&{parametro}={valor})
		var texto = "Este é um parametro passado pela tela anterior!";
		var textoCodificado = HttpUtility.UrlEncode(texto);

		Shell.Current.GoToAsync($"//pg2/Page02Step01?msg={textoCodificado}");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		var person = new Person() { Id = 1, Name = "Elias", Email = "elias@email.com" };

		var parameters = new Dictionary<string, object>()
		{
			{"msg", "Este é um parametro passado de forma complexa"},
			{"person", person}
		};

		Shell.Current.GoToAsync("//pg2/Page02Step01", parameters);
    }
}