namespace Gallery.View.Components.Forms;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var component = (Picker)sender;
		lblTxt.Text = component.SelectedItem.ToString() + " (" + component.SelectedIndex.ToString() + ")";

		//component.SelectedItem = component.ItemsSource[0];
    }
}