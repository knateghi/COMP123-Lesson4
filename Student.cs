using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson4
{
    class Student:Person 
    {
        //private instance variables=============================
        private string _studentID;
        //public properties=====================================
        public string StundentID { get=>this._studentID; set=>this._studentID=value; }
        /*
         * <summary>
         * this is the empty /default constructor for the Student
         * class and it extends the Person class
         * <summary>
         */
        public Student(string name,int age,string studentID)
            :base(name,age)
         {
            this.StundentID = studentID;
         }
        //public methods=================================================
        /// <summary>
        /// this method enables the study behaviour with the student
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name+" studies");
        }
    }
}
