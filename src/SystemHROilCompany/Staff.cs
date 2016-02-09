using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemHROilCompany
{
    public class Staff : Employee
    {
        private string jobPosition;

        //public int staffID { get; set; }
        //public string staffName { get; set; }
        //public string staffDivision { get; set; }
        //public string staffLocation { get; set; }

        public Staff()
        {
            basicSalary = 2500000;
            transportAllowance = 150000;
        }

        public Staff(string position)
        {
            this.jobPosition = position;
        }

        public override void Assign()
        {
            Console.WriteLine("Status this staff is permanent.");
        }

        //public static implicit operator Staff(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
