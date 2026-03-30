using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace Tema1
{
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<TaskItem> tasks = new ObservableCollection<TaskItem>();
        private int selectedIndex = -1;

        public MainPage()
        {
            this.InitializeComponent();
            TasksListView.ItemsSource = tasks;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) ||
                PriorityComboBox.SelectedItem == null ||
                StatusComboBox.SelectedItem == null)
            {
                MessageTextBlock.Text = "Completeaza toate campurile obligatorii.";
                return;
            }

            var task = new TaskItem
            {
                Title = TitleTextBox.Text,
                Description = DescriptionTextBox.Text,
                Priority = ((ComboBoxItem)PriorityComboBox.SelectedItem).Content.ToString() ?? "",
                Status = ((ComboBoxItem)StatusComboBox.SelectedItem).Content.ToString() ?? ""
            };

            tasks.Add(task);
            MessageTextBlock.Text = "Sarcina a fost adăugata.";
            ClearFields();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedIndex == -1 || PriorityComboBox.SelectedItem == null || StatusComboBox.SelectedItem == null)
            {
                MessageTextBlock.Text = "Selecteaza o sarcina pentru modificare.";
                return;
            }

            tasks[selectedIndex].Title = TitleTextBox.Text;
            tasks[selectedIndex].Description = DescriptionTextBox.Text;
            tasks[selectedIndex].Priority = ((ComboBoxItem)PriorityComboBox.SelectedItem).Content.ToString() ?? "";
            tasks[selectedIndex].Status = ((ComboBoxItem)StatusComboBox.SelectedItem).Content.ToString() ?? "";

            TasksListView.ItemsSource = null;
            TasksListView.ItemsSource = tasks;

            MessageTextBlock.Text = "Sarcina a fost modificata.";
            ClearFields();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (TasksListView.SelectedItem is TaskItem selectedTask)
            {
                tasks.Remove(selectedTask);
                MessageTextBlock.Text = "Sarcina a fost ștearsa.";
                ClearFields();
            }
            else
            {
                MessageTextBlock.Text = "Selectează o sarcina pentru stergere.";
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
            MessageTextBlock.Text = "Campurile au fost golite.";
        }

        private void TasksListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TasksListView.SelectedItem is TaskItem selectedTask)
            {
                selectedIndex = tasks.IndexOf(selectedTask);

                TitleTextBox.Text = selectedTask.Title;
                DescriptionTextBox.Text = selectedTask.Description;

                SetComboBoxItem(PriorityComboBox, selectedTask.Priority);
                SetComboBoxItem(StatusComboBox, selectedTask.Status);
            }
        }

        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            if (TasksListView.SelectedItem is TaskItem selectedTask)
            {
                Frame.Navigate(typeof(DetailsPage), selectedTask);
            }
            else
            {
                MessageTextBlock.Text = "Selecteaza o sarcina pentru a vedea detaliile.";
            }
        }

        private void TitleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageTextBlock.Text = "Se editeaza titlul sarcinii...";
        }

        private void ClearFields()
        {
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";
            PriorityComboBox.SelectedIndex = -1;
            StatusComboBox.SelectedIndex = -1;
            TasksListView.SelectedItem = null;
            selectedIndex = -1;
        }

        private void SetComboBoxItem(ComboBox comboBox, string value)
        {
            foreach (ComboBoxItem item in comboBox.Items)
            {
                if ((item.Content?.ToString() ?? "") == value)
                {
                    comboBox.SelectedItem = item;
                    break;
                }
            }
        }
    }
}