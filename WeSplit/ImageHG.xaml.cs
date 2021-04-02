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
    /// Interaction logic for ImageHG.xaml
    /// </summary>
    public partial class ImageHG : Window
    {
        public ImageHG()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] imageNames = { "HaGiang/choquyettien.jpg", "HaGiang/moccucbac.jpg", "HaGiang/nuicamson.jpg", "HaGiang/honoong.jpg", "HaGiang/dongen.jpg", "HaGiang/Lungcu.jpg" };
            var rand = new Random();
            string imageName = imageNames[rand.Next(imageNames.Length)];
            string image = string.Concat("/HaGiang/", imageName);
            HG.Source = new BitmapImage(new Uri(imageName, UriKind.Relative));
        }
    }
}
