using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WeSplit
{
    /// <summary>
    /// Interaction logic for CreateScr.xaml
    /// </summary>
    public partial class CreateScr : Window
    {
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\New.txt";
        public CreateScr()
        {
            InitializeComponent();
        }

        private void save_Button_Click(object sender, RoutedEventArgs e)
        {
            saveFile(textName.Text, text_tv.Text, text_khoanchi.Text);
        }
        public void saveFile(string name, string thanhvien, string khoanchi)
        {
            string Msg = name + "\n" + thanhvien + "\n" + khoanchi;
            // Save File to .txt
            //FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
            //StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            //m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End );
            //m_WriterParameter.Write(Msg);
            //m_WriterParameter.Flush();
            using (StreamWriter sw = new StreamWriter("New.txt", true))
            {
                sw.WriteLine(Msg.ToString().Trim() + Environment.NewLine);               
            }
            MessageBox.Show("Đã thêm chuyến đi thành công", " ");
            
        }

    }
}
