using System;
using System.Configuration;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace NHapi.Base.Model.Configuration
{
    /// <summary>
    /// Hl7 package configuration element
    /// </summary>
    public class HL7PackageConfigurationElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new HL7PackageConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            if ((element) is HL7PackageConfigurationElement)
            {
                HL7PackageConfigurationElement el =
                    (HL7PackageConfigurationElement)element;

                return el.HL7Package;
            }

            throw new ArgumentException("The specified element is not of the correct type.");
        }
    }
}
