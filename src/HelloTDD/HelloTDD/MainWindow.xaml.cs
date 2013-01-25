using System.Windows;

namespace HelloTDD
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, RoutedEventArgs e)
        {
            var result = int.Parse(FirstNumberTextBox.Text) + int.Parse(SecondNumberTextBox.Text);

            ResultTextBox.Text = result.ToString();
        }

        private void OnSubtractClicked(object sender, RoutedEventArgs e)
        {
            var result = int.Parse(FirstNumberTextBox.Text) - int.Parse(SecondNumberTextBox.Text);

            ResultTextBox.Text = result.ToString();
        }

        private void OnMultiplyClicked(object sender, RoutedEventArgs e)
        {
            var result = int.Parse(FirstNumberTextBox.Text) * int.Parse(SecondNumberTextBox.Text);

            ResultTextBox.Text = result.ToString();
        }

        private void OnDivideClicked(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
