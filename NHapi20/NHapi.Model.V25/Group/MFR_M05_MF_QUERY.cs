using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V25.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V25.Group
{
///<summary>
///Represents the MFR_M05_MF_QUERY Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: MFE (Master File Entry) 
/// * 1: LOC (Location Identification) 
/// * 2: LCH (Location Characteristic) optional repeating
/// * 3: LRL (Location Relationship) optional repeating
/// * 4: LDP (Location Department) repeating
/// * 5: LCH (Location Characteristic) optional repeating
/// * 6: LCC (Location Charge Code) optional repeating
///</summary>
[Serializable]
public class MFR_M05_MF_QUERY : AbstractGroup {

	///<summary> 
	/// Creates a new MFR_M05_MF_QUERY Group.
	///</summary>
	public MFR_M05_MF_QUERY(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(LOC), true, false);
	      this.add(typeof(LCH), false, true);
	      this.add(typeof(LRL), false, true);
	      this.add(typeof(LDP), true, true);
	      this.add(typeof(LCH), false, true);
	      this.add(typeof(LCC), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFR_M05_MF_QUERY - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MFE (Master File Entry) - creates it if necessary
	///</summary>
	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.GetStructure("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns LOC (Location Identification) - creates it if necessary
	///</summary>
	public LOC LOC { 
get{
	   LOC ret = null;
	   try {
	      ret = (LOC)this.GetStructure("LOC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of LCH (Location Characteristic) - creates it if necessary
	///</summary>
	public LCH getLCH() {
	   LCH ret = null;
	   try {
	      ret = (LCH)this.GetStructure("LCH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LCH
	/// * (Location Characteristic) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LCH getLCH(int rep) { 
	   return (LCH)this.GetStructure("LCH", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCH 
	 */ 
	public int LCHReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LCH").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of LRL (Location Relationship) - creates it if necessary
	///</summary>
	public LRL getLRL() {
	   LRL ret = null;
	   try {
	      ret = (LRL)this.GetStructure("LRL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LRL
	/// * (Location Relationship) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LRL getLRL(int rep) { 
	   return (LRL)this.GetStructure("LRL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LRL 
	 */ 
	public int LRLReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LRL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of LDP (Location Department) - creates it if necessary
	///</summary>
	public LDP getLDP() {
	   LDP ret = null;
	   try {
	      ret = (LDP)this.GetStructure("LDP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LDP
	/// * (Location Department) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LDP getLDP(int rep) { 
	   return (LDP)this.GetStructure("LDP", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LDP 
	 */ 
	public int LDPReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LDP").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of LCH2 (Location Characteristic) - creates it if necessary
	///</summary>
	public LCH getLCH2() {
	   LCH ret = null;
	   try {
	      ret = (LCH)this.GetStructure("LCH2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LCH2
	/// * (Location Characteristic) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LCH getLCH2(int rep) { 
	   return (LCH)this.GetStructure("LCH2", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCH2 
	 */ 
	public int LCH2Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LCH2").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of LCC (Location Charge Code) - creates it if necessary
	///</summary>
	public LCC getLCC() {
	   LCC ret = null;
	   try {
	      ret = (LCC)this.GetStructure("LCC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LCC
	/// * (Location Charge Code) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LCC getLCC(int rep) { 
	   return (LCC)this.GetStructure("LCC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCC 
	 */ 
	public int LCCReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LCC").Length; 
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
