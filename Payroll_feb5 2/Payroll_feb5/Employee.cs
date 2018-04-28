using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_feb5
{
    public abstract class  Employee : IPrintable
    {
        private String _name;
        private int _age;
        public Vehicle _v;


        public Employee()
        {
            _name = "";
            _age = 0;
            _v = null;
        }

        public Employee(String pName, int pAge)
        {
            this._name = pName;
            this._age = pAge;
            this._v = null;
        }

        public Employee(String pName, int pAge, Vehicle pV)
        {
            this._name = pName;
            this._age = pAge;
            this._v = pV;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value >= 0) {
                    _age = value;
                } else
                {
                    _age = 0;
                }
                
            }
        }

        public int calcBirthYear()
        {
            return (2018 - this._age);
        }

        public abstract double calcEarnings();
       

        public virtual void printMyData()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Age: " + _age);
            // ternary operator for if then else

            if (this._v != null) {
                this._v.printMyData();
            } else {
                Console.WriteLine("EMployee has no registered Vehicle");
            }
            
        }
    }
}
