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
            Console.WriteLine("Здравствуйте, вас приветствует программа электронная кошка!");
            Console.Write("Введите желаемый возвраст кошки: ");
            var age = Console.ReadLine();

            var catColor = new CatColor
            {
                HeathyColor = "Белый",
                SickColor = "Зелёный"
            };

            var cat = new Cat(age, catColor) {Color = catColor};
            cat.CurrentColor = cat.Color.HeathyColor;

            var flag1 = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Состояние кошки");
                Console.WriteLine("Имя кошки: {0}", cat.Name);
                Console.WriteLine("Возраст кошки: {0}", cat.GetAge());
                Console.WriteLine("Текущий цвет кошки: {0}", cat.CurrentColor);
                Console.WriteLine();

                Console.WriteLine("Вводите команды для перемещения по меню программы");
                Console.WriteLine("1) Задать имя");
                Console.WriteLine("2) Задать цвет");
                Console.WriteLine("3) Ударить");
                Console.WriteLine("4) Покормить");
                Console.WriteLine("5) Выйти из программы");

                var switch1 = 0;
                try
                {
                    switch1 = int.Parse(Console.ReadLine());
                }catch (Exception){}

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
                            //Хотя кошкам без разницы, они идут на голос, а не на имя.
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

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, вас приветствует программа электронная кошка!");
            Console.Write("Введите желаемый возвраст кошки: ");
            var age = Console.ReadLine();
            var cat = new Cat(age);

            var catColor = new CatColor
            {
                HeathyColor = "Белый",
                SickColor = "Зелёный"
            };
            cat.Color = catColor;
            cat.CurrentColor = cat.Color.HeathyColor;

            var flag1 = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Состояние кошки");
                Console.WriteLine("Имя кошки: {0}", cat.Name);
                Console.WriteLine("Возраст кошки: {0}", age);
                Console.WriteLine("Текущий цвет кошки: {0}", cat.CurrentColor);
                Console.WriteLine();

                Console.WriteLine("Вводите команды для перемещения по меню программы");
                Console.WriteLine("1) Задать имя");
                Console.WriteLine("2) Задать цвет");
                Console.WriteLine("3) Ударить");
                Console.WriteLine("4) Покормить");
                Console.WriteLine("5) Выйти из программы");

                var switch1 = 0;
                try
                {
                    switch1 = int.Parse(Console.ReadLine());
                }catch (Exception){}

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
                            //Хотя кошкам без разницы, они идут на голос, а не на имя.
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
