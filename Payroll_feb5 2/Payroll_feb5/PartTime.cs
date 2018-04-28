using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_feb5
{
    public class PartTime : Employee, IPrintable
    {
        private int _hWorked;
        private int _rate;
        public PartTime() : base()
        {
            // this.Name = "";
            // this.Age = 0;
            // base();
            this._hWorked = 0;
            this._rate = 0;

        }

        public PartTime(String ppName, int ppAge, int pHoursWorked, int pRate):base(ppName, ppAge)
        {
            this._hWorked = pHoursWorked;
            this._rate = pRate;
        }

        public PartTime(String ppName, int ppAge, int pHoursWorked, int pRate, Vehicle ppV) : base(ppName, ppAge, ppV)
        {
            this._hWorked = pHoursWorked;
            this._rate = pRate;
            
        }

        public override double calcEarnings()
        {
            return _hWorked * _rate;
        }

        public override void printMyData()
        {
            base.printMyData();
            Console.WriteLine("Hours Worked: " + _hWorked);
            Console.WriteLine("Rate: " + _rate);
        }
        public int HWorked
        {
            get
            {
                return _hWorked;
            }

            set
            {
                _hWorked = value;
            }
        }

        public int Rate
        {
            get
            {
                return _rate;
            }

            set
            {
                _rate = value;
            }
        }
    }
}
