using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V22.Segment;

using NHapi.Base.Model;
/**
 * <p>Represents the ADT_A07_INSURANCE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: IN1 (INSURANCE) <b></b><br>
 * 1: IN2 (INSURANCE ADDITIONAL INFO) <b>optional </b><br>
 * 2: IN3 (INSURANCE ADDITIONAL INFO-CERTIFICATION) <b>optional </b><br>
 */
namespace NHapi.Model.V22.Group
{
[Serializable]
public class ADT_A07_INSURANCE : AbstractGroup {

	/** 
	 * Creates a new ADT_A07_INSURANCE Group.
	 */
	public ADT_A07_INSURANCE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(IN1), true, false);
	      this.add(typeof(IN2), false, false);
	      this.add(typeof(IN3), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A07_INSURANCE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns IN1 (INSURANCE) - creates it if necessary
	 */
	public IN1 IN1 { 
get{
	   IN1 ret = null;
	   try {
	      ret = (IN1)this.getStructure("IN1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns IN2 (INSURANCE ADDITIONAL INFO) - creates it if necessary
	 */
	public IN2 IN2 { 
get{
	   IN2 ret = null;
	   try {
	      ret = (IN2)this.getStructure("IN2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns IN3 (INSURANCE ADDITIONAL INFO-CERTIFICATION) - creates it if necessary
	 */
	public IN3 IN3 { 
get{
	   IN3 ret = null;
	   try {
	      ret = (IN3)this.getStructure("IN3");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
