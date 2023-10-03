using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pract5
{
    /// <summary>
    /// Логика взаимодействия для ValidationInputPage.xaml
    /// </summary>
    public partial class ValidationInputPage : Page
    {
        public ValidationInputPage()
        {
            InitializeComponent();
        }
        private void NameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // если хотя бы один символ не буква
            if (e.Text.Any(symbol => !char.IsLetter(symbol)))
            {
                // то "запрещаем" ввод
                e.Handled = true;
            }
        }
        private void IdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // или самостоятельно с помощью foreach/for
            if (e.Text.Any(symbol => !char.IsDigit(symbol)))
            {
                e.Handled = true;
            }
        }
        private void IdTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
        private void IdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IdTextBox.Text.StartsWith("0"))
            {
                IdTextBox.Text = IdTextBox.Text.TrimStart('0');
            }
        }

        private void AgeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => !char.IsDigit(symbol)))
            {
                e.Handled = true;
            }
            var text = sender as TextBox;
            if (text.Text.Length >= 2)
                e.Handled = true;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!NumberTextBox.Text.StartsWith("8"))
            {
                NumberTextBox.Text = "";
            }
        }

        private void NumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => !char.IsDigit(symbol)))
            {
                e.Handled = true;
            }
            var text = sender as TextBox;
            if (text.Text.Length >=11)
                e.Handled = true;
        }

        private void AgeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (AgeTextBox.Text.StartsWith("0"))
            {
                AgeTextBox.Text = IdTextBox.Text.TrimStart('0');
            }
        }
    }
}
