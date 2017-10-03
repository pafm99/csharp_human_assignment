using System;

namespace human
{
    class Program
    {

        static void Main(string[] args)
        {
            Person myPerson = new Person("Tim");
            Person secondPerson = new Person("Jesus");
            Console.WriteLine(myPerson.name);
            Console.WriteLine(secondPerson.name);
            myPerson.Run(8.8);
            secondPerson.Run(1.2);
            Console.WriteLine("{0} ran {1} miles and {2} ran {3} miles", myPerson.name, myPerson.distance, secondPerson.name, secondPerson.distance);
            Console.WriteLine(myPerson.health);
        }
    }
}
