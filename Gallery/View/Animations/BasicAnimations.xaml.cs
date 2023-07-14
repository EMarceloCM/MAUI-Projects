namespace Gallery.View.Animations;

public partial class BasicAnimations : ContentPage
{
	public BasicAnimations()
	{
		InitializeComponent();
	}

    private void Diminuir(object sender, EventArgs e)
    {
        Image.ScaleTo(2, 2000);
    }

    private void Aumentar(object sender, EventArgs e)
    {
        Image.ScaleTo(0.5, 2000);
    }

    private void Normal(object sender, EventArgs e)
    {
        Image.Scale = 1;
        Image.TranslationX = 0;
        Image.TranslationY = 0;
        Image.Opacity = 1;
        Image.Rotation = 0;
    }

    private void Mover(object sender, EventArgs e)
    {
        Image.TranslateTo(100, 100, 2000, Easing.SpringIn);
    }

    private async void Rotacao(object sender, EventArgs e)
    {
        await Image.RelRotateTo(720, 2000);
        await Image.RotateXTo(360, 1000);
        await Image.RotateYTo(360, 1000);
    }

    private async void Opacidade(object sender, EventArgs e)
    {
        await Image.FadeTo(0.3, 1200);
    }

    private async void Sequencial(object sender, EventArgs e)
    {
        await Image.TranslateTo(100, 0, 250);
        await Image.TranslateTo(-100, 0, 500);
        await Image.TranslateTo(0, 0, 250);
    }

    private void Pararelo(object sender, EventArgs e)
    {
        Task.WhenAll(
            Image.TranslateTo(100, 0, 1000),
            Image.RotateTo(360, 1000),
            Image.FadeTo(0.6, 1000)
        );
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Image.CancelAnimations();
    }

    private void Custom(object sender, EventArgs e)
    {
        var mainAnim = new Animation(); //animacao pai que executara uma sequencia completa
        var anim = new Animation(v => Image.TranslationX =  v, 0, 300, Easing.Linear, null);
        var anim2 = new Animation(v => Image.Rotation =  v, 0, 300, Easing.Linear, null);

        //anim.Commit(this, "Mover com efeito", 16, 3000, null, null, () => true);
        mainAnim.Add(0, 1, anim);
        mainAnim.Add(0.5, 1, anim2);
        mainAnim.Commit(this, "Animacao Personalizada", 16, 8000, null, null, () => true);
    }

    private void Cor(object sender, EventArgs e)
    {
        Image.ColorTo(Colors.White, Colors.Violet, v => Image.BackgroundColor = v, 3000, null);
    }
}