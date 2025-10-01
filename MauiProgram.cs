using Microsoft.Extensions.Logging;

namespace eSnapFuse
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Font Awesome 7 Brands-Regular-400.otf", "IconBrands");
                    fonts.AddFont("Font Awesome 7 Free-Regular-400.otf", "IconRegular");
                    fonts.AddFont("Font Awesome 7 Free-Solid-900.otf", "IconSolid");
                    fonts.AddFont("Montserrat-Medium.ttf", "FontM");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
