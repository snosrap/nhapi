using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V22.Segment;

using NHapi.Base.Model;
/**
 * <p>Represents the NMQ_N02_QRY_WITH_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: QRD (QUERY DEFINITION) <b></b><br>
 * 1: QRF (QUERY FILTER) <b>optional </b><br>
 */
namespace NHapi.Model.V22.Group
{
[Serializable]
public class NMQ_N02_QRY_WITH_DETAIL : AbstractGroup {

	/** 
	 * Creates a new NMQ_N02_QRY_WITH_DETAIL Group.
	 */
	public NMQ_N02_QRY_WITH_DETAIL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(QRF), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMQ_N02_QRY_WITH_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns QRD (QUERY DEFINITION) - creates it if necessary
	 */
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.getStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns QRF (QUERY FILTER) - creates it if necessary
	 */
	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.getStructure("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
