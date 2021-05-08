using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Pg300_InterfacePractice
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("You can't have my " + base.funnyThingIHave);
        }

        public string ScaryThingIHave { get { return "I have " + numberOfScaryThings + " spiders"; } }
        private int numberOfScaryThings;
    }
}
