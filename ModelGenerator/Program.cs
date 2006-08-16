using System;
using System.Collections.Generic;
using System.Text;
using NHapi.Base.sourcegen;

namespace ModelGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (2 != args.Length)
            {
                System.Console.Error.WriteLine("Not enough arguments.");
                PrintUsage();
                Environment.Exit(1);
            }

            SourceGenerator.makeAll(args[0], args[1]);
        }

        private static void PrintUsage()
        {
            System.Console.WriteLine("usage: ModelGenerator <basedir> <version>");
        }
    }
}
