using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SelectionSort
    {
        //Selection sort algorithm N^2
        public int[] Sort(int[] arrayToBeSorted)
        {           
            for(var i = 0; i<arrayToBeSorted.Length; i++)
            {
                var miniumValue = i;
                for(var j = i+1; j<arrayToBeSorted.Length; j++)
                {
                    if(arrayToBeSorted[miniumValue] > arrayToBeSorted[j])
                    {
                        miniumValue = j;
                    }
                }
                if(miniumValue != i)
                {
                    var lowValue = arrayToBeSorted[miniumValue];
                    arrayToBeSorted[miniumValue] = arrayToBeSorted[i];
                    arrayToBeSorted[i] = lowValue;
                }
            }
            return arrayToBeSorted;
        }
    }
}
