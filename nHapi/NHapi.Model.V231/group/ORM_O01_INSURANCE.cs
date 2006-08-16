using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v231.segment;

using NHapi.Base.model;
/**
 * <p>Represents the ORM_O01_INSURANCE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: IN1 (IN1 - insurance segment) <b></b><br>
 * 1: IN2 (IN2 - insurance additional information segment) <b>optional </b><br>
 * 2: IN3 (IN3 - insurance additional information, certification segment) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v231.group
{
[Serializable]
public class ORM_O01_INSURANCE : AbstractGroup {

	/** 
	 * Creates a new ORM_O01_INSURANCE Group.
	 */
	public ORM_O01_INSURANCE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("IN1", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("IN2", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("IN3", "2.3.1"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORM_O01_INSURANCE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns IN1 (IN1 - insurance segment) - creates it if necessary
	 */
	public IN1 IN1 { 
get{
	   IN1 ret = null;
	   try {
	      ret = (IN1)this.get_Renamed("IN1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns IN2 (IN2 - insurance additional information segment) - creates it if necessary
	 */
	public IN2 IN2 { 
get{
	   IN2 ret = null;
	   try {
	      ret = (IN2)this.get_Renamed("IN2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of IN3 (IN3 - insurance additional information, certification segment) - creates it if necessary
	 */
	public IN3  getIN3() { 
	   IN3 ret = null;
	   try {
	      ret = (IN3)this.get_Renamed("IN3");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of IN3
	 * (IN3 - insurance additional information, certification segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public IN3 getIN3(int rep) { 
	   return (IN3)this.get_Renamed("IN3", rep);
	}

	/** 
	 * Returns the number of existing repetitions of IN3 
	 */ 
	public int IN3Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("IN3").Length; 
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
