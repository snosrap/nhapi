using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v24.segment;

using NHapi.Base.model;
/**
 * <p>Represents the SRM_S01_RESOURCES Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RGS (Resource Group) <b></b><br>
 * 1: SRM_S01_SERVICE (a Group object) <b>optional repeating</b><br>
 * 2: SRM_S01_GENERAL_RESOURCE (a Group object) <b>optional repeating</b><br>
 * 3: SRM_S01_LOCATION_RESOURCE (a Group object) <b>optional repeating</b><br>
 * 4: SRM_S01_PERSONNEL_RESOURCE (a Group object) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v24.group
{
[Serializable]
public class SRM_S01_RESOURCES : AbstractGroup {

	/** 
	 * Creates a new SRM_S01_RESOURCES Group.
	 */
	public SRM_S01_RESOURCES(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("RGS", "2.4"), true, false);
	      this.add(factory.getGroupClass("SRM_S01_SERVICE", "2.4"), false, true);
	      this.add(factory.getGroupClass("SRM_S01_GENERAL_RESOURCE", "2.4"), false, true);
	      this.add(factory.getGroupClass("SRM_S01_LOCATION_RESOURCE", "2.4"), false, true);
	      this.add(factory.getGroupClass("SRM_S01_PERSONNEL_RESOURCE", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SRM_S01_RESOURCES - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RGS (Resource Group) - creates it if necessary
	 */
	public RGS RGS { 
get{
	   RGS ret = null;
	   try {
	      ret = (RGS)this.get_Renamed("RGS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of SRM_S01_SERVICE (a Group object) - creates it if necessary
	 */
	public SRM_S01_SERVICE  getSERVICE() { 
	   SRM_S01_SERVICE ret = null;
	   try {
	      ret = (SRM_S01_SERVICE)this.get_Renamed("SERVICE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SRM_S01_SERVICE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SRM_S01_SERVICE getSERVICE(int rep) { 
	   return (SRM_S01_SERVICE)this.get_Renamed("SERVICE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SRM_S01_SERVICE 
	 */ 
	public int SERVICEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("SERVICE").Length; 
	    }
 catch (HL7Exception e) 
{ 
	        String message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of SRM_S01_GENERAL_RESOURCE (a Group object) - creates it if necessary
	 */
	public SRM_S01_GENERAL_RESOURCE  getGENERAL_RESOURCE() { 
	   SRM_S01_GENERAL_RESOURCE ret = null;
	   try {
	      ret = (SRM_S01_GENERAL_RESOURCE)this.get_Renamed("GENERAL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SRM_S01_GENERAL_RESOURCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SRM_S01_GENERAL_RESOURCE getGENERAL_RESOURCE(int rep) { 
	   return (SRM_S01_GENERAL_RESOURCE)this.get_Renamed("GENERAL_RESOURCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SRM_S01_GENERAL_RESOURCE 
	 */ 
	public int GENERAL_RESOURCEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("GENERAL_RESOURCE").Length; 
	    }
 catch (HL7Exception e) 
{ 
	        String message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of SRM_S01_LOCATION_RESOURCE (a Group object) - creates it if necessary
	 */
	public SRM_S01_LOCATION_RESOURCE  getLOCATION_RESOURCE() { 
	   SRM_S01_LOCATION_RESOURCE ret = null;
	   try {
	      ret = (SRM_S01_LOCATION_RESOURCE)this.get_Renamed("LOCATION_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SRM_S01_LOCATION_RESOURCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SRM_S01_LOCATION_RESOURCE getLOCATION_RESOURCE(int rep) { 
	   return (SRM_S01_LOCATION_RESOURCE)this.get_Renamed("LOCATION_RESOURCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SRM_S01_LOCATION_RESOURCE 
	 */ 
	public int LOCATION_RESOURCEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("LOCATION_RESOURCE").Length; 
	    }
 catch (HL7Exception e) 
{ 
	        String message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of SRM_S01_PERSONNEL_RESOURCE (a Group object) - creates it if necessary
	 */
	public SRM_S01_PERSONNEL_RESOURCE  getPERSONNEL_RESOURCE() { 
	   SRM_S01_PERSONNEL_RESOURCE ret = null;
	   try {
	      ret = (SRM_S01_PERSONNEL_RESOURCE)this.get_Renamed("PERSONNEL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SRM_S01_PERSONNEL_RESOURCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SRM_S01_PERSONNEL_RESOURCE getPERSONNEL_RESOURCE(int rep) { 
	   return (SRM_S01_PERSONNEL_RESOURCE)this.get_Renamed("PERSONNEL_RESOURCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SRM_S01_PERSONNEL_RESOURCE 
	 */ 
	public int PERSONNEL_RESOURCEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PERSONNEL_RESOURCE").Length; 
	    }
 catch (HL7Exception e) 
{ 
	        String message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
