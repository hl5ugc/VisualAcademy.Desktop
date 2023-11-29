using System.Windows;

namespace VisualAcademy.Desktop.CandidateApp
{
    /// <summary>
    /// CandidateManager.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CandidateManager : Window
    {
        public CandidateManager()
        {
            InitializeComponent();
        }

        private void btnAddCandidate_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("직원 후보자 추가");
            btnAddCandidate.Content = $"직원 후보자 추가 완료 {DateTime.Now.Second}";
        }
    }
}
