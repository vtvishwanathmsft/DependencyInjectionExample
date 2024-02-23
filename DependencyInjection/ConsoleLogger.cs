﻿using System;

namespace DependencyInjection
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine('\n');
        }
    }
}