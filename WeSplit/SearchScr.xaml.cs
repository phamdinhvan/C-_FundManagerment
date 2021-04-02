using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
    /// Interaction logic for SearchScr.xaml
    /// </summary>
    public partial class SearchScr : Window
    {
        List<DDL_travel> objtravelList;
        public SearchScr()
        {
            InitializeComponent();
            objtravelList = new List<DDL_travel>();
            AddElementsInList();
            BindtravelDropDown();
        }


        private void BindtravelDropDown()
        {
            ddltravel.ItemsSource = objtravelList;
        }
        private void ddlfood_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ddlfood_TextChanged(object sender, TextChangedEventArgs e)
        {
            ddltravel.ItemsSource = objtravelList.Where(x => x.travel_Name.StartsWith(ddltravel.Text.Trim()));
        }

        private void AllCheckbocx_CheckedAndUnchecked(object sender, RoutedEventArgs e)
        {
            BindListBOX();
        }

        private void BindListBOX()
        {
            testListbox.Items.Clear();
            foreach (var travel in objtravelList)
            {
                if (travel.Check_Status == true)
                {
                    testListbox.Items.Add(travel.travel_Name);
                }
            }
        }

        private void AddElementsInList()
        {
            // 1 element
            DDL_travel obj = new DDL_travel();
            obj.travel_ID = 1;
            obj.travel_Name = "Cà Mau";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 2;
            obj.travel_Name = "Hà Giang";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 3;
            obj.travel_Name = "Sa Pa";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 4;
            obj.travel_Name = "Cù Lao Chàm";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 5;
            obj.travel_Name = "A Pa Chải";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 6;
            obj.travel_Name = "Lạng Sơn";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 7;
            obj.travel_Name = "Phú Yên";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 8;
            obj.travel_Name = "Trần Binz";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 9;
            obj.travel_Name = "Bùi Văn Châu";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 10;
            obj.travel_Name = "Nguyễn Thế Bảo";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 11;
            obj.travel_Name = "De Thị Cao";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 12;
            obj.travel_Name = "Jolie Nguyễn";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 13;
            obj.travel_Name = "Sơn Tùng";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 14;
            obj.travel_Name = "Dương Hồng Thanh";
            objtravelList.Add(obj);
            obj = new DDL_travel();
            obj.travel_ID = 15;
            obj.travel_Name = "Châu Đăng Khoa";
            objtravelList.Add(obj);
           
        }

        private void testListbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            DDL_travel obj = new DDL_travel();
            obj.travel_Name = this.testListbox.SelectedItem.ToString();

            if (obj.travel_Name.Equals("Cà Mau"))
            {
                var a = new CaMau();
                a.ShowDialog();
            }
            else if (obj.travel_Name.Equals("Hà Giang"))
            {
                var b = new HaGiang();
                b.ShowDialog();
            }
            else if (obj.travel_Name.Equals("Sa Pa"))
            {
                var c = new SaPa();
                c.ShowDialog();
            }
            else if (obj.travel_Name.Equals("Phú Yên"))
            {
                var d = new PhuYen();
                d.ShowDialog();
            }
            else if (obj.travel_Name.Equals("Cù Lao Chàm"))
            {
                var g = new CuLaoCham();
                g.ShowDialog();
            }
            else if (obj.travel_Name.Equals("A Pa Chải"))
            {
                var f = new APaChai();
                f.ShowDialog();
            }
            else if (obj.travel_Name.Equals("Lạng Sơn"))
            {
                var h = new LangSon();
                h.ShowDialog();
            }
            else
            {
                var j = new ThanhVien();
                j.ShowDialog();
            }
        }
        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            var scr = new CreateScr();
            scr.ShowDialog();
        }
    }

    public class DDL_travel
    {
        public int travel_ID { get; set; }
        public string travel_Name { get; set; }
        public Boolean Check_Status { get; set; }
    }

}

