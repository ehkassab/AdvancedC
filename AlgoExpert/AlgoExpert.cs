using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC
{
    public class AlgoExpert
    {
        #region TwoNumberSum
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
                int[] result = new int[2];
                bool reached = false;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] + array[j] == targetSum && i != j)
                        {
                            result[0] = array[i];
                            result[1] = array[j];
                            reached = true;
                        break;
                    }
                }
                if (reached) break;
            }

            if (reached)
                return result;
            else return new int[0];
        }

        //Recitifed Sol
        public static int[] TwoNumberSumSecondSol(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int firstNum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondNum = array[j];
                    if (firstNum + secondNum == targetSum)
                    {
                        return new int[] { firstNum, secondNum };
                    }
                }
            }
            return new int[0];
        }

        public static int[] TwoNumberSumHashTable(int[] array, int targetSum)
        {
            HashSet<int> nums = new HashSet<int>();
            foreach (var num in array)
            {
                int targetval = targetSum - num;
                if(nums.Contains(num))
                {
                    return new int[] {targetval, num };
                }
                else
                {
                    nums.Add(num);
                }
            }
            return new int[0];
        }


        #endregion

        #region SubSequence Array
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            bool allItemsFound = true;
            List<int> foundLst = new List<int>();
            int crntitem = 0;
            int foundItem = 0;
            if (array.Count == sequence.Count)
                return false;

            foreach (var num in sequence)
            {
                crntitem = array.IndexOf(num);
                foundItem = foundLst.IndexOf(num);
                if (crntitem == -1 || foundItem > -1)
                {
                    allItemsFound = false;
                    break;
                }
                else foundLst.Add(num);
            }

            return allItemsFound;
        }

        public static bool IsValidSubsequenceSec(List<int> array, List<int> sequence)
        {
            int crntSeq = 0;
            foreach (var num in array)
            {
                if (crntSeq == sequence.Count)
                    break;
                else
                {
                    if (sequence[crntSeq] == num)
                        crntSeq++;
                }
            }
            return crntSeq == sequence.Count;
        }
        #endregion
    }
}
