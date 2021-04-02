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
    /// Interaction logic for ImageDN.xaml
    /// </summary>
    public partial class ImageDN : Window
    {
        public ImageDN()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] imageNames = { "DaNang/d2.jpg", "DaNang/d3.jpg", "DaNang/d4.jpg", "DaNang/d5.jpg", "DaNang/d6.jpg", "DaNang/d7.jpg" };
            var rand = new Random();
            string imageName = imageNames[rand.Next(imageNames.Length)];
            string image = string.Concat("/DaNang/", imageName);
            CM.Source = new BitmapImage(new Uri(imageName, UriKind.Relative));
        }
    }
}
