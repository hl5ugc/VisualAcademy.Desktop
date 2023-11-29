using System.Windows;

namespace VisualAcademy.Desktop.Demos
{
    /// <summary>
    /// FrmHelloworld.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FrmHelloworld : Window
    {
        public FrmHelloworld()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = $"안녕 하세요 {DateTime.Now.Second}";
            }
            else
            {
                txtDisplay.Text = string.Empty;
            }
        }
    }
}
