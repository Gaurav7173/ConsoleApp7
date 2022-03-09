using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.student
{

    class Students
    {
      
        public Students()
        {

        }
        public Students(int id,string name,string Course)
        {
            Name = name;
            ID = id;
            course = Course;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string course { get; set; }

        public string Show_details()
        {
            return "Id of students " + ID +  " course of student " + course + " name of students " + Name.Substring(1);
        }
    }
}
