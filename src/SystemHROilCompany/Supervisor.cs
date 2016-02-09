using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemHROilCompany
{
    public class Supervisor : Employee
    {
        private string jobPosition;

        //public int supervisorID { get; set; }
        //public string supervisorName { get; set; }
        //public string supervisorDivision { get; set; }
        //public string supervisorLocation { get; set; }

        public Supervisor()
        {
            basicSalary = 4500000;
            transportAllowance = 250000;
            travelAllowance = 400000;
            internetAllowance = 150000;
        }

        public Supervisor(string position)
        {
            this.jobPosition = position;
        }

        public override void Enter()
        {
            Console.WriteLine("This supervisor enter in 01-February-2016.");
        }

        //public static implicit operator Supervisor(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
