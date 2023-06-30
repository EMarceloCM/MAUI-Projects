using Microsoft.Maui.Platform;

namespace Task.Libraries.Fix
{
    public static class KeyboardFix
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
