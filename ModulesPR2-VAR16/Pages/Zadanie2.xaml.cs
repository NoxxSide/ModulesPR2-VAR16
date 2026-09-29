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
    public partial class Zadanie2 : Window
    {
        public Zadanie2()
        {
            InitializeComponent();
        }
        private void Расчёт_Click(object sender, RoutedEventArgs e)
        {
            string inputText = Поле_ввода.Text;

            int res = Skobki(inputText);

            if (res == 0)
            {
                Ответ.Text = "0";
            }
            else if (res == -1)
            {
                Ответ.Text = "-1";
            }
            else
            {
                Ответ.Text = $"На позиции {res} лишняя закрывающая скобка";
            }
        }

        public static int Skobki(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    sum++;
                }
                else if (input[i] == ')')
                {
                    sum--;

                    if (sum < 0)
                    {
                        return i + 1;
                    }
                }
            }

            if (sum > 0)
            {
                return -1;
            }

            return 0;
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            main.Show();

            this.Close();
        }
    }
}
