using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _22._11_Практика_Задание_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Interaction.InputBox("Введите ваше имя",
                "Ввод имени");
            string age;
            age = Interaction.InputBox("Введите ваш возраст",
                "Ввод возраста");
            string txt = "Имя: " + name + ", Возраст: " + age;
            MessageBox.Show(txt, "Итог:");

        }
    }
}