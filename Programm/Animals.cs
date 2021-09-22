using System;


namespace Programm
{
    public class Animals
    {
        public string Name { get; set; }
        public string Group_Animal { get; set; }


        public Animals()
        {

        }

        public Animals (string Name, string Group_Animal)
        {
            this.Name = Name;
            this.Group_Animal = Group_Animal;
        }


        public void Going()
        {
            Console.WriteLine("Я умею ходить");
        }

        public void Jump()
        {
            Console.WriteLine("Я умею прыгать");
        }

        public void Hunt()
        {
            Console.WriteLine("Я умею охотиться");
        }

        virtual public void Voice()
        {
            Console.WriteLine("Я умею рычать ");
        }

    }

}
