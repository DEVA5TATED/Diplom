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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplomalex.Pages.Test
{
    /// <summary>
    /// Логика взаимодействия для TestPage1.xaml
    /// </summary>
    public partial class TestPage1 : Page
    {
        public TestPage1()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это первая страница", "Упс");
        }

        private void Next_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.box3.Navigate(new TestPage2());

            if (this.true_rbtn_2.IsChecked == true)
            {
                mainWindow.result += 1;
            }
        }
    }
}
