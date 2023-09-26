using System;

namespace NewCalculajtor
{
    internal class Program
    {
        public static float a;
        public static float b;
        public static double c;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Добро пожаловать в новейшую версию калькулятора, который уже на что-то способен)");
            Console.ResetColor();


            Console.WriteLine("Какое действие вы хотите совершить?");
            Console.WriteLine("Вот возможные действия: ");
            Console.WriteLine("+ сложение ");
            Console.WriteLine("- вычитание");
            Console.WriteLine("* умножение");
            Console.WriteLine("/ деление");
            Console.WriteLine("m модуль");
            Console.WriteLine("sin синус");
            Console.WriteLine("cos косинус");
            Console.WriteLine("tan тангенс");
            Console.WriteLine("ctg котангенс");
            Console.WriteLine("r вывод из квадратного корня");
            Console.WriteLine("q чтобы выйти");
            Console.WriteLine("Нажмите на любую кнопку, чтобы продолжить.");
            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                Console.WriteLine("Какое действие выполняем?");
                string f = Console.ReadLine();
                switch (f)
                {
                    case "+":
                        Summ();
                        break;
                    case "-":
                        Diff();
                        break;
                    case "*":
                        Mul();
                        break;
                    case "/":
                        Div();
                        break;
                    case "m":
                        Mod();
                        break;
                    case "M":
                        Mod();
                        break;
                    case "r":
                        Root();
                        break;
                    case "R":
                        Root();
                        break;
                    case "sin":
                        Sin();
                        break;
                    case "Sin":
                        Sin();
                        break;
                    case "cos":
                        Cos();
                        break;
                    case "Cos":
                        Cos();
                        break;
                    case "tan":
                        Tan();
                        break;
                    case "Tan":
                        Tan();
                        break;
                    case "ctg":
                        Ctg();
                        break;
                    case "Ctg":
                        Ctg();
                        break;
                    default:
                        Console.WriteLine("Извините, но вы ввели неизвестно что. Так и быть, вы можете попробоват ещё раз");
                        break;
                }
            }

        }
        static float Try()
        {
            float num;
            try
            {
                return num = Convert.ToSingle(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Я понятия не имею, что вы ввели, поэтомы мы услужливо подставили ноль. Не благодарите)");
                return 0;

            }
        }
        static void Summ()
        {
            Console.WriteLine("Введите первое число");
            a = Try();
            Console.WriteLine("Введите второе число");
            b = Try();
            c = a + b;
            Console.WriteLine("Ваш ответ: " + c);
        }

        static void Diff()
        {
            Console.WriteLine("Введите первое число");
            a = Try();
            Console.WriteLine("Введите второе число");
            b = Try();
            c = a - b;
            Console.WriteLine("Ваш ответ: " + c);
        }

        static void Mul()
        {
            Console.WriteLine("Введите первое число");
            a = Try();
            Console.WriteLine("Введите второе число");
            b = Try();
            c = a * b;
            Console.WriteLine("Ваш ответ: " + c);
        }

        static void Div()
        {
            Console.WriteLine("Введите первое число");
            a = Try();
            Console.WriteLine("Введите второе число");
            b = Try();
            c = a / b;
            Console.WriteLine("Ваш ответ: " + c);
        }

        static void Mod()
        {
            Console.WriteLine("Введите число");
            a = Try();
            c = Math.Abs(a);
            Console.WriteLine("Ваш ответ: " + c);
        }

        static void Sin()
        {
            Console.WriteLine("Введите угол");
            a = Try();
            Console.WriteLine("В чем измеряются ваши углы?  Rad or Deg");
            string e = Console.ReadLine();
            if (e == "Deg")
            {
                a = a / 57;
            }
            if (e == "deg")
            {
                a = a / 57;
            }
            if (e != "Rad")
            {
                if (e != "Deg")
                {
                    if (e != "rad")
                    {
                        if (e != "deg")
                        {
                            Console.WriteLine("Вы ввели неизвестно что, поэтому ваш угол будет измерятся в радианах. Не благодарите.");
                        }
                    }
                }
            }
            c = Math.Sin(a);
            Console.WriteLine("Ваш ответ: " + c);
        }

        static void Cos()
        {
            Console.WriteLine("Введите угол");
            a = Try();
            Console.WriteLine("В чем измеряются ваши углы?  Rad or Deg");
            string e = Console.ReadLine();
            if (e == "Deg")
            {
                a = a / 57;
            }
            if (e == "deg")
            {
                a = a / 57;
            }
            if (e != "Rad")
            {
                if (e != "Deg")
                {
                    if (e != "rad")
                    {
                        if (e != "deg")
                        {
                            Console.WriteLine("Вы ввели неизвестно что, поэтому ваш угол будет измерятся в радианах. Не благодарите.");
                        }
                    }
                }
            }
            c = Math.Cos(a);
            Console.WriteLine("Ваш ответ: " + c);
        }

        static void Tan()
        {
            Console.WriteLine("Введите угол");
            a = Try();
            Console.WriteLine("В чем измеряются ваши углы?  Rad or Deg");
            string e = Console.ReadLine();
            if (e == "Deg")
            {
                a = a / 57;
            }
            if (e == "deg")
            {
                a = a / 57;
            }
            if (e != "Rad")
            {
                if (e != "Deg")
                {
                    if (e != "rad")
                    {
                        if (e != "deg")
                        {
                            Console.WriteLine("Вы ввели неизвестно что, поэтому ваш угол будет измерятся в радианах. Не благодарите.");
                        }
                    }
                }
            }
            c = Math.Tan(a);
            Console.WriteLine("Ваш ответ: " + c);
        }

        static void Ctg()
        {
            Console.WriteLine("Введите угол");
            a = Try();
            Console.WriteLine("В чем измеряются ваши углы?  Rad or Deg");
            string e = Console.ReadLine();
            if (e == "Deg")
            {
                a = a / 57;
            }
            if (e == "deg")
            {
                a = a / 57;
            }
            if (e != "Rad")
            {
                if (e != "Deg")
                {
                    if (e != "deg")
                    {
                        if (e != "rad")
                        {
                            Console.WriteLine("Вы ввели неизвестно что, поэтому ваш угол будет измерятся в радианах. Не благодарите.");
                        }
                    }
                }
            }

            c = Math.Tan(a);
            c = 1 / c;
            Console.WriteLine("Ваш ответ: " + c);
        }

        static void Root()
        {
            Console.WriteLine("Введите число");
            a = Try();
            c = Math.Sqrt(a);
            Console.WriteLine("Ваш ответ: " + c);
        }
    }
}
