using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Pg300_InterfacePractice
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            Console.WriteLine(FunnyThingIHave);
        }

        protected string funnyThingIHave;
        public string FunnyThingIHave { get { return "Hi kids! I have a " + funnyThingIHave; } }
    }
}
