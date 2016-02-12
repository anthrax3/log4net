using NUnitLite;
using System;
using System.Reflection;

namespace log4net.tests
{
    public class Program
    {
        public int Main(string[] args)
        {
            return new AutoRun().Execute(typeof(Program).GetTypeInfo().Assembly, Console.Out, Console.In, args);
        }
    }
}
