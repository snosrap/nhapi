using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the OML_O21_PRIOR_RESULT Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: OML_O21_PATIENT_PRIOR (a Group object) optional 
/// * 1: OML_O21_PATIENT_VISIT_PRIOR (a Group object) optional 
/// * 2: AL1 (Patient allergy information) optional repeating
/// * 3: OML_O21_ORDER_PRIOR (a Group object) repeating
///</summary>
[Serializable]
public class OML_O21_PRIOR_RESULT : AbstractGroup {

	///<summary> 
	/// Creates a new OML_O21_PRIOR_RESULT Group.
	///</summary>
	public OML_O21_PRIOR_RESULT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OML_O21_PATIENT_PRIOR), false, false);
	      this.add(typeof(OML_O21_PATIENT_VISIT_PRIOR), false, false);
	      this.add(typeof(AL1), false, true);
	      this.add(typeof(OML_O21_ORDER_PRIOR), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OML_O21_PRIOR_RESULT - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns OML_O21_PATIENT_PRIOR (a Group object) - creates it if necessary
	///</summary>
	public OML_O21_PATIENT_PRIOR PATIENT_PRIOR { 
get{
	   OML_O21_PATIENT_PRIOR ret = null;
	   try {
	      ret = (OML_O21_PATIENT_PRIOR)this.GetStructure("PATIENT_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns OML_O21_PATIENT_VISIT_PRIOR (a Group object) - creates it if necessary
	///</summary>
	public OML_O21_PATIENT_VISIT_PRIOR PATIENT_VISIT_PRIOR { 
get{
	   OML_O21_PATIENT_VISIT_PRIOR ret = null;
	   try {
	      ret = (OML_O21_PATIENT_VISIT_PRIOR)this.GetStructure("PATIENT_VISIT_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of AL1 (Patient allergy information) - creates it if necessary
	///</summary>
	public AL1 getAL1() {
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.GetStructure("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of AL1
	/// * (Patient allergy information) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public AL1 getAL1(int rep) { 
	   return (AL1)this.GetStructure("AL1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AL1 
	 */ 
	public int AL1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("AL1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of OML_O21_ORDER_PRIOR (a Group object) - creates it if necessary
	///</summary>
	public OML_O21_ORDER_PRIOR getORDER_PRIOR() {
	   OML_O21_ORDER_PRIOR ret = null;
	   try {
	      ret = (OML_O21_ORDER_PRIOR)this.GetStructure("ORDER_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OML_O21_ORDER_PRIOR
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OML_O21_ORDER_PRIOR getORDER_PRIOR(int rep) { 
	   return (OML_O21_ORDER_PRIOR)this.GetStructure("ORDER_PRIOR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OML_O21_ORDER_PRIOR 
	 */ 
	public int ORDER_PRIORReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER_PRIOR").Length; 
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
