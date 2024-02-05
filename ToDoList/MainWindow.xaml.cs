using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TodoListApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskTextBox.Text))
            {
                TasksListBox.Items.Add(TaskTextBox.Text);
                TaskTextBox.Clear();
            }
        }

        // Optional: Right-click to delete a task
        private void TasksListBox_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (TasksListBox.SelectedItem != null)
            {
                TasksListBox.Items.Remove(TasksListBox.SelectedItem);
            }
        }
    }
}
