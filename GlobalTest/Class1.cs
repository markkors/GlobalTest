using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTest
{
    public class Class1
    {

        String naam;
        public Class1(string n)
        {
            naam = n;

        }

        public string MyProperty
        {
            get { return naam; }
            set { naam = value; }
        }
    }
}

