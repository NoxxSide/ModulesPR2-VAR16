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

namespace ModulesPR2_VAR16
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Zadanie1 z1 = new Zadanie1();

            z1.Show();

            this.Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Zadanie2 z2 = new Zadanie2();

            z2.Show();

            this.Close();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Zadanie3 z3 = new Zadanie3();

            z3.Show();

            this.Close();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {

            Zadanie4 z4 = new Zadanie4();

            z4.Show();

            this.Close();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {

            Zadanie5 z5 = new Zadanie5();

            z5.Show();

            this.Close();
        }
    }
}
