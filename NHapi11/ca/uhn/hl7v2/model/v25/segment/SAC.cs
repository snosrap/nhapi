using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 SAC message segment. 
 * This segment has the following fields:</p><p>
 * SAC-1: External Accession Identifier (EI)<br> 
 * SAC-2: Accession Identifier (EI)<br> 
 * SAC-3: Container Identifier (EI)<br> 
 * SAC-4: Primary (parent) Container Identifier (EI)<br> 
 * SAC-5: Equipment Container Identifier (EI)<br> 
 * SAC-6: Specimen Source (SPS)<br> 
 * SAC-7: Registration Date/Time (TS)<br> 
 * SAC-8: Container Status (CE)<br> 
 * SAC-9: Carrier Type (CE)<br> 
 * SAC-10: Carrier Identifier (EI)<br> 
 * SAC-11: Position in Carrier (NA)<br> 
 * SAC-12: Tray Type - SAC (CE)<br> 
 * SAC-13: Tray Identifier (EI)<br> 
 * SAC-14: Position in Tray (NA)<br> 
 * SAC-15: Location (CE)<br> 
 * SAC-16: Container Height (NM)<br> 
 * SAC-17: Container Diameter (NM)<br> 
 * SAC-18: Barrier Delta (NM)<br> 
 * SAC-19: Bottom Delta (NM)<br> 
 * SAC-20: Container Height/Diameter/Delta Units (CE)<br> 
 * SAC-21: Container Volume (NM)<br> 
 * SAC-22: Available Specimen Volume (NM)<br> 
 * SAC-23: Initial Specimen Volume (NM)<br> 
 * SAC-24: Volume Units (CE)<br> 
 * SAC-25: Separator Type (CE)<br> 
 * SAC-26: Cap Type (CE)<br> 
 * SAC-27: Additive (CWE)<br> 
 * SAC-28: Specimen Component (CE)<br> 
 * SAC-29: Dilution Factor (SN)<br> 
 * SAC-30: Treatment (CE)<br> 
 * SAC-31: Temperature (SN)<br> 
 * SAC-32: Hemolysis Index (NM)<br> 
 * SAC-33: Hemolysis Index Units (CE)<br> 
 * SAC-34: Lipemia Index (NM)<br> 
 * SAC-35: Lipemia Index Units (CE)<br> 
 * SAC-36: Icterus Index (NM)<br> 
 * SAC-37: Icterus Index Units (CE)<br> 
 * SAC-38: Fibrin Index (NM)<br> 
 * SAC-39: Fibrin Index Units (CE)<br> 
 * SAC-40: System Induced Contaminants (CE)<br> 
 * SAC-41: Drug Interference (CE)<br> 
 * SAC-42: Artificial Blood (CE)<br> 
 * SAC-43: Special Handling Code (CWE)<br> 
 * SAC-44: Other Environmental Factors (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class SAC : AbstractSegment  {

  /**
   * Creates a SAC (Specimen Container detail) segment object that belongs to the given 
   * message.  
   */
  public SAC(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "External Accession Identifier");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Accession Identifier");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Container Identifier");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Primary (parent) Container Identifier");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Equipment Container Identifier");
       this.add(typeof(SPS), false, 1, 300, new System.Object[]{message}, "Specimen Source");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Registration Date/Time");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Container Status");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Carrier Type");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Carrier Identifier");
       this.add(typeof(NA), false, 1, 80, new System.Object[]{message}, "Position in Carrier");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Tray Type - SAC");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Tray Identifier");
       this.add(typeof(NA), false, 1, 80, new System.Object[]{message}, "Position in Tray");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Location");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Container Height");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Container Diameter");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Barrier Delta");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Bottom Delta");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Container Height/Diameter/Delta Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Container Volume");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Available Specimen Volume");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Initial Specimen Volume");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Volume Units");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Separator Type");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Cap Type");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Additive");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Specimen Component");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Dilution Factor");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Treatment");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Temperature");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Hemolysis Index");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Hemolysis Index Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Lipemia Index");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Lipemia Index Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Icterus Index");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Icterus Index Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Fibrin Index");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Fibrin Index Units");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "System Induced Contaminants");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Drug Interference");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Artificial Blood");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Special Handling Code");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Other Environmental Factors");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns External Accession Identifier(SAC-1).
	*/
	public EI ExternalAccessionIdentifier
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Accession Identifier(SAC-2).
	*/
	public EI AccessionIdentifier
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Container Identifier(SAC-3).
	*/
	public EI ContainerIdentifier
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Primary (parent) Container Identifier(SAC-4).
	*/
	public EI PrimaryParentContainerIdentifier
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Equipment Container Identifier(SAC-5).
	*/
	public EI EquipmentContainerIdentifier
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(5, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Specimen Source(SAC-6).
	*/
	public SPS SpecimenSource
	{
		get{
			SPS ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (SPS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Registration Date/Time(SAC-7).
	*/
	public TS RegistrationDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Container Status(SAC-8).
	*/
	public CE ContainerStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Carrier Type(SAC-9).
	*/
	public CE CarrierType
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Carrier Identifier(SAC-10).
	*/
	public EI CarrierIdentifier
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Position in Carrier(SAC-11).
	*/
	public NA PositionInCarrier
	{
		get{
			NA ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (NA)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Tray Type - SAC(SAC-12).
	*/
	public CE TrayTypeSAC
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Tray Identifier(SAC-13).
	*/
	public EI TrayIdentifier
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Position in Tray(SAC-14).
	*/
	public NA PositionInTray
	{
		get{
			NA ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (NA)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Location(SAC-15).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getLocation(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(15, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Location (SAC-15).
   */
  public CE[] getLocation() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(15);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Container Height(SAC-16).
	*/
	public NM ContainerHeight
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(16, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Container Diameter(SAC-17).
	*/
	public NM ContainerDiameter
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(17, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Barrier Delta(SAC-18).
	*/
	public NM BarrierDelta
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Bottom Delta(SAC-19).
	*/
	public NM BottomDelta
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(19, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Container Height/Diameter/Delta Units(SAC-20).
	*/
	public CE ContainerHeightDiameterDeltaUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(20, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Container Volume(SAC-21).
	*/
	public NM ContainerVolume
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(21, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Available Specimen Volume(SAC-22).
	*/
	public NM AvailableSpecimenVolume
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(22, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Initial Specimen Volume(SAC-23).
	*/
	public NM InitialSpecimenVolume
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(23, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Volume Units(SAC-24).
	*/
	public CE VolumeUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(24, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Separator Type(SAC-25).
	*/
	public CE SeparatorType
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(25, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Cap Type(SAC-26).
	*/
	public CE CapType
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(26, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Additive(SAC-27).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getAdditive(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(27, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Additive (SAC-27).
   */
  public CWE[] getAdditive() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(27);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Specimen Component(SAC-28).
	*/
	public CE SpecimenComponent
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(28, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Dilution Factor(SAC-29).
	*/
	public SN DilutionFactor
	{
		get{
			SN ret = null;
			try
			{
			Type t = this.getField(29, 0);
				ret = (SN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Treatment(SAC-30).
	*/
	public CE Treatment
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(30, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Temperature(SAC-31).
	*/
	public SN Temperature
	{
		get{
			SN ret = null;
			try
			{
			Type t = this.getField(31, 0);
				ret = (SN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Hemolysis Index(SAC-32).
	*/
	public NM HemolysisIndex
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(32, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Hemolysis Index Units(SAC-33).
	*/
	public CE HemolysisIndexUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(33, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Lipemia Index(SAC-34).
	*/
	public NM LipemiaIndex
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(34, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Lipemia Index Units(SAC-35).
	*/
	public CE LipemiaIndexUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(35, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Icterus Index(SAC-36).
	*/
	public NM IcterusIndex
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(36, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Icterus Index Units(SAC-37).
	*/
	public CE IcterusIndexUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(37, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Fibrin Index(SAC-38).
	*/
	public NM FibrinIndex
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(38, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Fibrin Index Units(SAC-39).
	*/
	public CE FibrinIndexUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(39, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of System Induced Contaminants(SAC-40).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getSystemInducedContaminants(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(40, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of System Induced Contaminants (SAC-40).
   */
  public CE[] getSystemInducedContaminants() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(40);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Drug Interference(SAC-41).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getDrugInterference(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(41, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Drug Interference (SAC-41).
   */
  public CE[] getDrugInterference() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(41);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Artificial Blood(SAC-42).
	*/
	public CE ArtificialBlood
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(42, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Special Handling Code(SAC-43).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSpecialHandlingCode(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(43, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Special Handling Code (SAC-43).
   */
  public CWE[] getSpecialHandlingCode() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(43);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Other Environmental Factors(SAC-44).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getOtherEnvironmentalFactors(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(44, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Other Environmental Factors (SAC-44).
   */
  public CE[] getOtherEnvironmentalFactors() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(44);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}


}}