using System;

using NHapi.Base.Model;
namespace NHapi.Model.V21
{
/// <summary>/// Summary description for IS.
/// </summary>
public class IS: NHapi.Base.Model.Primitive.IS
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
                public IS(IMessage theMessage,int theTable):base(theMessage, theTable)
                {}
                


		        public IS(IMessage message, int theTable, string description) : base(message,theTable, description)
    	        {}
                }}