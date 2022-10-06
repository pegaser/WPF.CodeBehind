using System.Windows;
using System.Windows.Controls;

namespace Practice
{
    /// <summary>
    /// Lógica de interacción para MyPage.xaml
    /// </summary>
    public partial class MyPage : Page
    {
        public MyPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lblTitle.Text = "Mi Título";
            lblContent.Text = "Mi contenido";
        }
    }
}
