using System;
using static System.Math;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Analysis a = new Analysis();
            
            for (int i = 0; i < 100; i++)
            {
                a.r = random.NextDouble();

                if (a.GetRandomNumber1(a.r) != a.GetRandomNumber2(a.r))
                {
                    //Console.WriteLine(a.r);
                    Console.WriteLine(a.r - 0.5);

                    Console.WriteLine();

                    /*
                     * если (random.NextDouble() - 0.5) возвращает число, который больше чем 0, 
                     * то в итоге метод возвращает меньшее ближайшее целое число 
                     * a.GetRandomNumber1(0.7133) => (0,2133 -> 0),
                     * а если (random.NextDouble() - 0.5) возвращает число, который меньше чем 0,
                     * тогда метод возвращает большее ближайшее целое число 
                     * a.GetRandomNumber1(0.2867) => (-0,2133 -> 0)
                     */
                    Console.WriteLine(a.GetRandomNumber1(a.r));

                    /*
                     * если (random.NextDouble() - 0.5) возвращает число, который больше чем 0, 
                     * то метод возвращает большее ближайшее целое число 
                     * a.GetRandomNumber2(0.7133) => (0.2133 -> 1),
                     * а если (random.NextDouble() - 0.5) возвращает число, который меньше чем 0,
                     * тогда метод возвращает меньшее ближайшее целое число 
                     * a.GetRandomNumber2(0.2867) => (-0.2133 -> -1)
                     */
                    Console.WriteLine(a.GetRandomNumber2(a.r));

                    Console.WriteLine(new string('-', 20));
                }
            }
        }
    }

    public class Analysis
    {
        /*
         * оба метода (GetRandomNumber1(),GetRandomNumber2()) возвращает целые числа в диапазоне -1,1
         * потому, что Random.NextDouble() возвращает случайное число в диапазоне 0,0 и 1,0,
         * тогда (random.NextDouble() - 0.5) возвращает максимум 0.5 и минимум -0.5,
         * потом если умножить на 2, то получим максимум 1 и минимум -1,
         * а если умножить на 2.99, то получим максимум 1.495 и минимум -1.495,
         * в конечном счете после округлении получим целое число -1, или 0, или 1,
         * потому, что метод System.Math.Round(x) только с одним аргументом округляет десятичное значение до ближайшего целого.
         */        
        public double r { get; set; }
                
        public double GetRandomNumber1(double x)
        {
            //Random random = new Random();
            return Round((x - 0.5) * 2);
        }
        public double GetRandomNumber2(double x)
        {
            //Random random = new Random();
            return Round((x - 0.5) * 2.99);
        }
    }
}
