namespace Gallery.View.Components.Forms;

public partial class CheckBoxPage : ContentPage
{
	public CheckBoxPage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value == true)
		{
			CheckBox cs = ((CheckBox)sender);
			HorizontalStackLayout h = (HorizontalStackLayout)cs.Parent;
			lblTxt.Text = ((Label)h.Children[1]).Text;
		}
		else
		{
			lblTxt.Text = "";
		}
    }
}