using System;

namespace Interview
{
    public class Analysis
    {
        /*
         * оба метода возвращает целые числа в диапазоне -1,1
         * потому, что Random.NextDouble() возвращает случайное число в диапазоне 0,0 и 1,0,
         * тогда (random.NextDouble() - 0.5) возвращает максимум 0.5 и минимум -0.5,
         * потом если умножить на 2, то получим максимум 1 и минимум -1,
         * а если умножить на 2.99, то получим максимум 1.495 и минимум -1.495,
         * в конечном счете после округлении получим целое число -1, или 0, или 1,
         * потому, что метод System.Math.Round(x) только с одним аргументом округляет десятичное значение до ближайшего целого.
         */
        public double GetRandomNumber1()
        {
            Random random = new Random();
            return System.Math.Round((random.NextDouble() - 0.5) * 2);
        }
        public double GetRandomNumber2()
        {
            Random random = new Random();
            return System.Math.Round((random.NextDouble() - 0.5) * 2.99);
        }
    }
}
