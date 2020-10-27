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
using System.Threading;

namespace FactorialHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateFactorial(object sender, RoutedEventArgs e)
        {
            int number = 0;
            long factorial = 1;

            if (int.TryParse(numberTextBox.Text, out number))
            {
                ThreadPool.QueueUserWorkItem(state =>
                {

                    //if (number == 0)
                    //{
                    //    factorial = 1;
                    //}
                    //else
                    //{
                    //    for (int i = 1; i <= number; i++)
                    //    {
                    //        factorial *= i;
                    //    }
                    //}
                    factorial = Factorial(number);

                    MessageBox.Show($"Факториал числа {number} = {factorial}");
                    MessageBox.Show("Вычисление завершено");
                });

            }
            else
            {
                MessageBox.Show("Ошибка! Повторите ввод");
            }
        }

        static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
