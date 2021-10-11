using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC.Events
{
    public delegate void WorKHandler(int hours, string name);

    public delegate int WorkPerformedHandler(int h,int r);

    public class EventSample
    {

        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        private void EventData(int hours,int actual)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i+1,actual);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, int actual)
        {
            var del = WorkPerformed as WorkPerformedHandler;
            if (del != null)
                del(10, 5);
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler;
            if (del != null)
                del(this, EventArgs.Empty);
        }

        static void DoWork(WorKHandler del)
        {
            WorKHandler del1 = new WorKHandler(work1);
            WorKHandler del2 = new WorKHandler(work2);
            WorKHandler del3 = new WorKHandler(work3);
            del1 += del2 + del3;
            del1(5, "eslam");
            del(1, "dowork");
        }

        static void work1(int hours, string name)
        {
            Console.WriteLine("Work 1 called " + hours + "For Names " + name);
        }

        static void work2(int hours, string name)
        {
            Console.WriteLine("Work 2 called " + hours + "For Names " + name);
        }

        static void work3(int hours, string name)
        {
            Console.WriteLine("Work 3 called " + hours + "For Names " + name);
        }
    }
}
