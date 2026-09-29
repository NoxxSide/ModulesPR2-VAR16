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
    public partial class Zadanie1 : Window
    {
        public Zadanie1()
        {
            InitializeComponent();
        }
        private void Расчёт_Click(object sender, RoutedEventArgs e)
        {
            int year = Convert.ToInt32(Поле_для_ввода_даты.Text);
            if (year > 0)
            {
                int cent = (year - 1) / 100 + 1;

                Ответ.Text = $"{cent} век";
            }
            else
            {
                Ответ.Text = "Некорректное число";
            }

        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            main.Show();

            this.Close();
        }
    }
}
