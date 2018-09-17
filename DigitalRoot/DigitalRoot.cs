using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class DigitalRoot
    {
        // TODO Need to change this to support floating points
        private int Number;

        private int Result = 0;

        private int NumberLength;

        private int GetLengthOfNumber(int i)
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException("GetLengthOfNumber", "Number is zero.");
            if (i == 0)
                return 1;
            return (int)Math.Floor(Math.Log10(i)) + 1;
        }

        private int[] GetDigits(int number)
        {

            int[] numbers = new int[NumberLength];

            for (int i = 0; i < NumberLength; i++)
            {

                numbers[i] = number % 10;
                number /= 10;
            }

            return numbers;
        }

        private int Sum(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            return total;
        }

        public int GetValue(int number)
        {
            Number = number;
            NumberLength = GetLengthOfNumber(Number);
            do
            {
                int[] numbers = GetDigits(Number);
                Result = Sum(numbers);
                NumberLength = GetLengthOfNumber(Result);
                Number = Result;
            } while (NumberLength > 1);

            return Result;
        }

    }
}
