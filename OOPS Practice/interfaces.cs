using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    interface I1
    {
        string Name { get; set; }
        string USN { get; set; }
        void college();
    }
    interface I2
    {
        public string className { get; set; }
        void timings();
    }
    class interfaces : I1 , I2
    {
        public string Name { get; set; }
        public string USN { get; set; }
        public string className { get; set; }

        public void college()
        {
            Console.WriteLine("{0} with usn {1} studies in AIT",Name,USN);
        }
        public void timings()
        {
            Console.WriteLine("Timings for the class {0} is : 8 AM - 8 PM",className);
        }
        static void Main()
        {
            interfaces i = new interfaces();
            i.Name = "Mayank";
            i.USN = "1ay18cs068";
            i.className = "OOPS Concepts";
            i.college();
            i.timings();


        }

        
    }
}
