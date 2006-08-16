using System;
using NHapi.Base.model;
using NHapi.Base.model.v231.datatype;

using ca.uhn.log;
using NHapi.Base.parser;
using NHapi.Base;

namespace NHapi.Base.model.v231.segment{

/**
 * <p>Represents an HL7 ZL7 message segment. 
 * This segment has the following fields:</p><p>
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class ZL7 : AbstractSegment  {

  /**
   * Creates a ZL7 () segment object that belongs to the given 
   * message.  
   */
  public ZL7(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
  }


}}