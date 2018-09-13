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

        private int DRResult = 0;

        private int NumberLength;

        private int GetLengthOfNumber(int i)
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException();
            if (i == 0)
                return 1;
            return (int) Math.Floor(Math.Log10(i)) + 1;
        }

        public int GetDigitalRoot(int number)
        {
            Number = number;

            NumberLength = GetLengthOfNumber(Number);

            Console.WriteLine($"Length {NumberLength}");

            return DRResult;
        }

    }
}
