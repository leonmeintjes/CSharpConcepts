using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explicit Contstructor
            ClassConstructors ThisConstruct = new ClassConstructors(37,"Koos Du Plessis");
            Console.WriteLine($"This guy is called {ThisConstruct.Name}");
            Console.WriteLine($"This guy is {ThisConstruct.Age} years old");
            
            //Default Constructor - Method 1
            ClassConstructors ThisConstruct2 = new ClassConstructors();
            ThisConstruct2.Age = 32;
            ThisConstruct2.Name = "Son Ofagun";
            Console.WriteLine($"This guy2 is called {ThisConstruct2.Name}");
            Console.WriteLine($"This guy2 is {ThisConstruct2.Age} years old");

            //Default Constructor - Method 2
            ClassConstructors ThisConstruct3 = new ClassConstructors()
            {
                Age = 22, Name = "Sannie Vanderskoor"
            
            };
            Console.WriteLine($"This guy3 is called {ThisConstruct3.Name}");
            Console.WriteLine($"This guy3 is {ThisConstruct3.Age} years old");

            //Non static methods - (Does not have the word static and must be instantiated before use)
            //Called from the instance of a class
            StaticAndNonStaticMethods ReturnTheAnswer = new StaticAndNonStaticMethods();
            double thisAnswer = ReturnTheAnswer.NonStaticMethod("200");
            Console.WriteLine("This non static answer is " + thisAnswer );
            
            //Static methods - (has the word static and can be called without instantiating the class) 
            //Called directly from the class
            double thirdAnswer = StaticAndNonStaticMethods.StaticMethod("200");
            


            Console.ReadLine();

        }
    }
}
