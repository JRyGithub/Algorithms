using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class InsertionSort
    {
        public int[] Sort(int[] arrayToBeSorted)
        {
       
            for(int i = 0; i<arrayToBeSorted.Length; i++)
            {
                var currentItem = arrayToBeSorted[i];
                var indexToBePlaced = i;

                while(indexToBePlaced > 0 && arrayToBeSorted[indexToBePlaced-1] > currentItem)
                {
                    arrayToBeSorted[indexToBePlaced] = arrayToBeSorted[indexToBePlaced-1];
                    indexToBePlaced--;
                }
                arrayToBeSorted[indexToBePlaced] = currentItem;
            }

            return arrayToBeSorted;
        }
    }
}
