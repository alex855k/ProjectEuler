using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecteuler
{
    public class Ex02
    {
        public int GetCalculatedSum() {
            int sum = 0;
            int first = 0;
            int second = 1;
            int current = 0;
            int counter = 0;
            while (sum < 4000000)
            {
                counter++;
                current = first + second;
                first = second;
                second = current;

                Console.WriteLine("#{1} Fibonacci Nb: {0}", current, counter);
                if (current % 2 != 0) sum += current;
            }
            return sum;
        }
    }
}
