using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool predator { get; set; }
        public bool doesFly { get; set; }
        public int hourCanFly { get; set; }
        public string name { get; set; }
    }
}
