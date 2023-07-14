namespace Gallery.View.Components.Forms;

public partial class EntryPage : ContentPage
{
	public EntryPage()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		lblText.Text = "Antigo: "+e.OldTextValue+"\nNovo: "+e.NewTextValue;
    }
}