using System;


namespace FinanceBot
{
    internal class AssyncTasks
    {

        public static void Print_One()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Hello from Print 1");
                Task.Delay(50).Wait();
            }
            Console.WriteLine("ENDED PRINT 1");

        }

        public static void Print_Two()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Hello from Print 2");
                Task.Delay(50).Wait();
            }

            Console.WriteLine("ENDED PRINT 2");

        }

      



    }


}
