using System;

using NHapi.Base.Model;
namespace NHapi.Model.V21
{
/// <summary>/// Summary description for DT.
/// </summary>
public class DT: NHapi.Base.Model.Primitive.DT
{
/// <returns>2.3</returns>

            virtual public System.String Version
            {
			    get
			    {
				    return "2.3";
			    }
		    }
            


                ///<param name="theMessage">message to which this Type belongs</param>
                public DT(IMessage theMessage):base(theMessage)
                {}
                


		        public DT(IMessage message, string description) : base(message,description)
    	        {}
                }}