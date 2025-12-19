using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    // Hair struct and overrride for ToString
    public struct Hair
    {
        public string HairColor { get; set; }
        public int HairLength { get; set;}
        public override string ToString()
        {
            return $"Hair Color: {HairColor}\nHair Length: {HairLength}cm";
        }

    }
}

