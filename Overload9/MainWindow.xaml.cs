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

namespace Overload9
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

        private void guh(TextBox textBox, TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            prg prg1 = new prg(); // создаю экземпляр класса
            List<int> ls = new List<int>(); // создаю список чисел
            List<TextBox> knopki = new List<TextBox>(); // создаю список кнопок

            knopki.Add(textBox); // добавляю  текстбокс в список
            knopki.Add(textBox1); // добавляю  текстбокс в список
            knopki.Add(textBox2); // добавляю текстбокс в список
            knopki.Add(textBox3); // добавляю текстбокс в список

            for (int i = 0; i < knopki.Count(); i++) // цикл для заполнения списка
            { 
                if (Int32.TryParse(knopki[i].Text, out int g)) 
                { 
                    ls.Add(g); 
                }
            }

            switch (ls.Count())
            {
                case 1:
                    label1.Content = prg1.OPTA(ls[0]); // первая перегрузка
                    return;
                case 2:
                    label1.Content = prg1.OPTA(ls[0], ls[1]); // вторая перегрузка
                    return;
                case 3:
                    label1.Content = prg1.OPTA(ls[0], ls[1], ls[2]); // третья перегрузка
                    return;
                case 4:
                    label1.Content = prg1.OPTA(ls[0], ls[1], ls[2], ls[3]); // четвертая перегрузка
                    return;
                default:
                    return;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            guh(textBox, textBox1, textBox2, textBox3); // вызываю метод
        }
    }
}
