using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    class Program
    {

        static void Main(string[] args)
        {
          
            List<Animals> animal = new List<Animals>()
            {
                new Animals ("Собака", ""),
                new Animals("Кошка", ""),
                new Animals("Леопард", ""),
                new Animals("Слон", ""),
                new Animals("Зебра", ""),
                new Animals("Лев", ""),
                new Animals("Носорог", ""),
                new Animals("Жираф", ""),
            };

            foreach(var item in animal)
            {
                Console.WriteLine(item.Name);
            }



            Animals animals = new Animals();         
            animals.Hunt();
            Dog dog = new Dog();
            dog.Obey();
            Cheetah cheetah = new Cheetah();
            cheetah.Run();
            Console.ReadKey();
        }

      
            
    }
}
