using Gallery.Models;
using System.Web;

namespace Gallery.View.Shells.Pages;

[QueryProperty(nameof(Texto), "msg")]
[QueryProperty(nameof(Person), "person")]
public partial class Page02Step01WParameters : ContentPage
{
	private string texto;
	public string Texto
	{
		get { return texto; }
		set
		{
			texto = HttpUtility.UrlDecode(value);
			lblMsgParameter.Text = texto;
		}
	}

    private Person _person;
    public Person Person
    {
        get { return _person; }
        set
        {
			_person = value;
			lblPersonParameter.Text = "A pessoa recebida é: " + _person.Name + $"({_person.Email})";
        }
    }
    public Page02Step01WParameters()
	{
		InitializeComponent();
	}
}