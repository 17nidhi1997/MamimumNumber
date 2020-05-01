using System;
using System.Collections.Generic;
using System.Text;

namespace MamimumNumber
{
    class MaximumNumber
    {
        //Find the Maximun Integer Number
        public int maximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            //Comparing firstvalue with second and third value
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            //Comparing secondvalue with first and third value
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            //Comparing thirdvalue with first and second value
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            else
            {
                return 0;
            }
        }
    }
}
