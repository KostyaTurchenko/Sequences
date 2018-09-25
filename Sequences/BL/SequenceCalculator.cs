using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public partial class SequenceCalculator
    {
        public double X { get; set; }
        public int N { get; set; }
        public double E { get; set; }

        public int NLimited { get; private set; }

        public double Fault { get; private set; }

        public SequenceCalculator(double X, int N)
        {
            this.X = X;
            this.N = N;
        }

        private double Factorial(int numb)
        {
            double result = 1;
            for (int i = numb; i > 1; i--)
                result *= i;
            return result;
        }

        public double GetPartialSum ()
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += Math.Pow(-1, i) * Math.Pow(X, i) / Factorial(i);
            }

            Fault = Math.Abs(Math.Pow(Math.E, -X) - sum);

            return sum;
        }

        public double GetSumLimitedE (int multiplier)
        {
            double EComparable = E * multiplier;
            double sum = 0;
            double term = 0;
            int counter = 0;
            for (int i = 0; i < 10000; i++)
            {
                term = Math.Pow(-1, i) * Math.Pow(X, i) / Factorial(i);
                if (Math.Abs(term) > EComparable)
                {
                    sum += term;
                    counter++;
                }
                else
                    continue;
            }
            NLimited = counter;

            return sum;

        }

        public double CompareFaultAndLast() => Fault - Math.Abs(Math.Pow(-1, N) * Math.Pow(X, N) / Factorial(N));



    }
}
