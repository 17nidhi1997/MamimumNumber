using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MamimumNumber
{
    class MaximumNumber<GTYPE>
    {
        GTYPE firstValue, secondValue, thirdValue;
        //Generic method for all kinds of data to pass
        public MaximumNumber(GTYPE firstValue, GTYPE secondValue, GTYPE thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public GTYPE TestMaximum()
        {
            return maxValueArray(firstValue, secondValue, thirdValue);
        }
        public static GTYPE maxValueArray(GTYPE firstValue, GTYPE secondValue, GTYPE thirdValue)
        {
            GTYPE[] maxNumber = { firstValue, secondValue, thirdValue };
            //Finding The Maximum GTYPE Array[integer,double,string]
            GTYPE MaxValue = maxNumber.Max();
            return MaxValue;
        }
    }
}
