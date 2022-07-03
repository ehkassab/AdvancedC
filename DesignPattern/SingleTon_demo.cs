using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC.DesignPattern
{

    // below has a problem for multithreaded as it will create singleton for each thread
    //public class SingleTon_demo
    //{

    //    private static SingleTon_demo _instance;

    //    private SingleTon_demo()
    //    {

    //    }

    //    public static SingleTon_demo Create()
    //    {
    //        return _instance ?? (_instance = new SingleTon_demo());
    //    }
    //}


    public class SingleTon_demo
    {
        //BBprivate static int i = 0;
        private static SingleTon_demo _instance;
        private static object _cachLock = new object();
        private SingleTon_demo()
        {

        }

        public static SingleTon_demo Create()
        {
            if(_instance == null)
            {
                lock (_cachLock)
                {
                    _instance = new SingleTon_demo();
                }
            }
            return _instance;
        }
    }
}
