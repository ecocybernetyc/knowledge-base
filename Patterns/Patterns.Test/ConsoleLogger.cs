using Patterns.Common;

namespace Patterns.Test
{
    public class ConsoleLogger : IPatternsLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
