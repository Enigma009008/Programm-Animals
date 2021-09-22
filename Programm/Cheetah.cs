using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    class Cheetah : Animals
    {
        public override void Voice()
        {
            Console.WriteLine("Я умею рычать");
        }

        public void Run()
        {
            Console.WriteLine("Я умею очень быстро бегать");
        }


    }
}
