using System;
namespace Calculator
{
    class Program
    {
        static void Main()
        {
            bool Using = true;
            Console.WriteLine("Калькулятор");
            while (Using)
            {
                Console.WriteLine("Выберите операцию* из списка:");
                Console.WriteLine("Сложение\nВычитание\nУмножение\nДеление\nВыход");
                Console.WriteLine("*Операцию следует писать с большой буквы");
                switch (Console.ReadLine())
                {
                    case "Сложение":
                        Console.WriteLine("Введите первое слагаемое:");
                        long addend1 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Введите второе слагаемое:");
                        long addend2 = Convert.ToInt64(Console.ReadLine());
                        long AdditionResult = addend1 + addend2;
                        Console.WriteLine("Результат:\n" + AdditionResult);
                        Continue();
                        break;
                    case "Вычитание":
                        Console.WriteLine("Введите уменьшаемое:");
                        long minuend = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Введите вычитаемое:");
                        long subtrahend = Convert.ToInt64(Console.ReadLine());
                        long SubtractionResult = minuend - subtrahend;
                        Console.WriteLine("Результат:\n" + SubtractionResult);
                        Continue();
                        break;
                    case "Умножение":
                        Console.WriteLine("Введите первый множитель:");
                        long factor1 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Введите второй множитель:");
                        long factor2 = Convert.ToInt64(Console.ReadLine());
                        long MultiplicationResult = factor1 * factor2;
                        Console.WriteLine("Результат:\n" + MultiplicationResult);
                        Continue();
                        break;
                    case "Деление":
                        Console.WriteLine("Введите делимое:");
                        long dividend = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Введите делитель:");
                        long devisor = Convert.ToInt64(Console.ReadLine());
                        long DevisionResult = dividend / devisor;
                        Console.WriteLine("Результат:\n" + DevisionResult);
                        Continue();
                        break;
                    case "Выход":
                        Using = false;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Нажмите любую клавишу что-бы выйти из программы");
            Console.ReadKey();
            Environment.Exit(0);
            void Continue()
            {
                Console.WriteLine("Нажмите любую клавишу что-бы продолжить");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
