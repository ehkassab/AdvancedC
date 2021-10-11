using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC.Inheritance
{
    public class A
    {
        public virtual void Dowork()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public override void Dowork()
        {
            Console.WriteLine("B");
        }
    }

    public class Solution
    {
        public int[] solution(string[] A, string T) {
            int[] result = new int[2];
            int col = -1;
            int row = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i].Contains(T))
                {
                    row = i;
                    col = A[i].IndexOf(T.ToCharArray()[0]);
                    break;
                }
            }
            result[0] = col;
            result[1] = row;
            return result;
        }
    }
}
