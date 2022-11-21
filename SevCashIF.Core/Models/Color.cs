namespace SevCashIF.Core.Models;

public class Color {
    public string Name { get; init; }
    public uint Background { get; init; }
    public uint Text { get; init; }

    private Color() { }

    public static readonly Color Default = new Color {Name = "", Background = 0, Text = 0};
    public static readonly Color Color1 = new Color {Name = "color-1", Background = 0x127e68, Text = 0xfff};
    public static readonly Color Color2 = new Color {Name = "color-2", Background = 0x249724, Text = 0xfff};
    public static readonly Color Color3 = new Color {Name = "color-3", Background = 0x22e7bf, Text = 0x676767};
    public static readonly Color Color4 = new Color {Name = "color-4", Background = 0xd57a16, Text = 0xfff};
    public static readonly Color Color5 = new Color {Name = "color-5", Background = 0xf8ac59, Text = 0xfff};
    public static readonly Color Color6 = new Color {Name = "color-6", Background = 0xfbee1c, Text = 0x676767};
    public static readonly Color Color7 = new Color {Name = "color-7", Background = 0xd01e31, Text = 0xfff};
    public static readonly Color Color8 = new Color {Name = "color-8", Background = 0x743c93, Text = 0xfff};
    public static readonly Color Color9 = new Color {Name = "color-9", Background = 0xe98c96, Text = 0xfff};
    public static readonly Color Color10 = new Color {Name = "color-10", Background = 0x116295, Text = 0xfff};
    public static readonly Color Color11 = new Color {Name = "color-11", Background = 0x325cff, Text = 0xfff};
    public static readonly Color Color12 = new Color {Name = "color-12", Background = 0x53ade6, Text = 0xfff};
    public static readonly Color Color13 = new Color {Name = "color-13", Background = 0x303030, Text = 0xfff};
    public static readonly Color Color14 = new Color {Name = "color-14", Background = 0x939393, Text = 0xfff};
    public static readonly Color Color15 = new Color {Name = "color-15", Background = 0xc36e65, Text = 0xfff};
    public static readonly Color Color16 = new Color {Name = "color-16", Background = 0xff7b24, Text = 0x000};
    public static readonly Color Color17 = new Color {Name = "color-17", Background = 0xff190d, Text = 0xfff};
    public static readonly Color Color18 = new Color {Name = "color-18", Background = 0x43c056, Text = 0xfff};
    public static readonly Color Color19 = new Color {Name = "color-19", Background = 0x4d201d, Text = 0xfff};
}