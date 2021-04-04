using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SystemMonitor.MachineName);
            Console.WriteLine(SystemMonitor.OSVersion);
            Console.WriteLine(SystemMonitor.UserName);

            Console.WriteLine(SystemMonitor.ProcessActiveNow);
        }
    }
}
