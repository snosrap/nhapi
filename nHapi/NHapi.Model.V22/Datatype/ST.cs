using System;

using NHapi.Base.Model;
namespace NHapi.Model.V22
{
/// <summary>/// Summary description for ST.
/// </summary>
public class ST: AbstractPrimitive
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
                public ST(IMessage theMessage):base(theMessage)
                {}
                


		        public ST(IMessage message, string description) : base(message,description)
    	        {}
                }}