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
    /// Interaction logic for ImageLS.xaml
    /// </summary>
    public partial class ImageLS : Window
    {
        public ImageLS()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] imageNames = { "LangSon/22.jpg", "LangSon/23.jpg", "LangSon/24.jpg", "LangSon/25.jpg", "LangSon/26.jpg", "LangSon/27.jpg" };
            var rand = new Random();
            string imageName = imageNames[rand.Next(imageNames.Length)];
            string image = string.Concat("/LangSon/", imageName);
            LS.Source = new BitmapImage(new Uri(imageName, UriKind.Relative));
        }
    }
}
