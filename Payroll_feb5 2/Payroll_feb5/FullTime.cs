using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_feb5
{
    public class FullTime : Employee, IPrintable
    {
        
        private int _salary;
        private int _bonus;

        // methods
        public FullTime() : base()
        {
            // this.Name = "";
            // this.Age = 0;
            // base();
            this._salary = 0;
            this._bonus = 0;

        }

        public FullTime(String ppName, int ppAge, int pSalary, int pBonus):base(ppName, ppAge)
        {
            this._salary = pSalary;
            this._bonus = pBonus;
        }

        public override double calcEarnings()
        {
            return _salary + _bonus;
        }

        public override void printMyData()
        {
            base.printMyData();
            Console.WriteLine("Salary: " + _salary);
            Console.WriteLine("Bonus: " + _bonus);
        }


        public int Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                _salary = value;
            }
        }

        public int Bonus
        {
            get
            {
                return _bonus;
            }

            set
            {
                _bonus = value;
            }
        }

        
    }
}
