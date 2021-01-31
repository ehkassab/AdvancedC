using System;


namespace AdvancedC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Generics.Generics.InitiateNonGenerciSortArray();
            Console.ReadKey();
            int? e = null;

            if(e is null) // this check is better that ==
            {
                e?.ToString();
            }
            #nullable enable // this is to enable null in new c#.
            //Tuples
            (string esl, string er, int re) tupleVal = ("","",3);
            var sd = new Tuple<string, string, int>("","",3);
            // Tuples asre immutable cannot change values .
            Console.WriteLine(tupleVal.esl);
            string[] s = new string[] {"","","",""};
            int[,] dim = new int[3, 3];
            // New way to get index is using ^
            s[^3] = "";
            string[] re = s[^0..^3]; // using .. array range operator
        }
        // this in refrene number, make pass by refrence to be readonly.
        public int OnlyInByRef(in int number)
        {
            return number;
        }
    }
}
