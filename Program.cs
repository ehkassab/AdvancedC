using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HistoryCall
            //CallGenerics();
            //CallGeneral();
            //string name = "Eslam";
            //Console.WriteLine($"Your Name Is : {name}");
            //Console.WriteLine("Your Name Is : {0}",name);
            //System.Int32 is struct and int is alias to that struct.
            //var b = new B();
            //var a = (A)b;
            //a.Dowork();
            //Solution soly = new Solution();
            //string[] matrix = new string[3];
            //matrix[0] = "QZF";
            //matrix[1] = "WHI";
            //matrix[2] = "UBU";
            //var res = soly.solution(matrix, "HI");
            //int[] arrayval = { -21, 301, 12, 4, 65, 56, 210, 356, 9, -47 }; 
            //"array": [3, 5, -4, 8, 11, 1, -1, 6],
            //CollectionsCrs.CollectionsFunc();
            //AlgoExpert.TwoNumberSum(arrayval, 164);
            //Hashtable hashtable = new Hashtable();
            //Dictionary<int,int> dic = new Dictionary<int,int>();

            //LinkedList<int> vs = new LinkedList<int>();
            //testYieldb();
            //Func<int, int> square = x => x * x;
            //Console.WriteLine(square(3));

            //del1 += del3;
            //del2(8, "eshta");

            // DoWork(del1);
            //DoWork(del2);
            #endregion
            //object eslam = null;
            //var s = eslam ?? "eslam";
            //var t = eslam ?? default;
            //var tr = CallerData();
            //Action action = () => Console.Write("I'm action");
            Thread thread = new Thread(()=> {
                for (int i = 0; i < 1000; i++) Console.Write("Y");
            });

            Task.Run(()=> Console.WriteLine("eslam"));

            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            keyValuePairs.Add(5,"eslam");
            keyValuePairs.Add(7,"Ahmed");
            SortedList<int, int> sItem = new SortedList<int, int>();
            thread.Start();
            for (int i = 0; i < 1000; i++) Console.Write("X");
            //Console.WriteLine(action);


            Console.ReadKey();
        }

        void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("Y");
        }

        public static string CallerData([CallerMemberName] string caller = null)
        {
            return caller;
        }

        public static IEnumerable<int> testYieldb()
        {
            yield return 4; // defrred execution.
            Console.WriteLine("abc");
            yield return 4;
        }
        // this in refrene number, make pass by refrence to be readonly.
        public int OnlyInByRef(in int number)
        {
            return number;
        }

        public static void CallGenerics()
        {
            Console.WriteLine("Hello World!");
            Generics.Generics.InitiateNonGenerciSortArray();
            Console.ReadKey();
        }

        public static void CallGeneral()
        {
            int? e = null;
            if (e is null) // this check is better that ==
            {
                e?.ToString();
            }
            #nullable enable // this is to enable null in new c#.
            //Tuples
            (string esl, string er, int re) tupleVal = ("", "", 3);
            var sd = new Tuple<string, string, int>("", "", 3);
            // Tuples asre immutable cannot change values .
            Console.WriteLine(tupleVal.esl);
            string[] s = new string[] { "", "", "", "" };
            int[,] dim = new int[3, 3];
            // New way to get index is using ^
            s[^3] = "";
            string[] re = s[^0..^3]; // using .. array range operator
        }
    }
}
