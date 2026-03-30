using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace Tema1
{
    public sealed partial class DetailsPage : Page
    {
        public DetailsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is TaskItem task)
            {
                TitleBlock.Text = $"Titlu: {task.Title}";
                DescriptionBlock.Text = $"Descriere: {task.Description}";
                PriorityBlock.Text = $"Prioritate: {task.Priority}";
                StatusBlock.Text = $"Status: {task.Status}";
            }

            base.OnNavigatedTo(e);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}