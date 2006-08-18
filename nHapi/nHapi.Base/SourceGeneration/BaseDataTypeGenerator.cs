using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace NHapi.Base.SourceGeneration
{
    class BaseDataTypeGenerator
    {

        public static void BuildBaseDataTypes(string baseDirectory, System.String version)
        {
            string targetDir = baseDirectory + @"\" + SourceGenerator.getVersionPackagePath(version) + "Datatype";

            BuildFile("DT", targetDir, version);
            BuildFile("ST", targetDir, version);
            BuildFile("IS", targetDir, version);
            BuildFile("ID", targetDir, version);
            BuildFile("TM", targetDir, version);

        }

        private static void BuildFile(string dataType, string targetDir, string version)
        {
            string fileName = targetDir + @"\" + dataType + ".cs";
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
            {
                string source = GetClassSource(dataType, version);
                byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(source);
                fs.Write(data, 0, data.Length);
            }
        }

        private static string GetClassSource(string dataType, string version)
        {
            string namespaceName = SourceGenerator.getVersionPackageName(version);
            namespaceName = namespaceName.Substring(0, namespaceName.Length - 1);


            string baseClass = "NHapi.Base.Model.Primitive." + dataType;

            if (dataType.Equals("ST"))
                baseClass = "AbstractPrimitive";

            StringBuilder sb = new StringBuilder();
            sb.Append("using System;\n\n");
            sb.Append("using NHapi.Base.Model;\n");

            sb.Append("namespace " + namespaceName + "\n");
            sb.Append("{\n");
            sb.Append("/// <summary>");
            sb.Append("/// Summary description for " + dataType + ".\n");
            sb.Append("/// </summary>\n");
            sb.Append("public class " + dataType + ": " + baseClass + "\n");
            sb.Append("{\n");
            sb.Append("/// <returns>2.3</returns>\n");
            sb.Append(@"
            virtual public System.String Version
            {
			    get
			    {
				    return ""2.3"";
			    }
		    }
            ");

            if (dataType.Equals("ID") || dataType.Equals("IS"))
            {
                sb.Append("\n\n");
                sb.Append(@"
                ///<param name=""theMessage"">message to which this Type belongs</param>
                public " + dataType + @"(IMessage theMessage,int theTable):base(theMessage, theTable)
                {}
                ");

                sb.Append("\n\n");
                sb.Append(@"
		        public " + dataType + @"(IMessage message, int theTable, string description) : base(message,theTable, description)
    	        {}
                ");

            }
            else
            {
                sb.Append("\n\n");
                sb.Append(@"
                ///<param name=""theMessage"">message to which this Type belongs</param>
                public " + dataType + @"(IMessage theMessage):base(theMessage)
                {}
                ");

                sb.Append("\n\n");
                sb.Append(@"
		        public " + dataType + @"(IMessage message, string description) : base(message,description)
    	        {}
                ");
            }
            sb.Append("}\r");
            sb.Append("}\r");
            return sb.ToString();
        }
    }
}
