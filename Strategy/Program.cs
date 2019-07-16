using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird twitty = new Bird("Twitty", 0.3f);

            Console.WriteLine(twitty);

            twitty.SetFlyingAbility(new ICannotFly()); // twitty is not feeling well, cannot fly for 24 hours

            Console.WriteLine(twitty);

            Dog rex = new Dog("Rexi", 0.7f);

            Console.WriteLine(rex);

            rex.SetFlyingAbility(new ICanFly()); // Rexi is now super dog!

            Console.WriteLine(rex);
        }
    }
}
