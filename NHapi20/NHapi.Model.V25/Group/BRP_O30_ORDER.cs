using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V25.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V25.Group
{
///<summary>
///Represents the BRP_O30_ORDER Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: ORC (Common Order) 
/// * 1: BRP_O30_TIMING (a Group object) 
/// * 2: BPO (Blood product order) optional 
/// * 3: BPX (Blood product dispense status) optional repeating
///</summary>
[Serializable]
public class BRP_O30_ORDER : AbstractGroup {

	///<summary> 
	/// Creates a new BRP_O30_ORDER Group.
	///</summary>
	public BRP_O30_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(BRP_O30_TIMING), true, false);
	      this.add(typeof(BPO), false, false);
	      this.add(typeof(BPX), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BRP_O30_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORC (Common Order) - creates it if necessary
	///</summary>
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.GetStructure("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns BRP_O30_TIMING (a Group object) - creates it if necessary
	///</summary>
	public BRP_O30_TIMING TIMING { 
get{
	   BRP_O30_TIMING ret = null;
	   try {
	      ret = (BRP_O30_TIMING)this.GetStructure("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns BPO (Blood product order) - creates it if necessary
	///</summary>
	public BPO BPO { 
get{
	   BPO ret = null;
	   try {
	      ret = (BPO)this.GetStructure("BPO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of BPX (Blood product dispense status) - creates it if necessary
	///</summary>
	public BPX getBPX() {
	   BPX ret = null;
	   try {
	      ret = (BPX)this.GetStructure("BPX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of BPX
	/// * (Blood product dispense status) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public BPX getBPX(int rep) { 
	   return (BPX)this.GetStructure("BPX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of BPX 
	 */ 
	public int BPXReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("BPX").Length; 
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
