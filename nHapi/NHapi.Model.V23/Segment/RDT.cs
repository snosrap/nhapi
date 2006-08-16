using System;
using NHapi.Base.model;
using NHapi.Base.model.v23.datatype;

using ca.uhn.log;
using NHapi.Base.parser;
using NHapi.Base;

namespace NHapi.Base.model.v23.segment{

/**
 * <p>Represents an HL7 RDT message segment. 
 * This segment has the following fields:</p><p>
 * RDT-1: Column value (varies)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RDT : AbstractSegment  {

  /**
   * Creates a RDT (Table Row Data) segment object that belongs to the given 
   * message.  
   */
  public RDT(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(Varies), true, 1, 0, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Column value (RDT-1).
	*/
	public Varies ColumnValue
	{
		get{
			Varies ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (Varies)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}