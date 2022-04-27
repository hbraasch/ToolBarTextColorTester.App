namespace ToolBarTextColorTester;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartupPage { }) { BarTextColor = Colors.Red, BarBackground = Colors.Gray };
	}
}
