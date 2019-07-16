using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Animal 
    {
        protected string name;

        protected float height;

        protected IFly myFliyingAbility;

        public Animal(string name, float height)
        {
            this.name = name;
            this.height = height;
        }

        public override string ToString()
        {
            return $"name : {name} height : {height} when fly : {myFliyingAbility.Fly()}";
        }

        public void SetFlyingAbility(IFly flyer)
        {
            this.myFliyingAbility = flyer;
        }
    }
}
