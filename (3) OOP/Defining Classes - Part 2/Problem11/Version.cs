using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
    AllowMultiple = true)]

    public class VersionAttribute : System.Attribute
    {
        public int MajorVersion { get; private set; }
        public int MinorVersion { get; private set; }
        public string Version { get; private set; }

        public VersionAttribute(int majourVersion, int minorVersion)
        {
            
            this.MajorVersion = majourVersion;
            this.MinorVersion = minorVersion;
            this.Version = String.Format("{0}.{1}", majourVersion, minorVersion);
        }
    }
}