using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static inhertance.Circle;
using static inhertance.Employee;

namespace inhertance
{
    internal class Program
    {
       
        static void Main(string[] args)
        {


            Employee e1 = new Employee("darshan", 23000);
            e1.Calculatesalary();
            Console.WriteLine(e1);

            Manager m1 = new Manager("vishal", 24000, 3000);
            m1.Calculatesalary();
            Console.WriteLine(m1);

            President p1 = new President("rahul", 300000, 5000, 5000, 40000);
            p1.Calculatesalary();
            Console.WriteLine(p1);

            Sales s1 = new Sales("tejan", 40000, 2000, 3000, 45000, 5999);
            s1.Calculatesalary();
            Console.WriteLine(s1);
            Console.WriteLine("\n\n");



            Add a1 = new Add();
            Console.WriteLine(a1.Cal(1, 3));
            Console.WriteLine(a1.Cal(2, 3, 3));
            Console.WriteLine(a1.Cal(1.2, 1));
            Console.WriteLine("\n\n");


            Circle c1 = new Circle(5);
            c1.CalculateArea();
            Console.WriteLine(c1);

            Rectangal r1 = new Rectangal(2, 3);
            r1.CalculateArea();
            Console.WriteLine(r1);

            Rectangal r2 = new Rectangal(8.6, 5.4);
            r2.CalculateArea();
            Console.WriteLine(r2);





        }
    }
}
