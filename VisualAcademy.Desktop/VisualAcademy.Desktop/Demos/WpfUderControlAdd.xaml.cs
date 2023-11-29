using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VisualAcademy.Desktop.Demos
{
    /// <summary>
    /// WpfUderControlAdd.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WpfUderControlAdd : Window
    {
        public WpfUderControlAdd()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            // 동적으로 FileMenu.xmal 사용자 정의 컨트롤을 thePanel 영역에 추가
            FileMenu fm = new FileMenu();
            thePanel.Children.Clear();
            thePanel.Children.Add(fm);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var fe = new FileEdit();
            thePanel.Children.Clear();
            thePanel.Children.Add(fe);
        }
    }
}
