using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Tema1;

namespace Tema1
{
    public partial class App : Application
    {
        private Window? _window;

        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            _window = new MainWindow();

            Frame rootFrame = new Frame();
            rootFrame.Navigate(typeof(MainPage));

            _window.Content = rootFrame;
            _window.Activate();
        }
    }
}