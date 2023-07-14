namespace Gallery.View.Components.Mains;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}

    private void Button_Pressed(object sender, EventArgs e)
    {
		lbl.Text += $"\nPressionado: {DateTime.Now}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        lbl.Text += $"\nClicado: {DateTime.Now}";
    }

    private void Button_Released(object sender, EventArgs e)
    {
        lbl.Text += $"\nLiberado: {DateTime.Now}";
    }
}