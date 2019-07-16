using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ICannotFly : IFly
    {
        public string Fly()
        {
            return "I cannot fly ...... basa";
        }
    }
}
