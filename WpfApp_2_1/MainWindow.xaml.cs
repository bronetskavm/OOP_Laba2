using System;
using System.Windows;
using System.Windows.Controls;
namespace WpfApp
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z;
            if (TryGetValidInput(xTextBox.Text, out x) &&
                TryGetValidInput(yTextBox.Text, out y) &&
                TryGetValidInput(zTextBox.Text, out z))
            {
                double s = CalculateS(x, y, z);
                resultText.Text = $"Значення s: {s:F3}";
            }
            else
            {
                resultText.Text = "Некоректні введені значення. Будь ласка, введіть дійсні числа.";
            }
        }

        private bool TryGetValidInput(string input, out double value)
        {
            if (double.TryParse(input, out value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private double CalculateS(double x, double y, double z)
        {
            // Обчислення значення s згідно з варіантом
            double s = Math.Log(x) * (Math.Pow((y + Math.Pow(x - 1, 1 / 3)), 1 / 4) / (2 * Math.Abs(x + z)));
            return s;
        }
    }
}
