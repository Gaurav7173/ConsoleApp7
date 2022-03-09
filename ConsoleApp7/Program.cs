using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7.student;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // studentdata();
            // procress_data();

            //classes things
            //cat mew = new cat();
            //mew.name = "danger";
            //mew.display();
            //mew.get_name();

            //square sq = new square();
            //sq.cal_perimeter(sq.length,sq.sides);
            //sq.area();

            //rectangle rct = new rectangle();
            //rct.cal_perimeter(rct.length,rct.sides);
            //rct.area();

            level l = level.low;
            Console.WriteLine(l);

            int m = (int) months.april;
            Console.WriteLine("Number of month :"+m);
            Console.ReadLine();
        }

        private static void studentdata()
        {
            Students s1 = new Students(1, "gaurav", "bca"); 
            
            Console.WriteLine(s1.Name);
            List<Students> list_students = new List<Students> ()
            { 
                new Students (1,"Aman","bca"),
                new Students (2,"Rohit","btech"),
                new Students (3,"Ramesh","mba"),
                new Students (4,"Gaurav","bca"),
                new Students (5,"Saurabh","diploma")
            };
            list_students.Add(new Students(6,"abhay", "mba"));
            //foreach(var x in list_students)
            //{
            //    Console.WriteLine("ID of Student: " + x.ID+" Name of Student: " +x.Name+" Course of Students: "+x.course);
            //}
            display_students(s1);
            list_students.ForEach(x => display_students(x));
            
           // list_students.ForEach(x => Console.WriteLine("ID of Student: " + x.ID + " Name of Student: " + x.Name + " Course of Students: " + x.course));
        }
        private static void display_students(Students s)
        {
            Console.WriteLine("id " + s.ID + " name " + s.Name + " course " + s.course);
        }

        public static void procress_data()
        {
            //exception handling
            try
            {
                Students s = new Students();
                string ds = s.Show_details();
                Console.WriteLine(ds);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured "+ex.Message);
            }

        }

        //Enum class
        enum level
        {
            low,medium,high
        }

        enum months
        {
            jan=1,feb,march,april,may,june,july,august,september,oct,nov,dec
            
        }
    }

    //inheritance
    class animal
    {
        public string name;
        public void display()
        {
            Console.WriteLine("I am car");
        }
    }
    class cat:animal
    {
        public void get_name()
        {
            Console.WriteLine("name of animal is : " + name);
        }
    }

    class polygon
    {
        public void cal_perimeter(int length,int sides)
        {
            int result = length * sides;
            Console.WriteLine("Perimeter : " + result);
        }
    }
    class square:polygon
    {
        public int length = 100;
        public int sides = 4;
        public void area()
        {
            int area = length * length;
            Console.WriteLine("Area of Square : " + area);
        }
    }

    class rectangle : polygon
    {
        public int length = 200;
        public int sides = 4;
        public int breadth = 100;
        public void area()
        {
            int area = length * breadth;
            Console.WriteLine("Area of rectangle : " + area);
        }
    }

    
}
