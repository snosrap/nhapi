using System;

using NHapi.Base.Model;
namespace NHapi.Model.V22
{
/// <summary>/// Summary description for TM.
/// </summary>
public class TM: NHapi.Base.Model.Primitive.TM
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
                public TM(IMessage theMessage):base(theMessage)
                {}
                


		        public TM(IMessage message, string description) : base(message,description)
    	        {}
                }}