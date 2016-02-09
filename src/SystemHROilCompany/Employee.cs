using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemHROilCompany
{
    public class Employee
    {
        private int _salary;
        private int _transport;
        private int _travel;
        private int _internet;
        private int _medical;
        private int _religious;

        public string division;

        public int basicSalary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int transportAllowance
        {
            get { return _transport; }
            set { _transport = value; }
        }

        public int travelAllowance
        {
            get { return _travel; }
            set { _travel = value; }
        }

        public int internetAllowance
        {
            get { return _internet; }
            set { _internet = value; }
        }

        public int medicalAllowance
        {
            get { return _medical; }
            set { _medical = value; }
        }

        public int religiousAllowance
        {
            get { return _religious; }
            set { _religious = value; }
        }

        public virtual void Enter()
        {
            Console.WriteLine("Employee's start date in 09-February-2016");
        }

        public virtual void Training()
        {
            Console.WriteLine("Location : Bogor");
            Console.WriteLine("\n");
            Console.WriteLine("Cost : 215000");
        }

        public virtual void Assign()
        {
            Console.WriteLine("Status employee is permanent.");
        }

        public virtual void Layoff()
        {
            Console.WriteLine("Employee's layoff date from 29-February-2016");
        }

    }
}
