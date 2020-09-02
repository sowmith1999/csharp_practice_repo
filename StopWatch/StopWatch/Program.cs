using System;
using System.Threading;

namespace StopWatch
{
    public class StopWatch
    {

        private static DateTime? StartTime { get; set; } = null;
       

        public static void  Start()
        {
            if (StartTime == null)
            {
                StartTime=DateTime.Now;
                
            }
            else
            {
                Console.WriteLine("lol");  
            }
        }
        
        public static void Stop()
        {
            Console.WriteLine(DateTime.Now - StartTime);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch.Start();
            int milliseconds = 1000;
            Thread.Sleep(milliseconds);
            StopWatch.Start();
            Thread.Sleep(milliseconds);
            StopWatch.Stop();
        }
    }
}
