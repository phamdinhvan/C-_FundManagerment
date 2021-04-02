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
    /// Interaction logic for ImageCLC.xaml
    /// </summary>
    public partial class ImageCLC : Window
    {
        public ImageCLC()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] imageNames = { "CLC/31.jpg", "CLC/32.jpg", "CLC/33.jpg", "CLC/34.jpg", "CLC/35.jpg", "CLC/36.jpg" };
            var rand = new Random();
            string imageName = imageNames[rand.Next(imageNames.Length)];
            string image = string.Concat("/CLC/", imageName);
            CLC.Source = new BitmapImage(new Uri(imageName, UriKind.Relative));
        }
    }
}
