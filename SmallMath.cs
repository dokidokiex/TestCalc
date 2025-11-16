namespace TestCalc
{
    public static class SmallMath
    {
        public static double Addition(double first, double second)
        {
            return first + second;
        }

        public static double Subtraction(double first, double second)
        {
            return first - second;
        }

        public static double Multiplication(double first, double second)
        {
            return first * second;
        }

        public static double Division(double first, double second)
        {
            return first / second;
        }

        public static double Power(double number, int power)
        {
            double result = number;

            if (power == 0)
            {
                return 1;
            }

            for (int i = 1; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}