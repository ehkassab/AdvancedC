using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC.DS_Book
{
    public class SortingAlgos
    {
        #region SelectionSort
        /*
         *  1- get index of first element
         *  2- get value for first element
         *  3- loop through array till find element with value less than currnt value
         *  4- swap
         *  5- do again from next index
         *  6- O(n2)
         */

        public static void SelectionSort(int[] unsortedlist)
        {
            int _MinIndx = 0;
            int _MinValueFound = 0;
            // start loop first get new min value
            for (int mainIndex = 0; mainIndex < unsortedlist.Length; mainIndex++)
            {
                _MinIndx = mainIndex;
                // mainIndex+1 to start from element beside currnt one
                for (int remainingIndex = mainIndex + 1; remainingIndex < unsortedlist.Length; remainingIndex++)
                {
                    if (unsortedlist[remainingIndex] < unsortedlist[mainIndex])
                    {
                        _MinIndx = remainingIndex;
                    }
                }
                //do Swap
                _MinValueFound = unsortedlist[_MinIndx];
                unsortedlist[_MinIndx] = unsortedlist[mainIndex];
                unsortedlist[mainIndex] = _MinValueFound;
            }

            for (int i = 0; i < unsortedlist.Length; i++)
            {
                Console.WriteLine("crntVal : " + unsortedlist[i]);
            }
        }
        #endregion

        #region InsertionSort
        /*
         *  1- get index of first element
         *  2- get value for first element
         *  3- loop back to the previous element
         *  4- compare if less than swap
         *  5- do again till elementp[0]
         *  6- O(n2) Quadrtic Time.
         */
        public static void InsertionSort(int[] unsortedlist)
        {
            int i = 1; // start in second element
            int j = i; // this becaure i will initiatly compare second element with itself.
            int temp = 0; // used in swaping.
            while (j > 0 && unsortedlist[j-1] > unsortedlist[j])
            {
                //do swap
                temp = unsortedlist[j];
                unsortedlist[j] = unsortedlist[j - 1];
                unsortedlist[j - 1] = temp;
                j--;// to go back one more till element of zero.
            }
            i++;
        }
        #endregion

        #region BubbleSort
        /*
         * Keep compare each adjacent elements to each other untill all elements sorted.
         */
        #endregion

        #region QuickSort
        /*
         * take pivot, partition array and call quick sort for first array and so on..
         */
        #endregion
    }
}
