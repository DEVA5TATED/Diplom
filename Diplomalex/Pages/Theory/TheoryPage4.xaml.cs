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

using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Diplomalex.Pages.Theory
{
    /// <summary>
    /// Логика взаимодействия для TheoryPage4.xaml
    /// </summary>
    public partial class TheoryPage4 : Page
    {
        public TheoryPage4()
        {
            InitializeComponent();

            String file = "../../Resources/t4.pdf";

            PdfReader pdf_Reader = new PdfReader(file);
            String sText = "";

            for (int i = 1; i <= pdf_Reader.NumberOfPages; i++)

            {

                sText += PdfTextExtractor.GetTextFromPage(pdf_Reader, i);


            }

            lblPDF_Output.Text = sText;
        }
        private void Next_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.box.Navigate(new TheoryPage5());
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.box.Navigate(new TheoryPage3());
        }
    }
}
