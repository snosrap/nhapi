using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment{

/**
 * <p>Represents an HL7 ERR message segment. 
 * This segment has the following fields:</p><p>
 * ERR-1: Error Code and Location (CM_ELD)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class ERR : AbstractSegment  {

  /**
   * Creates a ERR (Error segment) segment object that belongs to the given 
   * message.  
   */
  public ERR(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CM_ELD), true, 0, 80, new System.Object[]{message}, "Error Code and Location");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns a single repetition of Error Code and Location(ERR-1).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_ELD getErrorCodeAndLocation(int rep)
	{
			CM_ELD ret = null;
			try
			{
			Type t = this.getField(1, rep);
				ret = (CM_ELD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Error Code and Location (ERR-1).
   */
  public CM_ELD[] getErrorCodeAndLocation() {
     CM_ELD[] ret = null;
    try {
        Type[] t = this.getField(1);  
        ret = new CM_ELD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_ELD)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}


}}