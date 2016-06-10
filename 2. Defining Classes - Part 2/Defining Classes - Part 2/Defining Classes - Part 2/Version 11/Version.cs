using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum)]
    public class VersionAttribute : Attribute
    {
        public int Major { get; private set; }

        public int Minor { get; set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public override string ToString()
        {
            return string.Format("Version {0}.{1}", this.Major, this.Minor);
        }
    }
}
