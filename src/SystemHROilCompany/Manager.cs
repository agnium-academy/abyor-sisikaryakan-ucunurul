using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemHROilCompany
{
    public class Manager : Employee
    {
        private string jobPosition;

        //public int managerID { get; set; }
        //public string managerName { get; set; }
        //public string managerDivision { get; set; }
        //public string managerLocation { get; set; }

        public Manager()
        {
            basicSalary = 5500000;
            transportAllowance = 350000;
            religiousAllowance = basicSalary;
            medicalAllowance = 6000000;
        }

        public Manager(string position)
        {
            this.jobPosition = position;
        }

        public override void Training()
        {
            Console.WriteLine("Location : Jakarta");
            Console.WriteLine("\n");
            Console.WriteLine("Cost : 2215000");
        }

        public void comparativeStudy()
        {
            Console.WriteLine("Employee's Comparative Study in Belgium. Next Month.");
        }

        //public static implicit operator Manager(string position)
        //{
        //    throw new NotImplementedException();
        //}
    }


}
