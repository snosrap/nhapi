using System;
using System.Collections.Generic;
using System.Text;
using NHapi.Base.SourceGeneration;

namespace ModelGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //args = new string[2];
            //args[0] = @"C:\Projects\nHapiRestructured\nHapi\Test";
            //args[1] = "2.3.1";
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
            System.Console.WriteLine("usage: ModelGenerator <basedir> <version>.  Will create a folder named NHapi.Model.VXXX at the baseDir.");
        }
    }
}
