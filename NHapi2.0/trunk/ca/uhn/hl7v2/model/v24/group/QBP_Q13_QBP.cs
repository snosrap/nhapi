using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the QBP_Q13_QBP Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: Zxx (any Z segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class QBP_Q13_QBP : AbstractGroup {

	/** 
	 * Creates a new QBP_Q13_QBP Group.
	 */
	public QBP_Q13_QBP(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("Zxx", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating QBP_Q13_QBP - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns Zxx (any Z segment) - creates it if necessary
	 */
	public Zxx Zxx { 
get{
	   Zxx ret = null;
	   try {
	      ret = (Zxx)this.get_Renamed("Zxx");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
