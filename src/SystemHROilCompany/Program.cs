using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemHROilCompany
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Manager tegar = new Manager();
            //tegar = "Manager Drilling";

            //Supervisor iqbal = new Supervisor();
            //iqbal = "Supervisor Drilling Riau";

            //Staff dwi = new Staff();
            //dwi = "Staff Drilling Riau 1";

            Manager tegar = new Manager("Manager Drilling");
            Manager haidar = new Manager("Manager Drilling");
            Manager sani = new Manager("Manager Refinery");
            Manager adi = new Manager("Manager General Affairs");

            Supervisor iqbal = new Supervisor("Supervisor Drilling Riau");
            Supervisor ucu = new Supervisor("Supervisor Drilling Luwuk");
            Supervisor deni = new Supervisor("Supervisor Refinery Balikpapan");

            Staff dwi = new Staff("Staff Drilling Riau 1");
            Staff trio = new Staff("Straff Drilling Riau 2");
            Staff nuragus = new Staff("Staff Drilling Luwuk");
            Staff sofi = new Staff("Staff Refinery Balikpapan");
            Staff seta = new Staff("Staff General Affairs");

        }
    }
}
