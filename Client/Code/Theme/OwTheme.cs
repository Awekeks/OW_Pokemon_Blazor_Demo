using MudBlazor;

namespace Client.Code.Theme;

public class OwTheme : MudTheme
{
    public OwTheme()
    {
        PaletteLight = new PaletteLight
        {
            AppbarBackground = Colors.Teal.Default,
            Primary = Colors.Teal.Default,
            PrimaryLighten = Colors.Teal.Lighten1,
            PrimaryDarken = Colors.Teal.Darken1,
            Tertiary = Colors.Purple.Default,
            TertiaryLighten = Colors.Purple.Lighten1,
            TertiaryDarken = Colors.Purple.Darken1,
        };
        PaletteDark = new PaletteDark
        {
            AppbarBackground = Colors.Teal.Default,
            Primary = Colors.Teal.Default,
            PrimaryLighten = Colors.Teal.Lighten1,
            PrimaryDarken = Colors.Teal.Darken1,
            Tertiary = Colors.Purple.Default,
            TertiaryLighten = Colors.Purple.Lighten1,
            TertiaryDarken = Colors.Purple.Darken1,
        };
        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "0px",
        };
    }
}
