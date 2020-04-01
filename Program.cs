using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass myclass = new myClass("Mikkel","Vonsildvej 2",2770);
            myClass myclass2 = new myClass("Anna","Skovløbervej 30",2400);
            myClass myclass3 = new myClass("Robin","Amager Strandvej 150",2770);

            Console.WriteLine(myclass);
            Console.WriteLine(myclass2);
            Console.WriteLine(myclass3);

            


        }
    }
}
