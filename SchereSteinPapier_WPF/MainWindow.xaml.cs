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

namespace SchereSteinPapier_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Spiellogic myLogic;

        public MainWindow()
        {
            InitializeComponent();
            myLogic = new Spiellogic();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buttonStein.IsEnabled = false;
            buttonPapier.IsEnabled = false;
            macheZug();
        }



        private void macheZug()
        {
            switch (myLogic.macheSpielzug())
            {
                case 1:
                    label1.Content = "Schere";
                    break;

                case 2:
                    label1.Content = "Stein";
                    break;

                case 3:
                    label1.Content = "Papier";
                    break;

                default:
                    break;
            }
        }

        private void ButtonStein_Click(object sender, RoutedEventArgs e)
        {
            buttonSchere.IsEnabled = false;
            buttonPapier.IsEnabled = false;
            macheZug();
        }

        private void ButtonPapier_Click(object sender, RoutedEventArgs e)
        {
            buttonSchere.IsEnabled = false;
            buttonStein.IsEnabled = false;
            macheZug();
        }
    }
}
