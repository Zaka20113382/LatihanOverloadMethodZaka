using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadmethod
{
    class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int hasil;
            if (number2 < number1)
                hasil = number2;
            else
                hasil = number1;
            return hasil;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            int hasil;
            if (number3 < number2)
                hasil = (int)number3;
            else
            if (number2 < number1)
                hasil = number2;
            else
                hasil = number1;
            return hasil;
        }
        public int FindMaximum(int number1, int number2)
        {
            int hasil;
            if (number2 > number1)
                hasil = number2;
            else
                hasil = number1;
            return hasil;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            int hasil;
            if (number3 > number2)
                hasil = (int)number3;
            else
                if (number2 > number1)
                hasil = number2;
            else
                hasil = number1;
            return hasil;
        }
    }
}
