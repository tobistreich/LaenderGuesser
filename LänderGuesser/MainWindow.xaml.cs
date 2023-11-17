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

namespace LänderGuesser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int level = 1;
        string image1Uri = String.Format(@"C:\Users\tobias.streich\Desktop\code\C#\LänderGuesser\LänderGuesser\Images\germany.png");
        public MainWindow()
        {
            InitializeComponent();
            updateImage();
        }
        private void checkInputButtonClicked(object sender, RoutedEventArgs e)
        {
            if (level == 1 && Input_TextBox.Text == "DEUTSCHLAND")
            {
                Next_Button.Visibility = Visibility.Visible;

            }
        }

        private void nextButtonClicked(object sender, RoutedEventArgs e)
        {
            Next_Button.Visibility = Visibility.Collapsed;
            level++;
        }

        private void updateImage()
        {
            if (level == 1)
            {
                Image newImage = new Image();
                newImage.Source = new BitmapImage(new Uri(image1Uri));
            }
        }
    }
}
