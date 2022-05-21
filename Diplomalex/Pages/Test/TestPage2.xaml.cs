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
    /// Логика взаимодействия для TestPage2.xaml
    /// </summary>
    public partial class TestPage2 : Page
    {
        public TestPage2()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.box3.Navigate(new TestPage1());
        }

        private void Next_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            MessageBox.Show("В разработке", "Упс");
            this.label_text.Content += mainWindow.result.ToString();
        }
    }
}
