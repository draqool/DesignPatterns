using System;

namespace Strategy
{
    public interface IIpProtocolProvider
    {
        void Create();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
