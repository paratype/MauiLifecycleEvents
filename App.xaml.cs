namespace TestLifecycle;
using System.Diagnostics;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        window.Created += (s, e) => {
            Debug.WriteLine($"{DateTime.Now} Created");
        };
        window.Activated += (s, e) => {
            Debug.WriteLine($"{DateTime.Now} Activated");
        };
        window.Deactivated += (s, e) => {
            Debug.WriteLine($"{DateTime.Now} Deactivated");
        };
        window.Resumed += (s, e) => {
            Debug.WriteLine($"{DateTime.Now} Resumed");
        };
        window.Destroying += (s, e) => {
            Debug.WriteLine($"{DateTime.Now} Destroying");
            var cur = (MainPage as AppShell).CurrentItem;
        };
        window.Stopped += (s, e) => {
            Debug.WriteLine($"{DateTime.Now} Stopped");
            var page = (MainPage as AppShell).CurrentPage as MainPage;
            if (page != null) page.OnMinimized();
        };

        return window;
    }


}



