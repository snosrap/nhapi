using System;
using System.Collections.Generic;
using System.Text;
using NHapi.Base.Model;

namespace NHapi.Base.Model
{
    public class AbstractGroupItem
    {
        private string _name;
        private List<IStructure> _structures = new List<IStructure>();
        private bool _isRequired = false;
        private bool _isRepeating = false;
        private System.Type _class;

        public AbstractGroupItem(string name, bool required, bool repeating, System.Type classType)
        {
            _name = name;
            _isRequired = required;
            _isRepeating = repeating;
            _class = classType;
        }


        public string Name
        {
            get { return _name; }
        }

        public System.Type ClassType
        {
            get { return _class; }
        }

        public bool IsRepeating
        {
            get { return _isRepeating; }
        }

        public bool IsRequired
        {
            get { return _isRequired; }
        }

        public List<IStructure> Structures
        {
            get
            {
                return _structures;
            }
        }

        public IStructure this[int index]
        {
            get
            {
                return _structures[index];
            }
            set
            {
                if (index > 0 && !_isRepeating)
                    throw new HL7Exception("Cannot add multiple strucutres to " + _name + ".  Item is non-repeating");

                _structures[index] = value;

            }
        }
    }
}
