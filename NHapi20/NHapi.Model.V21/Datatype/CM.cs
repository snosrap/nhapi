using System;
using System.Collections.Generic;
using System.Text;
using NHapi.Base.Model.Primitive;
using NHapi.Base.Model;

namespace NHapi.Model.V21.Datatype
{
    public class CM : GenericComposite
    {


        /// <param name="message">message to which this Type belongs
        /// </param>
        public CM(IMessage message)
            : base(message)
        {
        }
    }
}
