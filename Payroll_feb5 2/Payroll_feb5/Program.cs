using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_feb5
{
    class Program
    {
   
        static void Main(string[] args)
        {

            List<Employee> aEmp = new List<Employee>();
            Employee e = null;

            Vehicle myV = null; 
            myV = new Vehicle();
            myV.Make = "BMW";
            myV.Model = "X6";

            FullTime ft1 = null;
            ft1 = new FullTime();
            ft1.Name = "Peter";
            ft1.Age = 20;
            ft1.Salary = 20000;
            ft1.Bonus = 2000;
            ft1._v = myV;

            aEmp.Add(ft1);


            myV = new Vehicle();
            myV.Make = "Honda";
            myV.Model = "Civic";

            PartTime pt1 = null;
            pt1 = new PartTime("Jennifer", 30, 3, 200, myV);
            aEmp.Add(pt1);


            myV = new Vehicle();
            myV.Make = "Ford";
            myV.Model = "Escape";
            PartTime pt2 = null;
            pt2 = new PartTime("Marco", 20, 8, 500, myV);
            aEmp.Add(pt2);


            //myV = new Vehicle();
            //myV.Make = "Fiat";
            //myV.Model = "Mini";
            Intern it1 = null;
            it1 = new Intern();
            it1.Name = "John";
            it1.Age = 24;
            it1.SchoolName = "Sheridan College";
            it1._v = null;

            aEmp.Add(it1);
            
            e = pt1;

            calculatePayroll(aEmp);
            
            
        }

        static void calculatePayroll(List<Employee> aEmp)
        {
            Double totalPR = 0.0;

            for (int i = 0; i < aEmp.Count; i++)
            {
                aEmp[i].printMyData();


                if (aEmp[i]._v != null) {
                    Console.WriteLine("Employee has a Vehicle");
                    Console.WriteLine(aEmp[i]._v.Make);
                    Console.WriteLine(aEmp[i]._v.Model);

                } else {
                    Console.WriteLine("Employee has no Vehicle");
                }

                Console.WriteLine("Birth Year: " + aEmp[i].calcBirthYear());
                var earn = aEmp[i].calcEarnings();
                Console.WriteLine("Eanings: " + earn);

                totalPR = totalPR + earn;
                Console.WriteLine("----------------");

            }
            Console.WriteLine("=================");
            Console.WriteLine("Total Payroll: " + totalPR);
            Console.ReadKey();
        }
    }

     
}
