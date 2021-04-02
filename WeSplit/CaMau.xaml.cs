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
    /// Interaction logic for CaMau.xaml
    /// </summary>
    public partial class CaMau : Window
    {
        public CaMau()
        {
            InitializeComponent();
            DataContext = this ;
            List<Thanhvien> items = new List<Thanhvien>();
            items.Add(new Thanhvien() { Name = "Trần Binz (Trưởng Nhóm)" });
            items.Add(new Thanhvien() { Name = "De Thị Cao" });
            items.Add(new Thanhvien() { Name = "Bùi Văn Châu" });
            items.Add(new Thanhvien() { Name = "Jolie Nguyễn" });
            items.Add(new Thanhvien() { Name = "Nguyễn Thế Bảo" });
            lvDataBinding.ItemsSource = items;
            List<DiaDiem> Items = new List<DiaDiem>();
            Items.Add(new DiaDiem() { Area = "1.Đất Mũi" });
            Items.Add(new DiaDiem() { Area = "2.Sân Chim Ngọc Hiển" });
            Items.Add(new DiaDiem() { Area = "3.Biển Khai Long" });
            Items.Add(new DiaDiem() { Area = "4.Đảo Hòn Khoai" });
            Items.Add(new DiaDiem() { Area = "5.Hòn Đá Bạc" });
            Items.Add(new DiaDiem() { Area = "6.Vườn Chim Tư Na Năm Căn" });
            Items.Add(new DiaDiem() { Area = "7.Vườn Chim Thành Phố Cà Mau" });
            Items.Add(new DiaDiem() { Area = "8.Đầm Thị Tường" });
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
                Values = new ChartValues<float> {50000 } , Title = "DeCao"
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
                Values = new ChartValues<float> {15000 } , Title = "Bảo",
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
                Values = new ChartValues<float> {15000 } , Title = "Bảo",
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
                Values = new ChartValues<float> {15000 } , Title = "Bảo",
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
            var scr = new ImageCM();
            scr.ShowDialog();
        }
    }
}
