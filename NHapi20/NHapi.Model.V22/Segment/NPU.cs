using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 NPU message segment. 
 * This segment has the following fields:</p><p>
 * NPU-1: Bed Location (CM_INTERNAL_LOCATION)<br> 
 * NPU-2: Bed Status (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class NPU : AbstractSegment  {

  /**
   * Creates a NPU (BED STATUS UPDATE) segment object that belongs to the given 
   * message.  
   */
	public NPU(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CM_INTERNAL_LOCATION), true, 1, 12, new System.Object[]{message}, "Bed Location");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 116}, "Bed Status");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Bed Location(NPU-1).
	*/
	public CM_INTERNAL_LOCATION BedLocation
	{
		get{
			CM_INTERNAL_LOCATION ret = null;
			try
			{
			IType t = this.getField(1, 0);
				ret = (CM_INTERNAL_LOCATION)t;
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

	/**
	* Returns Bed Status(NPU-2).
	*/
	public ID BedStatus
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(2, 0);
				ret = (ID)t;
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