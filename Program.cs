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

            Student tommy = new Student("Tommy", 20, "S123456789");
            tommy.Age = 20;
            tommy.SayHello();
            tommy.Studies();
            tommy.Courses.Add(new Course("COMP123", "Programming2"));
            tommy.Courses.Add(new Course("COM125", "Web Design"));
            tommy.ShowCourses();

            //create an instance of Teacher class
            Teacher tomm = new Teacher("Tom", 47, "T123456789");
            tomm.Teaches();

            MyList myList = new MyList();
            myList.Add(1);
            myList.Add(2);
            myList.Clear();
            myList.Print();

            //creating a list of strings
            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add("Mary");

            int count = 0;
            foreach (var name in names)
            {
                Console.WriteLine($"{name} ");
                count++;
            }
            Console.WriteLine($"count= {count}");
            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);
        }
        public static void CreateDeck(List<Card> deck)
        {
            string suit = "";
            for(int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;
                }
            }
            for(int face = 1; face < 14; face++)
            {
                deck.Add(new Card(face, suit));
            }
        }

    }



}


