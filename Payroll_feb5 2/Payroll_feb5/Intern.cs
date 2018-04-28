using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_feb5
{
    public class Intern : Employee, IPrintable
    {
        private String _schoolName;

        public string SchoolName { get => _schoolName; set => _schoolName = value; }

        public override double calcEarnings()
        {
            return 2000;
        }

        public override void printMyData()
        {
            base.printMyData();
            Console.WriteLine("School Name: " + _schoolName);
           
        }


    }
}
