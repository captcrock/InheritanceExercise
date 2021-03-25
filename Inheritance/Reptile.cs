using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile: Animal
    {
        public bool hasScales { get; set; }
        public int monthsActive { get; set; }
        public bool legs { get; set; }
        public string commonName { get; set; }
    }
}
