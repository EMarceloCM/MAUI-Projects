namespace Gallery.View.Components.Forms;

public partial class StepperPage : ContentPage
{
	public StepperPage()
	{
		InitializeComponent();
	}

	private void AlternativeOne(object sender, ValueChangedEventArgs e)
	{
        lblTxt.Text = "Novo Valor: " + e.NewValue.ToString() + "\nValor Anterior: " + e.OldValue.ToString();
    }
}