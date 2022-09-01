﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FontStyle = System.Drawing.FontStyle;

namespace WindowsDesktop.Theme
{
    public class STheme
    {
        public static string FontName { get; set; }
        
        public struct SColor
        {
            public static Color ForColor = Color.Black;
            public static Color BackColor = Color.White;
            public static Color ActiveForColor = Color.Black;
            public static Color ActiveBackColor = Color.PapayaWhip;
            public static Color MenuPanelBackColor = Color.White;
            public static Color TextFieldBackgroundColor = Color.White;
            public static Color TextFieldForColor = Color.Black;
            public static Color HoverBackColor = Color.Silver;
        }
        
        public struct SFont
        {
            public static FontFamily Font = new FontFamily(FontName= "Segoe UI");
            public static float Size = 10;
        }
    }
}
