using System;
using System.Threading;

namespace Exercise1

{

    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var stopWatch = new StopWatch();
                stopWatch.Start();
                Thread.Sleep(1000);
                stopWatch.Stop();
                Console.WriteLine("Timer stopped at: "+ stopWatch._duration);
            } 
            catch(Exception) {
                Console.WriteLine("ガッ");
            }
        }
    }
}
