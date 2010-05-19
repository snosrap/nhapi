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

            string param = "ALL";
            if (args.Length == 3)
            {
                param = args[2];    
            }

            Console.WriteLine("Using Database{0}", NHapi.Base.NormativeDatabase.Instance.Connection.ConnectionString);
            switch(param.ToUpper().Trim())
            {
                case "ALL":
                    SourceGenerator.makeAll(args[0], args[1]);
                    break;
                case "EVENTMAPPING":
                    SourceGenerator.MakeEventMapping(args[0], args[1]);
                    break;
                case "SEGMENT":
                    SegmentGenerator.makeAll(args[0], args[1]);
                    break;
                case "MESSAGE":
                    MessageGenerator.makeAll(args[0], args[1]);
                    break;
            }

            
        }

        private static void PrintUsage()
        {
            System.Console.WriteLine(@"usage: ModelGenerator <basedir> <version> <PARAM>.  
            Will create a folder named NHapi.Model.VXXX at the baseDir.  PARAM is optinal and can be SEGMENT, MESSAGE, DATATYPE, EVENTMAPPING");
        }
    }
}
