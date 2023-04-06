using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1
{
    internal class taxi
    {

        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }


        public void TaxiInfo()
        {
            Console.WriteLine("DriverName : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            if (OnDuty == false)
            {
                Console.WriteLine("OnDunty : No");
            }
            Console.WriteLine("Number of passnger : {0}, NumPassenger");
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sudah selesai menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} sudah selesai mengantar penumpang", DriverName);
        }
    }
}
