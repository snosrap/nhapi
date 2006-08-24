using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V22.Segment;

using NHapi.Base.Model;
/**
 * <p>Represents the NMD_N01_CLOCK Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: NCK (System Clock) <b></b><br>
 * 1: NTE (NOTES AND COMMENTS) <b>optional repeating</b><br>
 */
namespace NHapi.Model.V22.Group
{
[Serializable]
public class NMD_N01_CLOCK : AbstractGroup {

	/** 
	 * Creates a new NMD_N01_CLOCK Group.
	 */
	public NMD_N01_CLOCK(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NCK), true, false);
	      this.add(typeof(NTE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMD_N01_CLOCK - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of NTE (NOTES AND COMMENTS) - creates it if necessary
	 */
	public NTE getNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.getStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE
	 * (NOTES AND COMMENTS) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE(int rep) { 
	   return (NTE)this.getStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
