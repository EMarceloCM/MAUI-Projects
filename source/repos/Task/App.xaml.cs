using Task.Views;
using Microsoft.Maui.Platform;

namespace Task
{
    public partial class App : Application
    {
        public App()
        {
            CustomHandler();

            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
            Application.Current.UserAppTheme = AppTheme.Light;
        }

        private void CustomHandler ()
        {
            EntryNoBorder();
            DatePickerNoBorder();
        }

        private static void EntryNoBorder()
        {
            //remover borda das Entry´s
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
#if ANDROID
                //ANDROID
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.AliceBlue.ToPlatform());
#endif
#if IOS || MACCATALYST
                //IOS e MAC
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
#if WINDOWS
                //Windows - nao funciona 100%
                handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
            });
        }

        private static void DatePickerNoBorder()
        {
            //remover borda das DatePicker´s
            Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
#if ANDROID
                //ANDROID
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.AliceBlue.ToPlatform());
#endif
#if IOS || MACCATALYST
                //IOS e MAC
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
#if WINDOWS
                //Windows - nao funciona 100%
                handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
            });
        }
    }
}