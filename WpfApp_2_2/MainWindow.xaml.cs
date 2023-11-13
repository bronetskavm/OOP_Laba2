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
            double a, b, c;
            if (TryGetValidInput(aTextBox.Text, out a) && TryGetValidInput(bTextBox.Text, out b) && TryGetValidInput(cTextBox.Text, out c))
            {
                double discriminant = CalculateDiscriminant(a, b, c);

                if (discriminant > 0)
                {
                    discriminantText.Text = $"Дискримінант: {discriminant:F3}";
                    solutionText1.Text = $"Розв'язок 1: {((-b + Math.Sqrt(discriminant)) / (2 * a)):F3}";
                    solutionText2.Text = $"Розв'язок 2: {((-b - Math.Sqrt(discriminant)) / (2 * a)):F3}";
                }
                else if (discriminant == 0)
                {
                    solutionText1.Text = $"Один розв'язок: {(-b / (2 * a)):F3}";
                }
                else
                {
                    discriminantText.Text = $"Дискримінант: {discriminant:F3}";
                    discriminantText.Text = "Розв'язків немає.";
                }

                discriminantText.Visibility = Visibility.Visible;
                solutionText1.Visibility = Visibility.Visible;
                solutionText2.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Некоректні введені значення. Будь ласка, введіть дійсні числа.");
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
                value = 0;
                return false;
            }
        }

        private double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}
