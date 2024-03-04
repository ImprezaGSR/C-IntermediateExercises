using System;

namespace Exercise1

{

    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var stopWatch = new StopWatch();
                stopWatch.Start(new DateTime(2022, 02, 24, 7, 30, 0));
                stopWatch.Stop(new DateTime(2022, 02, 24, 7, 45, 0));
                Console.WriteLine("Timer stopped at: "+ stopWatch._duration);
            } 
            catch(Exception) {
                Console.WriteLine("ガッ");
            }
        }
    }
}
