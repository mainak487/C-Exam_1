//1

using System;
 
public class InheritanceObjects
{
    public static void Main(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];
 
        for (int i = 0; i < total; i++)
        {
            if (i == 0)
            {
                persons[i] = new Teacher(Console.ReadLine());
            }
            else
            {
                persons[i] = new Student(Console.ReadLine());
            }
        }
 
        for (int i = 0; i < total; i++)
        {
            if (i == 0)
            {
               ((Teacher)persons[i]).Explain();
 
            }
            else
            {
                ((Student)persons[i]).Study();
            }
        }
    }
 
    public class Person
    {
        protected string Name { get; set; }
 
        public Person(string name)
        {
            Name = name;
        }
 
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
 
        ~Person()
        {
            Name = string.Empty;
        }
    }
 
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
 
        public void Explain()
        {
            Console.WriteLine("Explain");
        }
    }
 
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }
 
        public void Study()
        {
            Console.WriteLine("Study");
        }
    }
}


// 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop1
{
    class Student2
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;

        private static double servicetax = 12.3;

        public Student2(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }

        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        public int TotalFee
        {
            get
            {
                double total = course == "c#" ? 2000 : 3000;
                // service tax
                total = total + total * servicetax / 100;
                return (int) total;
            } 
        }

        public static double  ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }
    } // Student2

    class UseStudent2
    {

        public static void Main()
        {

            Student2 s = new Student2(1, "ABC", "asp.net");
            s.Payment(1000);
            s.Print();
            Console.WriteLine(s.DueAmount);


        }
    }
}


//3

using System;
namespace Vehicles
{
    class Car : Vehicle
    {
 
    }
}
 
using System;
namespace Vehicles
{
    class ExcursionVan : Van
    {
    }
}
  
using System;
namespace Vehicles
{
    class Minivan : Van
    {
        protected bool cargo_Net;
        protected bool dual_Sliding_Doors;
 
        public Minivan()
        {
        }
        public Minivan(bool cargo_Net, bool dual_Sliding_Doors)
        {
            this.cargo_Net = cargo_Net;
            this.dual_Sliding_Doors = dual_Sliding_Doors;
        }
 
        public void SetCargoNet(bool cargo_Net)
        {
            this.cargo_Net = cargo_Net;
        }
        public void SetDualSlidingDoors(bool dual_Sliding_Doors)
        {
            this.dual_Sliding_Doors = dual_Sliding_Doors;
        }
 
        public bool HasCargoNet()
        {
            return cargo_Net;
        }
        public bool HasDualSlidingDoors()
        {
            return dual_Sliding_Doors;
        }
    }
}
  
using System;
namespace Vehicles
{
    class Sportscar : Car
    {
 
    }
}
  
using System;
namespace Vehicles
{
    class TestVehicles
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Drive();
 
            Sportscar mySportsCar = new Sportscar();
            mySportsCar.Drive();
 
            Van myVan = new Van();
            myVan.Drive();
 
            Minivan myMiniVan = new Minivan();
            myMiniVan.Drive();
 
            ExcursionVan myExcursionVan = new ExcursionVan();
            myExcursionVan.Drive();
        }
    }
}
  
using System;
namespace Vehicles
{
    class Van : Vehicle
    {
 
    }
}
  
using System;
namespace Vehicles
{
    class Vehicle
    {
        protected string make;
        protected string model;
        protected string year;
 
        public Vehicle()
        {
        }
        public Vehicle(string make, string model, string year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
 
        public string Make
        {
            set { make = value; }
            get { return make; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public string Year
        {
            set { year = value; }
            get { return year; }
        }
 
        public void Accelerate()
        {
        }
        public void Decelerate()
        {
        }
        public void Drive()
        {
        }
        public void Start()
        {
        }
        public void Stop()
        {
        }
    }
}
