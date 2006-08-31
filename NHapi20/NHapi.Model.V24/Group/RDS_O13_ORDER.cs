using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the RDS_O13_ORDER Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: ORC (Common Order) 
/// * 1: RDS_O13_ORDER_DETAIL (a Group object) optional 
/// * 2: RDS_O13_ENCODING (a Group object) optional 
/// * 3: RXD (Pharmacy/Treatment Dispense) 
/// * 4: RXR (Pharmacy/Treatment Route) repeating
/// * 5: RXC (Pharmacy/Treatment Component Order) optional repeating
/// * 6: RDS_O13_OBSERVATION (a Group object) optional repeating
/// * 7: FT1 (Financial Transaction) optional repeating
///</summary>
[Serializable]
public class RDS_O13_ORDER : AbstractGroup {

	///<summary> 
	/// Creates a new RDS_O13_ORDER Group.
	///</summary>
	public RDS_O13_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(RDS_O13_ORDER_DETAIL), false, false);
	      this.add(typeof(RDS_O13_ENCODING), false, false);
	      this.add(typeof(RXD), true, false);
	      this.add(typeof(RXR), true, true);
	      this.add(typeof(RXC), false, true);
	      this.add(typeof(RDS_O13_OBSERVATION), false, true);
	      this.add(typeof(FT1), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RDS_O13_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORC (Common Order) - creates it if necessary
	///</summary>
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.GetStructure("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RDS_O13_ORDER_DETAIL (a Group object) - creates it if necessary
	///</summary>
	public RDS_O13_ORDER_DETAIL ORDER_DETAIL { 
get{
	   RDS_O13_ORDER_DETAIL ret = null;
	   try {
	      ret = (RDS_O13_ORDER_DETAIL)this.GetStructure("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RDS_O13_ENCODING (a Group object) - creates it if necessary
	///</summary>
	public RDS_O13_ENCODING ENCODING { 
get{
	   RDS_O13_ENCODING ret = null;
	   try {
	      ret = (RDS_O13_ENCODING)this.GetStructure("ENCODING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RXD (Pharmacy/Treatment Dispense) - creates it if necessary
	///</summary>
	public RXD RXD { 
get{
	   RXD ret = null;
	   try {
	      ret = (RXD)this.GetStructure("RXD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary
	///</summary>
	public RXR getRXR() {
	   RXR ret = null;
	   try {
	      ret = (RXR)this.GetStructure("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RXR
	/// * (Pharmacy/Treatment Route) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RXR getRXR(int rep) { 
	   return (RXR)this.GetStructure("RXR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXR 
	 */ 
	public int RXRReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RXR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of RXC (Pharmacy/Treatment Component Order) - creates it if necessary
	///</summary>
	public RXC getRXC() {
	   RXC ret = null;
	   try {
	      ret = (RXC)this.GetStructure("RXC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RXC
	/// * (Pharmacy/Treatment Component Order) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RXC getRXC(int rep) { 
	   return (RXC)this.GetStructure("RXC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXC 
	 */ 
	public int RXCReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RXC").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of RDS_O13_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public RDS_O13_OBSERVATION getOBSERVATION() {
	   RDS_O13_OBSERVATION ret = null;
	   try {
	      ret = (RDS_O13_OBSERVATION)this.GetStructure("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RDS_O13_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RDS_O13_OBSERVATION getOBSERVATION(int rep) { 
	   return (RDS_O13_OBSERVATION)this.GetStructure("OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RDS_O13_OBSERVATION 
	 */ 
	public int OBSERVATIONReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of FT1 (Financial Transaction) - creates it if necessary
	///</summary>
	public FT1 getFT1() {
	   FT1 ret = null;
	   try {
	      ret = (FT1)this.GetStructure("FT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of FT1
	/// * (Financial Transaction) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public FT1 getFT1(int rep) { 
	   return (FT1)this.GetStructure("FT1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of FT1 
	 */ 
	public int FT1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("FT1").Length; 
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
