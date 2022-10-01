using System.Drawing;

namespace WindowsDesktop.Theme
{
    public class STheme
    {
        public static string FontName { get; set; }
        
        public struct SColor
        {
            public static Color SiteMenuForColor = Color.White;
            public static Color SiteMenuBackColor = Color.FromArgb(89, 92, 134);
            public static Color TopMenuForColor = Color.White;
            public static Color TopMenuBackColor = Color.FromArgb(134, 138, 201);
            
            public static Color ActiveForColor = Color.White;
            public static Color ActiveBackColor = Color.FromArgb(134, 138, 201);
            public static Color HoverBackColor = Color.FromArgb(89, 92, 134);

            public static Color ForColor = Color.Black;
            public static Color BackColor = Color.White;
            public static Color MenuPanelBackColor = Color.White;
            public static Color TextFieldBackgroundColor = Color.White;
            public static Color TextFieldForColor = Color.Black;
        }
        
        public struct SFont
        {
            public static FontFamily Font = new FontFamily(FontName= "Segoe UI");
            public static float Size = 10;
        }
    }
}
