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
    /// Interaction logic for ImageCM.xaml
    /// </summary>
    public partial class ImageCM : Window
    {
        public ImageCM()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] imageNames = { "CaMau/bienkhailong.jpg", "CaMau/cua.jpg", "CaMau/damthituong.jpg", "CaMau/hau.jpg", "CaMau/muicamau.jpg", "CaMau/song.jpg", "CaMau/vuonchim.jpg" };
            var rand = new Random();
            string imageName = imageNames[rand.Next(imageNames.Length)];
            string image = string.Concat("/CaMau/", imageName);
            CM.Source = new BitmapImage(new Uri(imageName, UriKind.Relative));
        }
    }
}
