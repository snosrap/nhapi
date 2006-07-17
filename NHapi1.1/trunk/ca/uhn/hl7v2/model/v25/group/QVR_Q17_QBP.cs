using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the QVR_Q17_QBP Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: Hxx (any HL7 segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class QVR_Q17_QBP : AbstractGroup {

	/** 
	 * Creates a new QVR_Q17_QBP Group.
	 */
	public QVR_Q17_QBP(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(Hxx), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating QVR_Q17_QBP - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns Hxx (any HL7 segment) - creates it if necessary
	 */
	public Hxx Hxx { 
get{
	   Hxx ret = null;
	   try {
	      ret = (Hxx)this.get_Renamed("Hxx");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
