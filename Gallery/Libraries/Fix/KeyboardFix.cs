using Microsoft.Maui.Platform;

namespace Gallery.Libraries.Fix
{
    public class KeyboardFix
    {
        public static void HideKeyBoard()
        {
#if ANDROID
    if (Platform.CurrentActivity.CurrentFocus != null) {
        Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);
    }
#endif
        }
    }
}
