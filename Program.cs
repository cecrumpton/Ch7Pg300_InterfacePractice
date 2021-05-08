using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Pg300_InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            //FunnyFunny someFunnyClown = fingersTheClown;
            //IScaryClown someOtherScaryClown = someFunnyClown as IScaryClown;
            IScaryClown someOtherScaryClown = new ScaryScary("big shoes", 14) as IScaryClown;
            someOtherScaryClown.Honk();
            Console.WriteLine(someOtherScaryClown.ScaryThingIHave);
            someOtherScaryClown.ScareLittleChildren();
            Console.ReadKey();

            //TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            //tallGuy.TalkAboutYourself();
            //tallGuy.Honk();
        }
    }
}
