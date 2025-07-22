using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inputypes
{
    internal class DataModel
    {
        public string name;
        public string value;

        public override string ToString()
        {
            return $"name: {name}, value: {value}";
        }
    }
}
