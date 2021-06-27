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
                if (nums.Contains(num))
                {
                    return new int[] { targetval, num };
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

        #region Sorted Squared array
        public int[] SortedSquaredArray(int[] array)
        {
            int[] newArr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i] * array[i];
            }
            Array.Sort(newArr);
            return newArr;
        }

        public int[] SortedSquaredArraySec(int[] array)
        {
            int[] newArr = new int[array.Length];
            int smalleridx = newArr[0];
            int largeridx = newArr[array.Length-1];
            for (int idx = array.Length-1 ; idx >=0 ; idx--)
            {
                int smallVal = array[smalleridx];
                int largeVal = array[largeridx];
                if(Math.Abs(smallVal) > Math.Abs(largeVal))
                {
                    newArr[idx] = smallVal * smallVal;
                    smalleridx++;
                }
                else
                {
                    newArr[idx] = largeVal * largeVal;
                    largeridx++;
                }
            }
            return newArr;
        }
        #endregion

        #region NonConstructibleChange
        public int NonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);
            int curntChanged = 0;
            foreach (var coin in coins)
            {
                if(coin > curntChanged +1)
                {
                    return curntChanged + 1;
                }
                curntChanged += coin;
            }

            return curntChanged + 1;
        }
        #endregion

        #region BinarySearchTree
        public static int FindClosestValueInBst(BST tree, int target)
        {
           return FindClosestValueInBst(tree, target, tree.value);
        }

        public static int FindClosestValueInBst(BST tree, int target,int closest)
        {
            if(Math.Abs(target - closest) > Math.Abs(target - tree.value))
            {
                closest = tree.value;
            }

            if (target < tree.value && tree.left != null)
            {
                return FindClosestValueInBst(tree.left, target, closest);
            }
            else if (target > tree.value && tree.right != null)
            {
                return FindClosestValueInBst(tree.right, target, closest);
            }
            else return closest;
        }

        public static List<int> BranchSums(BinaryTree root)
        {
            List<int> sums = new List<int>();
            calculateSum(root, 0, sums);
            return sums;
        }

        public static void calculateSum(BinaryTree node, int sum, List<int> sums)
        {
            if (node == null) return;
            int newSum = sum + node.value;
            if (node.left == null && node.right == null)
            {
                sums.Add(newSum);
                return;
            }
            calculateSum(node.left, newSum, sums);
            calculateSum(node.right, newSum, sums);
        }
        #endregion

    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
    }

    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
