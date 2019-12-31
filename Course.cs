using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson4
{
    class Course
    {
        //private instance variables===========================
        private string _code;
        private string _description;

        //public properties
        public string Code { get; set; }
        public string Description { get; set; }

        //public constructors=====================================

        /// <summary>
        ///this constructor takes two parameters
        ///Code and Description
        /// </summary>
        public Course(string code,string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
