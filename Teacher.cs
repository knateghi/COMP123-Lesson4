using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson4
{
    /*
     * the teacher class is derived from the Person class
     * @class Teacher
     * @extends Person
     */
    class Teacher : Person
    {
        //private instance variables==========================
        private string _employeeID;
        //public properties======================================
        public string EmployeeID { get => this._employeeID; set => this._employeeID = value; }

        //constructors==========================================
        
        public Teacher(string name, int age, string employeeID) : base(name, age)
        {
            this.EmployeeID = employeeID;
        }
       //public methods=============================================
       
        public void Teaches()
        {
            Console.WriteLine(this.Name+" teaches");
        }
    }
}