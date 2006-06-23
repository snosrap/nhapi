using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SIU_S16_RESOURCES Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RGS (Resource Group) <b></b><br>
 * 1: SIU_S16_SERVICE (a Group object) <b>optional repeating</b><br>
 * 2: SIU_S16_GENERAL_RESOURCE (a Group object) <b>optional repeating</b><br>
 * 3: SIU_S16_LOCATIONL_RESOURCE (a Group object) <b>optional repeating</b><br>
 * 4: SIU_S16_PERSONNEL_RESOURCE (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class SIU_S16_RESOURCES : AbstractGroup {

	/** 
	 * Creates a new SIU_S16_RESOURCES Group.
	 */
	public SIU_S16_RESOURCES(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("RGS", "2.3"), true, false);
	      this.add(factory.getGroupClass("SIU_S16_SERVICE", "2.3"), false, true);
	      this.add(factory.getGroupClass("SIU_S16_GENERAL_RESOURCE", "2.3"), false, true);
	      this.add(factory.getGroupClass("SIU_S16_LOCATIONL_RESOURCE", "2.3"), false, true);
	      this.add(factory.getGroupClass("SIU_S16_PERSONNEL_RESOURCE", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SIU_S16_RESOURCES - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of SIU_S16_SERVICE (a Group object) - creates it if necessary
	 */
	public SIU_S16_SERVICE  getSERVICE() { 
	   SIU_S16_SERVICE ret = null;
	   try {
	      ret = (SIU_S16_SERVICE)this.get_Renamed("SERVICE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SIU_S16_SERVICE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SIU_S16_SERVICE getSERVICE(int rep) { 
	   return (SIU_S16_SERVICE)this.get_Renamed("SERVICE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SIU_S16_SERVICE 
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
	 * Returns  first repetition of SIU_S16_GENERAL_RESOURCE (a Group object) - creates it if necessary
	 */
	public SIU_S16_GENERAL_RESOURCE  getGENERAL_RESOURCE() { 
	   SIU_S16_GENERAL_RESOURCE ret = null;
	   try {
	      ret = (SIU_S16_GENERAL_RESOURCE)this.get_Renamed("GENERAL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SIU_S16_GENERAL_RESOURCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SIU_S16_GENERAL_RESOURCE getGENERAL_RESOURCE(int rep) { 
	   return (SIU_S16_GENERAL_RESOURCE)this.get_Renamed("GENERAL_RESOURCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SIU_S16_GENERAL_RESOURCE 
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
	 * Returns  first repetition of SIU_S16_LOCATIONL_RESOURCE (a Group object) - creates it if necessary
	 */
	public SIU_S16_LOCATIONL_RESOURCE  getLOCATIONL_RESOURCE() { 
	   SIU_S16_LOCATIONL_RESOURCE ret = null;
	   try {
	      ret = (SIU_S16_LOCATIONL_RESOURCE)this.get_Renamed("LOCATIONL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SIU_S16_LOCATIONL_RESOURCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SIU_S16_LOCATIONL_RESOURCE getLOCATIONL_RESOURCE(int rep) { 
	   return (SIU_S16_LOCATIONL_RESOURCE)this.get_Renamed("LOCATIONL_RESOURCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SIU_S16_LOCATIONL_RESOURCE 
	 */ 
	public int LOCATIONL_RESOURCEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("LOCATIONL_RESOURCE").Length; 
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
	 * Returns  first repetition of SIU_S16_PERSONNEL_RESOURCE (a Group object) - creates it if necessary
	 */
	public SIU_S16_PERSONNEL_RESOURCE  getPERSONNEL_RESOURCE() { 
	   SIU_S16_PERSONNEL_RESOURCE ret = null;
	   try {
	      ret = (SIU_S16_PERSONNEL_RESOURCE)this.get_Renamed("PERSONNEL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SIU_S16_PERSONNEL_RESOURCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SIU_S16_PERSONNEL_RESOURCE getPERSONNEL_RESOURCE(int rep) { 
	   return (SIU_S16_PERSONNEL_RESOURCE)this.get_Renamed("PERSONNEL_RESOURCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SIU_S16_PERSONNEL_RESOURCE 
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
