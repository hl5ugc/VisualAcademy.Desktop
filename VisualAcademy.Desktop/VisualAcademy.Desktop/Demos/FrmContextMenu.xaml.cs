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

namespace VisualAcademy.Desktop.Demos
{
    /// <summary>
    /// FrmContextMenu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FrmContextMenu : Window
    {
        public FrmContextMenu()
        {
            InitializeComponent();
            miSecond.Click += new RoutedEventHandler(miSecond_Click);
            miThird.Click += (s, e) => { MessageBox.Show("세번째 "); };
        }

        private void miFisrt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("첫번째 메뉴 클릭됨");
        }

        private void miSecond_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("두번째 메뉴 클릭됨");
            if(miFisrt.IsChecked == true)
            {
                miThird.IsEnabled = true;
                miFisrt.IsChecked = false;

            }
            else
            {
                miThird.IsEnabled = false;
            }
             
        }
 
    }
}
