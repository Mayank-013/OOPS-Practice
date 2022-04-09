using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    class Input
    {

        public Input()
        {
            Console.WriteLine("\n*** Input Constructor is called here. ***\n");
        }

        public int appropriateInput(int a)
        {
            string s = Console.ReadLine();
            while(!int.TryParse(s, out a))
            {
                Console.WriteLine("Please enter an 'integer' value.");
                s = Console.ReadLine();
            }
            return Convert.ToInt32(s);
        }
        public long appropriateInput(long a)
        {
            string s = Console.ReadLine();
            while (!long.TryParse(s, out a))
            {
                Console.WriteLine("Please enter a 'long' value.");
                s = Console.ReadLine();
            }
            return Convert.ToInt64(s);
        }
        public double appropriateInput(double a)
        {
            string s = Console.ReadLine();
            while (!double.TryParse(s, out a))
            {
                Console.WriteLine("Please enter a 'double' value.");
                s = Console.ReadLine();
            }
            return Convert.ToDouble(s);
        }
        public float appropriateInput(float a)
        {
            string s = Console.ReadLine();
            while (!float.TryParse(s, out a))
            {
                Console.WriteLine("Please enter a 'float' value.");
                s = Console.ReadLine();
            }
            return float.Parse(s);
        }
        public char appropriateInput(char a)
        {
            string s = Console.ReadLine();
            while (!char.TryParse(s, out a))
            {
                Console.WriteLine("Please enter a 'character' .");
                s = Console.ReadLine();
            }
            return Convert.ToChar(s);
        }
    }
}
