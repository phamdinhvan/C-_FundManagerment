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
    /// Interaction logic for HomeScr.xaml
    /// </summary>
    public partial class HomeScr : Window
    {
        public HomeScr()
        {
            InitializeComponent();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        private void HaGiang_mousedoubleclick(object sender, MouseButtonEventArgs e)
        {
            var scr = new HaGiang();
            scr.ShowDialog();
        }

        private void CaMau_mousedoubleclick(object sender, MouseButtonEventArgs e)
        {
            var scr = new CaMau();
            scr.ShowDialog();
        }

        private void ApaChai_mousedoubleclick(object sender, MouseButtonEventArgs e)
        {
            var scr = new APaChai();
            scr.ShowDialog();
        }

        private void CuLaoCham_mousedoubleclick(object sender, MouseButtonEventArgs e)
        {
            var scr = new CuLaoCham();
            scr.ShowDialog();
        }

        private void DaNang_mousedoubleclick(object sender, MouseButtonEventArgs e)
        {
            var scr = new DaNang();
            scr.ShowDialog();
        }

        private void PhuYen_mousedoubleclick(object sender, MouseButtonEventArgs e)
        {
            var scr = new PhuYen();
            scr.ShowDialog();
        }

        private void SaPa_mousedoubleclick(object sender, MouseButtonEventArgs e)
        {
            var scr = new SaPa();
            scr.ShowDialog();
        }

        private void LangSon_mousedoubleclick(object sender, MouseButtonEventArgs e)
        {
            var scr = new LangSon();
            scr.ShowDialog();
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            var scr = new SearchScr();
            scr.ShowDialog();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đã cập nhập chuyến đi Đà Nẵng", " ");
            var scr = new DaNangUpdated();
            scr.ShowDialog();
        }
    }
}
