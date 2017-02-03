using System;

namespace Projecteuler
{

    // Multiples of 3 and 5

    public class Ex01
    {
        public int GetCalculatedSum() {
            int sum = 0;
            for (int i = 0; i < 1000; i++) {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            return sum;
        }
    }
}
