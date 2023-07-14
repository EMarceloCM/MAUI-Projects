using Gallery.Resources.Styles;

namespace Gallery.View.Styles;

public partial class Tema : ContentPage
{
	private bool light = true;
	public Tema()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		ICollection<ResourceDictionary> dictionaries = Application.Current.Resources.MergedDictionaries;
		if (dictionaries != null)
		{
			dictionaries.Remove(dictionaries.ElementAt(2));

			if (light)
			{
				dictionaries.Add(new DarkTheme());
			}
			else
			{
                dictionaries.Add(new LightTheme());
            }
			light = !light;
		}
    }
}