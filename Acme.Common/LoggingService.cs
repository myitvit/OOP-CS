using System;
using System.Collections.Generic;

namespace Acme.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
