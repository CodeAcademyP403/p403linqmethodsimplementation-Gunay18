using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Person
    {
        public byte ID { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            return ID+" "+Name + " " + Age; 

        }
    }
    
}
