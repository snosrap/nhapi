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
            //args = new string[3];
            //args[0] = @"C:\Projects\Nhapi\Nhapi20";
            //args[1] = "2.5";
            //args[2] = @"C:\Projects\hl7\Database\hl7db.mdb";

            
            if (args.Length<2)
            {

                System.Console.Error.WriteLine("Not enough arguments ({0}).", args.Length.ToString());
                PrintUsage();
                Environment.Exit(1);

            }

            if (args.Length == 3)
            {
                string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + args[2];
                NHapi.Base.NormativeDatabase.Instance.OpenNewConnection(conn);
            }

            Console.WriteLine("Using Database{0}", NHapi.Base.NormativeDatabase.Instance.Connection.ConnectionString);
            SourceGenerator.makeAll(args[0], args[1]);

        }

        private static void PrintUsage()
        {
            System.Console.WriteLine("usage: ModelGenerator <basedir> <version>.  Will create a folder named NHapi.Model.VXXX at the baseDir.");
        }
    }
}
