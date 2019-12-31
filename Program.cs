using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson4
{
    /// <summary>
    /// This class is the driver class for our program
    /// 
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //creating an insance of the Person class
            Person tanya = new Person();
            tanya.Name = "Tanya";
            tanya.Age = 28;
            tanya.SayHello();
            tanya.ShowAge();
            Console.WriteLine();

            Person tom = new Person("Tom");
            tom.Age = 47;
            tom.SayHello();
            tom.ShowAge();
            Console.WriteLine();


            Person mark = new Person(30);
            mark.Name = "Mark";
            mark.SayHello();
            mark.ShowAge();
            Console.WriteLine();


            Person mary = new Person("Mary", 23);
            mary.SayHello();
            mary.ShowAge();
            Console.WriteLine();

            Student tommy = new Student("Tommy",20,"S123456789");
            tommy.Age = 20;
            tommy.SayHello();
            tommy.Studies();

            //create an instance of Teacher class
            Teacher tomm = new Teacher("Tom", 47, "T123456789");
            tomm.Teaches();

        }
    }

}
