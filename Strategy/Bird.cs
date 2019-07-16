using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Bird : Animal
    {

        public Bird(string name, float height) : base(name, height)
        {
            myFliyingAbility = new ICanFly();
        }
    }
}
