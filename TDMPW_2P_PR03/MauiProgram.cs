using Microsoft.Extensions.Logging;

namespace TDMPW_2P_PR03;

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
				fonts.AddFont("Hello Valentina.ttf", "Valentina");
				fonts.AddFont("MittaSweety.ttf", "Mitta");
				fonts.AddFont("TYPO_COMICS_bold_demo.otf", "ComicBold");
				fonts.AddFont("TYPO_COMICS_demo.otf", "Comic");
				fonts.AddFont("TYPO_COMICS_Light_demo.otf", "ComicLight");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
