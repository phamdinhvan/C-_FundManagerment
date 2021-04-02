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
    /// Interaction logic for ImageSP.xaml
    /// </summary>
    public partial class ImageSP : Window
    {
        public ImageSP()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] imageNames = { "SaPa/12.jpg", "SaPa/13.jpg", "SaPa/14.jpg", "SaPa/15.jpg", "SaPa/16.jpg", "SaPa/17.jpg", "SaPa/18.jpg", "SaPa/19.jpg", "SaPa/20.jpg" };
            var rand = new Random();
            string imageName = imageNames[rand.Next(imageNames.Length)];
            string image = string.Concat("/SaPa/", imageName);
            SP.Source = new BitmapImage(new Uri(imageName, UriKind.Relative));
        }
    }
}
