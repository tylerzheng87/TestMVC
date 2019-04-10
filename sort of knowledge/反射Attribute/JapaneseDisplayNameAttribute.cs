using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射Attribute
{
    class JapaneseDisplayNameAttribute:Attribute
    {
        public string DisplayName { get; set; }
        public JapaneseDisplayNameAttribute(string value)
        {
            this.DisplayName = value;

        }
    }
}
