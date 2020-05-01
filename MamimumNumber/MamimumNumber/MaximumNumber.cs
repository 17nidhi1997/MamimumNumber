using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MamimumNumber
{
   class MaximumNumber
    {
          //Generic method for all kinds of data to pass
            public GTYPE maxValueArray<GTYPE>(GTYPE firstValue, GTYPE secondValue, GTYPE thirdValue)
            {
                GTYPE[] maxNumber = { firstValue, secondValue, thirdValue };
                //Finding The Maximum GTYPE Array[integer,double,string]
                GTYPE MaxValue = maxNumber.Max();
                return MaxValue;
            }


        
    }
}
