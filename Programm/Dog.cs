using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    class Dog : Animals
    {
        public string Breed { get; set; }
        public new string Name { get; set; }
       

        public override void Voice()
        {
            Console.WriteLine("я умею лаять");
        }

        public void Jumping()
        {
            Console.WriteLine("Я умею прыгать");
        }

        public void Obey ()
        {
            Console.WriteLine("Я умею слушаться хозяина");
        }


        public Dog()
        {

        }

        public Dog(string Breed, string Name)
        {
            this.Breed = Breed;
            this.Name = Name;
        }
    }
}
