using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Viev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте, вас приветствует программа \"Электронная кошка!\" \n\n" +
                              "Введите желаемый возвраст кошки: ");

            var age = int.Parse(Console.ReadLine());
            var catColor = new CatColor
            {
                HeathyColor = "Белый",
                SickColor = "Зелёный"
            };
            var cat = new Cat(age, catColor);

            var flag1 = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Состояние кошки:\n Имя кошки: {0}\n Возраст кошки: {1}\n Текущий цвет кошки: {2}\n",
                        cat.Name, cat.Age, cat.CurrentColor);

                Console.WriteLine("Вводите команды для перемещения по меню программы:");
                Console.WriteLine("1) Задать имя \n" + "2) Задать цвет \n" + "3) Ударить \n" + "4) Покормить \n" +
                                  "5) Выйти из программы \n");

                var switch1 = 0;
                try
                {
                    switch1 = int.Parse(Console.ReadLine());
                }
                catch (Exception){/* ignored*/}

                switch (switch1)
                {
                    case 1:
                    {
                        if (flag1 == 0)
                        {
                            Console.Write("Введите имя кошки: ");
                            cat.Name = Console.ReadLine();
                            flag1 = 1;
                        }
                        else
                        {
                            Console.WriteLine("Изивините, у вашей кошки уже есть имя, она должна привыкнуть к нему!");
                            Console.WriteLine("Нажмите любую клавишу для продолжения");    
                            Console.ReadKey();
                        }
                        break;
                    }
                    case 2:
                    {
                        Console.Write("Введите цвет здоровой кошки: ");
                        cat.Color.HeathyColor = Console.ReadLine();
                        Console.Write("Введите цвет больной кошки: ");
                        cat.Color.SickColor = Console.ReadLine();  
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Вы наказали свою кошку, её здоровье уменшилось на 1");
                        cat.Punish();
                        Console.ReadKey();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Вы покормили свою кошку, её здоровье увеличилось на 1");
                        cat.Feed();
                        Console.ReadKey();
                        break;
                    }
                    case 5:
                    {
                        return;
                    }
                }
            }
        }
    }
}
