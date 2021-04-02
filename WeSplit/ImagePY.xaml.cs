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
    /// Interaction logic for ImagePY.xaml
    /// </summary>
    public partial class ImagePY : Window
    {
        public ImagePY()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] imageNames = { "PhuYen/b.jpg", "PhuYen/c.jpg", "PhuYen/d.jpg", "PhuYen/e.jpg", "PhuYen/f.jpg", "PhuYen/g.jpg", "PhuYen/h.jpg" };
            var rand = new Random();
            string imageName = imageNames[rand.Next(imageNames.Length)];
            string image = string.Concat("/PhuYen/", imageName);
            PY.Source = new BitmapImage(new Uri(imageName, UriKind.Relative));
        }
    }
}
