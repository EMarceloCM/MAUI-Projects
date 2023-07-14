namespace Gallery.View.Components.Forms;

public partial class DatePickerPage : ContentPage
{
	public DatePickerPage()
	{
		InitializeComponent();
	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		lblTxt.Text += "\nNova data: " + e.NewDate.ToString();
    }
}