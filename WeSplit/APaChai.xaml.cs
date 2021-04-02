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
    /// Interaction logic for APaChai.xaml
    /// </summary>
    public partial class APaChai : Window
    {
        public APaChai()
        {
            InitializeComponent();
            DataContext = this;
            List<Thanhvien> items = new List<Thanhvien>();
            items.Add(new Thanhvien() { Name = "Trần Binz (Trưởng Nhóm)" });
            items.Add(new Thanhvien() { Name = "De Thị Cao" });
            items.Add(new Thanhvien() { Name = "Bùi Văn Châu" });
            items.Add(new Thanhvien() { Name = "Jolie Nguyễn" });
            items.Add(new Thanhvien() { Name = "Dương Tuấn Thanh" });
            lvDataBinding.ItemsSource = items;
            List<DiaDiem> Items = new List<DiaDiem>();
            Items.Add(new DiaDiem() { Area = "1.Mường Nhé" });
            Items.Add(new DiaDiem() { Area = "2.Sín Thầu" });
            Items.Add(new DiaDiem() { Area = "3.Đồn 317" });
            Items.Add(new DiaDiem() { Area = "4.Núi Khoang La San" });
            Items.Add(new DiaDiem() { Area = "5.Chợ Phiên A Pa Chải" });
            Items.Add(new DiaDiem() { Area = "6.Mốc Biên giới Việt Nam - Trung Quốc số 2 và số 3" });
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
                Values = new ChartValues<float> {60000 } , Title = "Binz"
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
                Values = new ChartValues<float> {15000 } , Title = "Thanh",
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
            var scr = new ImageApachai();
            scr.ShowDialog();
        }
    }
}
