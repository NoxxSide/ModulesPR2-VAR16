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
    public partial class Zadanie5 : Window
    {
        public Zadanie5()
        {
            InitializeComponent();
        }
        private void Расчёт_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(ПолеN.Text);
                int M = int.Parse(ПолеM.Text);

                Random rng = new Random();
                int total = N * M;
                int[] arr = new int[total];

                for (int i = 0; i < total; i++)
                {
                    arr[i] = rng.Next(-10, 11);
                }

                string original = "";
                for (int i = 0; i < total; i++)
                {
                    original += arr[i] + "\t";
                    if ((i + 1) % M == 0) original += "\n"; 
                }
                Исходная.Text = original;

                Array.Sort(arr);

                МинМакс.Text = $"Минимальны: {arr[0]}, Максимальны: {arr[total - 1]}";

                string asc = "";
                for (int i = 0; i < total; i++)
                {
                    asc += arr[i] + "\t";
                    if ((i + 1) % M == 0) asc += "\n";
                }
                Возрастающая.Text = asc;

                string des = "";
                int count = 0;
                for (int i = total - 1; i >= 0; i--)
                {
                    des += arr[i] + "\t";
                    count++;
                    if (count % M == 0) des += "\n";
                }
                Убывающая.Text = des;
            }
            catch
            {
                МинМакс.Text = "ошибка. Введите целые числа N и M.";
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
