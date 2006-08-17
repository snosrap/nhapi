using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V22.Segment;

using NHapi.Base.Model;
/**
 * <p>Represents the NMQ_N02_CLOCK_AND_STATISTICS Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: NCK (System Clock) <b>optional </b><br>
 * 1: NST (Statistics) <b>optional </b><br>
 * 2: NSC (STATUS CHANGE) <b>optional </b><br>
 */
namespace NHapi.Model.V22.Group
{
[Serializable]
public class NMQ_N02_CLOCK_AND_STATISTICS : AbstractGroup {

	/** 
	 * Creates a new NMQ_N02_CLOCK_AND_STATISTICS Group.
	 */
	public NMQ_N02_CLOCK_AND_STATISTICS(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NCK), false, false);
	      this.add(typeof(NST), false, false);
	      this.add(typeof(NSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMQ_N02_CLOCK_AND_STATISTICS - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns NCK (System Clock) - creates it if necessary
	 */
	public NCK NCK { 
get{
	   NCK ret = null;
	   try {
	      ret = (NCK)this.getStructure("NCK");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns NST (Statistics) - creates it if necessary
	 */
	public NST NST { 
get{
	   NST ret = null;
	   try {
	      ret = (NST)this.getStructure("NST");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns NSC (STATUS CHANGE) - creates it if necessary
	 */
	public NSC NSC { 
get{
	   NSC ret = null;
	   try {
	      ret = (NSC)this.getStructure("NSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
