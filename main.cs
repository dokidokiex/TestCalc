namespace TestCalc
{
    internal class Program
    {

        private enum Operations : ushort
        {
            ProgramExit,
            CalcAddition,
            CalcSubtraction,
            CalcMultiplication,
            CalcDivision,
            CalcPower,
            _OpsEnd
        };

        static int MainLoop()
        {
            double first = 0, second = 0, result = 0;
            int power = 0;

            ushort choice;

            Console.WriteLine("Выберите операцию");

            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");
            Console.WriteLine("5 - Возведение в степень");
            Console.WriteLine("0 - Выход");

            Console.Write("Ваш выбор: ");

            if (!ushort.TryParse(Console.ReadLine(), out choice)) {
                Console.WriteLine(
                    $"Ошибка! Введите число от 0 до {(ushort)(Operations._OpsEnd - 1)}!"
                );
                return -1;
            }

            switch (choice)
            {
                case (ushort)Operations.CalcAddition:
                case (ushort)Operations.CalcSubtraction:
                case (ushort)Operations.CalcMultiplication:
                case (ushort)Operations.CalcDivision:
                    Console.Write("Введите первое число: ");

                    try
                    {
                        string? num = Console.ReadLine();

                        first = Convert.ToDouble(num);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Произошла ошибка: {e.Message}");

                        return -1;
                    }

                    Console.Write("Введите второе число: ");

                    try
                    {
                        string? num = Console.ReadLine();

                        second = Convert.ToDouble(num);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Произошла ошибка: {e.Message}");

                        return -1;
                    }

                    break;

                case (ushort)Operations.CalcPower:
                    Console.Write("Введите число: ");

                    try
                    {
                        string? num = Console.ReadLine();

                        first = Convert.ToDouble(num);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Произошла ошибка: {e.Message}");

                        return -1;
                    }

                    Console.Write("Введите степень: ");

                    try
                    {
                        string? num = Console.ReadLine();

                        power = Convert.ToInt32(num);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Произошла ошибка: {e.Message}");

                        return -1;
                    }

                    break;

                case (ushort)Operations.ProgramExit:
                    Console.WriteLine("Выход!");

                    return 0;

                default:
                    Console.WriteLine("Выбранной операции не существует!");
                    
                    return 1;
            }

            try
            {
                switch (choice)
                {
                    case (ushort)Operations.CalcAddition:
                        result = SmallMath.Addition(first, second);
                        break;
                    
                    case (ushort)Operations.CalcSubtraction:
                        result = SmallMath.Subtraction(first, second);
                        break;
                    
                    case (ushort)Operations.CalcMultiplication:
                        result = SmallMath.Multiplication(first, second);
                        break;
                    
                    case (ushort)Operations.CalcDivision:
                        if (second == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            return 1;
                        }

                        result = SmallMath.Division(first, second);
                        break;
                    
                    case (ushort)Operations.CalcPower:
                        result = SmallMath.Power(first, power);
                        break;

                    default:
                        /* This shouldn't happen */
                        throw new NotImplementedException();
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception e)
            {
                Console.Write(
                    "В результате выполнения произошла ошибка:\n" +
                    $"{e.Message}\n"
                );

                return 1;
            }

            return 1;
        }  
        static void Main(string[] args)
        {
            while (MainLoop() != 0)
            {
                
            }
        }
    }
}