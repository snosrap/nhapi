using System;
using System.Configuration;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
namespace NHapi.Base.Model.Configuration
{
    public class HL7PackageConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("hl7PackageCollection", IsDefaultCollection = false, IsRequired = false)]
        [Description("HL7 Packages")]
        public HL7PackageConfigurationElementCollection HL7PackageCollection
        {
            get
            {
                return (HL7PackageConfigurationElementCollection)this["hl7PackageCollection"];
            }
        }
    }




}
