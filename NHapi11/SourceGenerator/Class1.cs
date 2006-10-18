using System;
using ca.uhn.hl7v2.sourcegen;
namespace SourceGenerator
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string baseDir = @"C:\Projects\nHapi\NHapi11\";
			string version = "2.3.UCH";
			ca.uhn.hl7v2.sourcegen.SourceGenerator.makeAll(baseDir, version);
		}
	}
}
