using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.Log();
            Console.ReadKey();
        }
    }
}
