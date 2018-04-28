using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_feb5
{
    public class Vehicle : IPrintable
    {
        private String _make;
        private String _model;

        public Vehicle()
        {
            this._make = "";
            this._model = "";
        }

        public Vehicle (String pMake, String pModel)
        {
            _make = pMake;
            _model = pModel;
        }

        public string Model { get => _model; set => _model = value; }
        public string Make { get => _make; set => _make = value; }

        public void printMyData()
        {
            
            Console.WriteLine(this.Make);
            Console.WriteLine(this.Model);
        }
    }
}
