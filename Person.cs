using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Kobra Nateghi
 * Description: this project demonstrates 
 * the use of objects and classes
 */
namespace COMP123_Lesson4
{
    public class Person
    {
        //private intance variables
        private string _name;
        private int _age;
        //public properties
        public string Name
        {
            get => this._name;
            set
            {
                // Console.WriteLine("name value set");
                this._name = value;
            }
        }
        /// <summary>
        /// this is a public property for our _age field
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// this is the default empty constructor for the Person
        /// class
        /// </summary>
        /// 
        // constructors===============================================


        public Person()
        {
            this._initialize();
        }


        public Person(string name)
        {
            this.Name = name;
        }

        public Person(int age)
        {
            this.Age = age;
        }
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        //===================================================================

        /// <summary>
        ///this method outputs the _name value with "says hello" 
        ///to the console
        ///@method _sayHello
        ///@return {void}
        /// </summary>
        /// private methods=====================================
       /*
        * <summary>
        * this method initializes the public Name and Age
        * <summary?
        */
        private void _initialize()
        {
            this.Name = "Unknown name";
            this.Age = 0;
        }

        //public methods========================================
        public void SayHello()
        {
            Console.WriteLine(this.Name + " says Hello");
        }


        /// <summary>
        /// this method outputs the name and the age 
        /// </summary>
        public void ShowAge()
        {
            Console.WriteLine($"{this.Name} is {this.Age} years old");
        }
    }
}


