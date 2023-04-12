using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy.Model
{
    class MainModel
    {

        private EmployeeBuilder employeeTmp;
        public EmployeeBuilder EmployeeTmp
        {
            get => employeeTmp;
            set { employeeTmp = value; }
        }

        private decimal? firstArg = null;
        private decimal? secondArg = null;


        public decimal? FirstArg
        {
            get => firstArg;
            set { firstArg = value; }
        }
        public decimal? SecondArg
        {
            get => secondArg;
            set { secondArg = value; }
        }

        public decimal Result { get; set; }

        public MainModel()
        {
            employeeTmp = new EmployeeBuilder();
        }

    }
}
