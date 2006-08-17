using System;

using NHapi.Base.Model;
namespace NHapi.Model.V22
{
/// <summary>/// Summary description for ID.
/// </summary>
public class ID: NHapi.Base.Model.Primitive.ID
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
                public ID(IMessage theMessage,int theTable):base(theMessage, theTable)
                {}
                


		        public ID(IMessage message, int theTable, string description) : base(message,theTable, description)
    	        {}
                }}