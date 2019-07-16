using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Dog : Animal
    {
        public Dog(string name, float height) : base(name, height)
        {
            myFliyingAbility = new ICannotFly();
        }
    }
}
