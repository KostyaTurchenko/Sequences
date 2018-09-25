using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BL;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");

            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());


            SequenceCalculator MyCalc = new SequenceCalculator(x, n);


            Console.WriteLine("Частичная сумма = {0}", MyCalc.GetPartialSum());
            Console.WriteLine("Погрешность = {0}", MyCalc.Fault);
            Console.WriteLine("Разница между погрешностью и N-го слагаемого = {0}", MyCalc.CompareFaultAndLast());
            Console.WriteLine("Значение e^(-{0}) = {1}",x, Math.Pow(Math.E, -x));


            Console.WriteLine(new String('-', 65));


            Console.WriteLine("task 2");

            Console.WriteLine("Введите E: ");
            MyCalc.E = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите x: ");
            MyCalc.X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cумма слагаемых больше E = {0}", MyCalc.GetSumLimitedE(1));
            Console.WriteLine("Количество таких слагаемых = {0}", MyCalc.NLimited);
            Console.WriteLine("Сумма слагаемых больше E*10 = {0}", MyCalc.GetSumLimitedE(10));



        }
    }
}
