using System;
using System.Configuration;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace NHapi.Base.Model.Configuration
{
    /// <summary>
    /// Hl7 custom package configuration element
    /// </summary>
    public class HL7PackageConfigurationElement : ConfigurationElement
    {
        /// <summary>
        /// An HL7 package
        /// </summary>
        [ConfigurationProperty("hl7Package", DefaultValue = "", IsKey = true, IsRequired = true)]
        [Description("HL7 package assembly name")]
        public string HL7Package
        {
            get
            {
                return this["hl7Package"].ToString();
            }
            set
            {
                this["hl7Package"] = value;
            }
        }
    }
}
