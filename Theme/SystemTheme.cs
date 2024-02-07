using Microsoft.Win32;

namespace TinyDRPC.Theme
{
    public class SystemTheme
    {
        public static int Status()
        {
            string keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            try { 
                return (int)Registry.GetValue(keyName, "AppsUseLightTheme", -1); 
            }
            catch { 
                return -1; 
            }
        }
    }
}
