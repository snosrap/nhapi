using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
///<summary>
///Represents the SIU_S19_RESOURCES Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: RGS (Resource Group) 
/// * 1: SIU_S19_SERVICE (a Group object) optional repeating
/// * 2: SIU_S19_GENERAL_RESOURCE (a Group object) optional repeating
/// * 3: SIU_S19_LOCATION_RESOURCE (a Group object) optional repeating
/// * 4: SIU_S19_PERSONNEL_RESOURCE (a Group object) optional repeating
///</summary>
[Serializable]
public class SIU_S19_RESOURCES : AbstractGroup {

	///<summary> 
	/// Creates a new SIU_S19_RESOURCES Group.
	///</summary>
	public SIU_S19_RESOURCES(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RGS), true, false);
	      this.add(typeof(SIU_S19_SERVICE), false, true);
	      this.add(typeof(SIU_S19_GENERAL_RESOURCE), false, true);
	      this.add(typeof(SIU_S19_LOCATION_RESOURCE), false, true);
	      this.add(typeof(SIU_S19_PERSONNEL_RESOURCE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SIU_S19_RESOURCES - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns RGS (Resource Group) - creates it if necessary
	///</summary>
	public RGS RGS { 
get{
	   RGS ret = null;
	   try {
	      ret = (RGS)this.GetStructure("RGS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of SIU_S19_SERVICE (a Group object) - creates it if necessary
	///</summary>
	public SIU_S19_SERVICE getSERVICE() {
	   SIU_S19_SERVICE ret = null;
	   try {
	      ret = (SIU_S19_SERVICE)this.GetStructure("SERVICE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SIU_S19_SERVICE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SIU_S19_SERVICE getSERVICE(int rep) { 
	   return (SIU_S19_SERVICE)this.GetStructure("SERVICE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SIU_S19_SERVICE 
	 */ 
	public int SERVICEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SERVICE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of SIU_S19_GENERAL_RESOURCE (a Group object) - creates it if necessary
	///</summary>
	public SIU_S19_GENERAL_RESOURCE getGENERAL_RESOURCE() {
	   SIU_S19_GENERAL_RESOURCE ret = null;
	   try {
	      ret = (SIU_S19_GENERAL_RESOURCE)this.GetStructure("GENERAL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SIU_S19_GENERAL_RESOURCE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SIU_S19_GENERAL_RESOURCE getGENERAL_RESOURCE(int rep) { 
	   return (SIU_S19_GENERAL_RESOURCE)this.GetStructure("GENERAL_RESOURCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SIU_S19_GENERAL_RESOURCE 
	 */ 
	public int GENERAL_RESOURCEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GENERAL_RESOURCE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of SIU_S19_LOCATION_RESOURCE (a Group object) - creates it if necessary
	///</summary>
	public SIU_S19_LOCATION_RESOURCE getLOCATION_RESOURCE() {
	   SIU_S19_LOCATION_RESOURCE ret = null;
	   try {
	      ret = (SIU_S19_LOCATION_RESOURCE)this.GetStructure("LOCATION_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SIU_S19_LOCATION_RESOURCE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SIU_S19_LOCATION_RESOURCE getLOCATION_RESOURCE(int rep) { 
	   return (SIU_S19_LOCATION_RESOURCE)this.GetStructure("LOCATION_RESOURCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SIU_S19_LOCATION_RESOURCE 
	 */ 
	public int LOCATION_RESOURCEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LOCATION_RESOURCE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of SIU_S19_PERSONNEL_RESOURCE (a Group object) - creates it if necessary
	///</summary>
	public SIU_S19_PERSONNEL_RESOURCE getPERSONNEL_RESOURCE() {
	   SIU_S19_PERSONNEL_RESOURCE ret = null;
	   try {
	      ret = (SIU_S19_PERSONNEL_RESOURCE)this.GetStructure("PERSONNEL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SIU_S19_PERSONNEL_RESOURCE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SIU_S19_PERSONNEL_RESOURCE getPERSONNEL_RESOURCE(int rep) { 
	   return (SIU_S19_PERSONNEL_RESOURCE)this.GetStructure("PERSONNEL_RESOURCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SIU_S19_PERSONNEL_RESOURCE 
	 */ 
	public int PERSONNEL_RESOURCEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PERSONNEL_RESOURCE").Length; 
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
