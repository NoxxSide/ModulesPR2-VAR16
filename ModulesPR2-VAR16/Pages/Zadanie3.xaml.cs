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
    public partial class Zadanie3 : Window
    {
        public Zadanie3()
        {
            InitializeComponent();
        }
        private void Расчёт_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] num = Поле_ввода.Text
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (num.Length < 3)
                {
                    Ответ.Text = "Ошибка: введите хотя бы 3 числа";
                    return;
                }

                Array.Sort(num);

                int big = num.Length - 1;

                int plus = num[big] * num[big - 1] * num[big - 2]; //Проверка для положительных чисел

                int minus = num[0] * num[1] * num[big]; //Проверка для отрицательных чисел
                if (plus > minus)
                {
                    Ответ.Text = $"{num[big - 2]}, {num[big - 1]}, {num[big]}";
                }
                else
                {
                    Ответ.Text = $"{num[0]}, {num[1]}, {num[big]}";
                }
            }
            catch
            {
                Ответ.Text = "Ошибка( нужно ввести только целые числа через пробел)";
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
