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

namespace WpfTicket21Books
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Author validate

        private void TbAutor_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TbAutor.Foreground = TbAutor.Text.Length >= 20 && TbAutor.Text.Length <= 75 ? Brushes.LightGreen : Brushes.Red;

            e.Handled = TbAutor.Text.Length > 74;
        }

        private void TbAutor_TextChanged(object sender, TextChangedEventArgs e) 
        {
            TbAutor.Foreground = TbAutor.Text.Length >= 20 && TbAutor.Text.Length<= 75 ? Brushes.LightGreen : Brushes.Red;
            AuthorCount.Content = TbAutor.Text.Length;
        }
    #endregion

    #region Title validate
    private void TbTitle_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TbTitle.Foreground = TbTitle.Text.Length >= 10 && TbTitle.Text.Length <= 100 ? Brushes.LightGreen : Brushes.Red;

            e.Handled = TbTitle.Text.Length > 99;
        }

        private void TbTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            TbTitle.Foreground = TbTitle.Text.Length >= 10 && TbTitle.Text.Length <= 100 ? Brushes.LightGreen : Brushes.Red;
            TitleCount.Content = TbTitle.Text.Length;
        }
        
        #endregion
        #region Year validate
        private void TbYearOfCreation_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (TbYearOfCreation.Text.Length != 0)
            {
                if (!Char.IsDigit(e.Text, 0) || TbYearOfCreation.Text.Length>3)
                    e.Handled = true;
            } else
            {
                if (!Char.IsDigit(e.Text, 0) || e.Text == "0")
                    e.Handled = true;
            }

            TbYearOfCreation.Foreground = TbYearOfCreation.Text.Length != 4? Brushes.Red : Brushes.LightGreen;
            
        }
        #endregion
    }
}
