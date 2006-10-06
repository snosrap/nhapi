/// <summary> This class is based on the Iterators.FilterIterator class from
/// araSpect (araspect.sourceforge.net).  The original copyright follows ...
/// 
/// =================================================================
/// Copyright (c) 2001,2002 aragost ag, Zürich, Switzerland.
/// All rights reserved.
/// 
/// This software is provided 'as-is', without any express or implied
/// warranty. In no event will the authors be held liable for any
/// damages arising from the use of this software.
/// 
/// Permission is granted to anyone to use this software for any
/// purpose, including commercial applications, and to alter it and
/// redistribute it freely, subject to the following restrictions:
/// 
/// 1. The origin of this software must not be misrepresented; you
/// must not claim that you wrote the original software. If you
/// use this software in a product, an acknowledgment in the
/// product documentation would be appreciated but is not required.
/// 
/// 2. Altered source versions must be plainly marked as such, and
/// must not be misrepresented as being the original software.
/// 
/// 3. This notice may not be removed or altered from any source
/// distribution.
/// 
/// ==================================================================
/// 
/// Changes (c) 2003 University Health Network include the following:
/// - move to non-nested class
/// - collapse inherited method remove()
/// - accept iterator instead of object in constructor
/// - moved to HAPI package
/// - Predicate added as an inner class; also changed to an interface
/// 
/// These changes are distributed under the same terms as the original (above). 
/// </summary>
using System;
namespace ca.uhn.hl7v2.util
{
	
	public class FilterIterator : System.Collections.IEnumerator
	{
		public virtual System.Object Current
		{
			get
			{
				if (!nextObjectSet)
				{
					if (!setNextObject())
					{
						throw new System.ArgumentOutOfRangeException();
					}
				}
				nextObjectSet = false;
				return nextObject;
			}
			
		}
		
		private FilterIterator.Predicate predicate;
		private System.Collections.IEnumerator iter;
		private System.Object nextObject;
		private bool nextObjectSet = false;
		
		public FilterIterator(System.Collections.IEnumerator iter, FilterIterator.Predicate predicate)
		{
			this.iter = iter;
			this.predicate = predicate;
		}
		
		public virtual bool MoveNext()
		{
			if (nextObjectSet)
			{
				return true;
			}
			else
			{
				return setNextObject();
			}
		}
		
		/// <summary> Set nextObject to the next object. If there are no more
		/// objects then return false. Otherwise, return true.
		/// </summary>
		private bool setNextObject()
		{
			//UPGRADE_TODO: Method 'java.util.Iterator.hasNext' was converted to 'System.Collections.IEnumerator.MoveNext' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilIteratorhasNext'"
			while (iter.MoveNext())
			{
				//UPGRADE_TODO: Method 'java.util.Iterator.next' was converted to 'System.Collections.IEnumerator.Current' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilIteratornext'"
				System.Object object_Renamed = iter.Current;
				if (predicate.evaluate(object_Renamed))
				{
					nextObject = object_Renamed;
					nextObjectSet = true;
					return true;
				}
			}
			return false;
		}
		
		/// <summary>Throws UnsupportedOperationException </summary>
		//UPGRADE_NOTE: The equivalent of method 'java.util.Iterator.remove' is not an override method. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1143'"
		public virtual void  remove()
		{
			throw new System.NotSupportedException();
		}
		
		public interface Predicate
		{
			bool evaluate(System.Object obj);
		}
		//UPGRADE_TODO: The following method was automatically generated and it must be implemented in order to preserve the class logic. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1232'"
		virtual public void  Reset()
		{
		}
	}
}