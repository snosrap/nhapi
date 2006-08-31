using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the PEX_P07_ASSOCIATED_PERSON Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: NK1 (Next of kin / associated parties) 
/// * 1: PEX_P07_ASSOCIATED_RX_ORDER (a Group object) optional 
/// * 2: PEX_P07_ASSOCIATED_RX_ADMIN (a Group object) optional repeating
/// * 3: PRB (Problem Details) optional repeating
/// * 4: OBX (Observation/Result) optional repeating
///</summary>
[Serializable]
public class PEX_P07_ASSOCIATED_PERSON : AbstractGroup {

	///<summary> 
	/// Creates a new PEX_P07_ASSOCIATED_PERSON Group.
	///</summary>
	public PEX_P07_ASSOCIATED_PERSON(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NK1), true, false);
	      this.add(typeof(PEX_P07_ASSOCIATED_RX_ORDER), false, false);
	      this.add(typeof(PEX_P07_ASSOCIATED_RX_ADMIN), false, true);
	      this.add(typeof(PRB), false, true);
	      this.add(typeof(OBX), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_ASSOCIATED_PERSON - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns NK1 (Next of kin / associated parties) - creates it if necessary
	///</summary>
	public NK1 NK1 { 
get{
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.GetStructure("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PEX_P07_ASSOCIATED_RX_ORDER (a Group object) - creates it if necessary
	///</summary>
	public PEX_P07_ASSOCIATED_RX_ORDER ASSOCIATED_RX_ORDER { 
get{
	   PEX_P07_ASSOCIATED_RX_ORDER ret = null;
	   try {
	      ret = (PEX_P07_ASSOCIATED_RX_ORDER)this.GetStructure("ASSOCIATED_RX_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of PEX_P07_ASSOCIATED_RX_ADMIN (a Group object) - creates it if necessary
	///</summary>
	public PEX_P07_ASSOCIATED_RX_ADMIN getASSOCIATED_RX_ADMIN() {
	   PEX_P07_ASSOCIATED_RX_ADMIN ret = null;
	   try {
	      ret = (PEX_P07_ASSOCIATED_RX_ADMIN)this.GetStructure("ASSOCIATED_RX_ADMIN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PEX_P07_ASSOCIATED_RX_ADMIN
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PEX_P07_ASSOCIATED_RX_ADMIN getASSOCIATED_RX_ADMIN(int rep) { 
	   return (PEX_P07_ASSOCIATED_RX_ADMIN)this.GetStructure("ASSOCIATED_RX_ADMIN", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PEX_P07_ASSOCIATED_RX_ADMIN 
	 */ 
	public int ASSOCIATED_RX_ADMINReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ASSOCIATED_RX_ADMIN").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of PRB (Problem Details) - creates it if necessary
	///</summary>
	public PRB getPRB() {
	   PRB ret = null;
	   try {
	      ret = (PRB)this.GetStructure("PRB");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PRB
	/// * (Problem Details) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PRB getPRB(int rep) { 
	   return (PRB)this.GetStructure("PRB", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PRB 
	 */ 
	public int PRBReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PRB").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of OBX (Observation/Result) - creates it if necessary
	///</summary>
	public OBX getOBX() {
	   OBX ret = null;
	   try {
	      ret = (OBX)this.GetStructure("OBX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OBX
	/// * (Observation/Result) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OBX getOBX(int rep) { 
	   return (OBX)this.GetStructure("OBX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OBX 
	 */ 
	public int OBXReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBX").Length; 
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
