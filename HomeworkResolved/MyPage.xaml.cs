using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace HomeworkResolved
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Parent as NavigationWindow).Source = new Uri("https://www.google.com");
        }
    }
}
