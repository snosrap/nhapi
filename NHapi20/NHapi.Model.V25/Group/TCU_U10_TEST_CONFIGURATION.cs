using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V25.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V25.Group
{
///<summary>
///Represents the TCU_U10_TEST_CONFIGURATION Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: SPM (Specimen) optional 
/// * 1: TCC (Test Code Configuration) repeating
///</summary>
[Serializable]
public class TCU_U10_TEST_CONFIGURATION : AbstractGroup {

	///<summary> 
	/// Creates a new TCU_U10_TEST_CONFIGURATION Group.
	///</summary>
	public TCU_U10_TEST_CONFIGURATION(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(SPM), false, false);
	      this.add(typeof(TCC), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating TCU_U10_TEST_CONFIGURATION - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns SPM (Specimen) - creates it if necessary
	///</summary>
	public SPM SPM { 
get{
	   SPM ret = null;
	   try {
	      ret = (SPM)this.GetStructure("SPM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of TCC (Test Code Configuration) - creates it if necessary
	///</summary>
	public TCC getTCC() {
	   TCC ret = null;
	   try {
	      ret = (TCC)this.GetStructure("TCC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of TCC
	/// * (Test Code Configuration) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public TCC getTCC(int rep) { 
	   return (TCC)this.GetStructure("TCC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of TCC 
	 */ 
	public int TCCReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("TCC").Length; 
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
