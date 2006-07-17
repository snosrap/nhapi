/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Defaultalidation.java".  Description: 
/// "A ValidationContext with a default set of rules initially defined." 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2004.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using Rule = ca.uhn.hl7v2.validation.Rule;
namespace ca.uhn.hl7v2.validation.impl
{
	
	
	/// <summary> A <code>ValidationContext</code> with a default set of rules initially defined.
	/// This can be used as-is for a reasonable level of primitive type validation.   
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1.1.1 $ updated on $Date: 2006/05/16 19:49:22 $ by $Author: whitedog12 $
	/// </version>
	public class DefaultValidation:ValidationContextImpl
	{
		public DefaultValidation()
		{
			Rule trim = new TrimLeadingWhitespace();
			PrimitiveRuleBindings.Add(new RuleBinding("*", "FT", trim));
			PrimitiveRuleBindings.Add(new RuleBinding("*", "ST", trim));
			PrimitiveRuleBindings.Add(new RuleBinding("*", "TX", trim));
			
			Rule size200 = new SizeRule(200);
			Rule size32000 = new SizeRule(32000);
			PrimitiveRuleBindings.Add(new RuleBinding("*", "FT", size32000));
			PrimitiveRuleBindings.Add(new RuleBinding("*", "ID", size200));
			PrimitiveRuleBindings.Add(new RuleBinding("*", "IS", size200));
			
			Rule nonNegativeInteger = new RegexPrimitiveRule("\\d*", "");
			PrimitiveRuleBindings.Add(new RuleBinding("*", "SI", nonNegativeInteger));
			
			Rule number = new RegexPrimitiveRule("(\\+|\\-)?\\d*\\.?\\d*", "");
			PrimitiveRuleBindings.Add(new RuleBinding("*", "NM", number));
			
//			Rule telephoneNumber = new RegexPrimitiveRule("(\\d{1,2} )?(\\(\\d{3}\\))?\\d{3}-\\d{4}(X\\d{1,5})?(B\\d{1,5})?(C.*)?", "Version 2.4 Section 2.9.45");
//			PrimitiveRuleBindings.Add(new RuleBinding("*", "TN", telephoneNumber));
			
			System.String datePattern = "(\\d{4}([01]\\d(\\d{2})?)?)?"; //YYYY[MM[DD]]
			Rule date = new RegexPrimitiveRule(datePattern, "Version 2.5 Section 2.16.24");
			PrimitiveRuleBindings.Add(new RuleBinding("*", "DT", date));
			
			System.String timePattern = "([012]\\d([0-5]\\d([0-5]\\d(\\.\\d(\\d(\\d(\\d)?)?)?)?)?)?)?([\\+\\-]\\d{4})?";
			Rule time = new RegexPrimitiveRule(timePattern, "Version 2.5 Section 2.16.79");
			PrimitiveRuleBindings.Add(new RuleBinding("*", "TM", time));
			
			System.String datetimePattern = "(\\d{4}([01]\\d(\\d{2}([012]\\d([0-5]\\d([0-5]\\d(\\.\\d(\\d(\\d(\\d)?)?)?)?)?)?)?)?)?)?([\\+\\-]\\d{4})?";
			Rule datetime = new RegexPrimitiveRule(datetimePattern, "Version 2.5 Section 2.16.25");
			PrimitiveRuleBindings.Add(new RuleBinding("*", "TSComponentOne", datetime));
			PrimitiveRuleBindings.Add(new RuleBinding("*", "DTM", datetime));
		}
	}
}