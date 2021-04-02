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
using System.Windows.Shapes;

namespace WeSplit
{
    /// <summary>
    /// Interaction logic for ImageApachai.xaml
    /// </summary>
    public partial class ImageApachai : Window
    {
        public ImageApachai()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] imageNames = { "Apachai/2.jpg", "Apachai/3.jpg", "Apachai/4.jpg", "Apachai/5.jpg", "Apachai/6.jpg", "Apachai/7.jpg" };
            var rand = new Random();
            string imageName = imageNames[rand.Next(imageNames.Length)];
            string image = string.Concat("/Apachai/", imageName);
            APC.Source = new BitmapImage(new Uri(imageName, UriKind.Relative));
        }
    }
}
