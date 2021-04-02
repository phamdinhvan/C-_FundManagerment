using LiveCharts;
using LiveCharts.Wpf;
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
    /// Interaction logic for PhuYen.xaml
    /// </summary>
    public partial class PhuYen : Window
    {
        public PhuYen()
        {
            InitializeComponent();
            DataContext = this;
            List<Thanhvien> items = new List<Thanhvien>();
            items.Add(new Thanhvien() { Name = "Trần Binz (Trưởng Nhóm)" });
            items.Add(new Thanhvien() { Name = "De Thị Cao" });
            items.Add(new Thanhvien() { Name = "Bùi Văn Châu" });
            items.Add(new Thanhvien() { Name = "Jolie Nguyễn" });
            items.Add(new Thanhvien() { Name = "Dương Hồng Thanh" });
            lvDataBinding.ItemsSource = items;
            List<DiaDiem> Items = new List<DiaDiem>();
            Items.Add(new DiaDiem() { Area = "1.Bảo tàng tỉnh Phú Yên" });
            Items.Add(new DiaDiem() { Area = "2.Tháp Nhạn" });
            Items.Add(new DiaDiem() { Area = "3.Núi Chóp Chài" });
            Items.Add(new DiaDiem() { Area = "4.Bãi biển Tuy Hoà" });
            Items.Add(new DiaDiem() { Area = "5.Bãi biển Long Thuỷ" });
            Items.Add(new DiaDiem() { Area = "6.Hòn Chùa" });
            Items.Add(new DiaDiem() { Area = "7.Đầm Ô Hoa" });
            Items.Add(new DiaDiem() { Area = "8.Nhà thờ Mằng Lăng" });
            area_lvDataBinding.ItemsSource = Items;
        }
        public class Thanhvien
        {
            public string Name { get; set; }

        }
        public class DiaDiem
        {
            public string Area { get; set; }

        }
        public SeriesCollection Data1 => new SeriesCollection()
        {
            new PieSeries()
            {
                Values = new ChartValues<float> {60000 } , Title = "DeCao"
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {40000 } , Title = "Binz"
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {30000 } , Title = "ChauBui",
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {15000 } , Title = "Jolie",
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {15000 } , Title = "Thanh",
            }
        };
        private void PieChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            var chart1 = chartPoint.ChartView as PieChart;
            foreach (PieSeries pie in chart1.Series)
            {
                pie.PushOut = 0;
            }

            var neo = chartPoint.SeriesView as PieSeries;
            neo.PushOut = 30;
        }
        public SeriesCollection Data2 => new SeriesCollection()
        {
            new PieSeries()
            {
                Values = new ChartValues<float> {30000 } , Title = "DeCao"
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {50000 } , Title = "Binz"
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {20000 } , Title = "ChauBui",
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {15000 } , Title = "Jolie",
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {30000 } , Title = "Thanh",
            }
        };
        private void PieChart2_DataClick(object sender, ChartPoint chartPoint)
        {
            var chart2 = chartPoint.ChartView as PieChart;
            foreach (PieSeries pie in chart2.Series)
            {
                pie.PushOut = 0;
            }

            var neo = chartPoint.SeriesView as PieSeries;
            neo.PushOut = 30;
        }
        public SeriesCollection Data3 => new SeriesCollection()
        {
            new PieSeries()
            {
                Values = new ChartValues<float> {20000 } , Title = "DeCao"
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {50000 } , Title = "Binz"
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {30000 } , Title = "ChauBui",
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {25000 } , Title = "Jolie",
            },
            new PieSeries()
            {
                Values = new ChartValues<float> {50000 } , Title = "Thanh",
            }
        };
        private void PieChart3_DataClick(object sender, ChartPoint chartPoint)
        {
            var chart3 = chartPoint.ChartView as PieChart;
            foreach (PieSeries pie in chart3.Series)
            {
                pie.PushOut = 0;
            }

            var neo = chartPoint.SeriesView as PieSeries;
            neo.PushOut = 30;
        }
        private void Image_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var scr = new ImagePY();
            scr.ShowDialog();
        }
    }
}
