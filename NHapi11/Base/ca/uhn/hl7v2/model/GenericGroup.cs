using System;
using ModelClassFactory = ca.uhn.hl7v2.parser.ModelClassFactory;
namespace ca.uhn.hl7v2.model
{
	
	/// <summary> An undefined segment group.  This is for storing undefined groups
	/// that appear in XML-encoded messages.  Note that if an undefined group appears 
	/// in an ER7-encoded message, the group structure won't be clear and we'll just assume 
	/// it's a flat list of segments.    
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class GenericGroup:AbstractGroup
	{
		
		private System.String name;
		
		/// <summary>Creates a new instance of GenericGroup </summary>
		public GenericGroup(Group parent, System.String name, ModelClassFactory factory):base(parent, factory)
		{
			this.name = name;
		}
		
		/// <summary>Returns the Message object to which this segment belongs.  This should normally be set at
		/// construction time.  A Structure can only belong to a single Message.  This is primarily
		/// to avoid a situation where intended changes in one message cause unintended changes
		/// in another that shares one of the same Structure objects.
		/// </summary>
		/*public Message getMessage() {
		return super.message;
		}*/
		
		/// <summary> Returns the name specified at construction time. </summary>
		/// <seealso cref="Structure.getName()">
		/// </seealso>
		public override System.String getStructureName()
		{
			return this.name;
		}
	}
}