namespace Singleton
{
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return instance;
            }
        }

        public void Log()
        {
            System.Console.WriteLine("log");
        }
    }
}