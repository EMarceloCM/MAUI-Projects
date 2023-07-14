using Gallery.View.CommunityMaui.ViewModels;

namespace Gallery.View.CommunityMaui;

public partial class CommunityBehaviorPage : ContentPage
{
	public CommunityBehaviorPage()
	{
		InitializeComponent();
	}

    private void Button_Pressed(object sender, EventArgs e)
    {
		var vm = (CommunityBehaviorPageViewModel)BindingContext;
		
		if(vm.PressedCommand.CanExecute(null))
			vm.PressedCommand.Execute(null);
    }
}