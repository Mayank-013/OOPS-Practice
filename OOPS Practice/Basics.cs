using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPS_Practice
{
    internal class Basics : Input
    {

        public int a { get; set; }      // read and write
        public long b { get; set; }     // read and write
        public float c { get; set; }    // read and write
        public double d { get; set; }   // read and write
        public char e { get; set; }     // read and write
        public string s { get; set; }   // read and write
        public bool Bl { get { return true; } }

        enum Days{ 
        Monday,
        Tuesday,
        Wednesday,
        Thursday = 10,
        Friday,
        Saturday,
        Sunday
        }

        static void Main(string[] args) {
            Console.WriteLine("Understanding the Basics of C#\n");

            
            Basics basics = new Basics();
            //Console.WriteLine("Bool value is: {0}", basics.Bl);

            Console.WriteLine("different variables taken are:\nint a; \nlong b; \nfloat c ; \ndouble d; \nchar e; \nstring s; ");
            Console.Write("\nPlease enter a value for int a : ");
            basics.a = basics.appropriateInput(basics.a);
            Console.Write("\nPlease enter a value for long b: ");
            basics.b = basics.appropriateInput(basics.b);
            Console.Write("\nPlease enter a value for float c: ");
            basics.c = basics.appropriateInput(basics.c);
            Console.Write("\nPlease enter a value for double d: ");
            basics.d = basics.appropriateInput(basics.d);
            Console.Write("\nPlease enter a value for char e: ");
            basics.e = basics.appropriateInput(basics.e);
            Console.Write("\nPlease enter a value for string s: ");
            basics.s = Console.ReadLine();



            

            basics.typeExample();
            basics.MathExample();
            basics.BreakExample();
            basics.EnumExample();
            basics.FileExample();

            Console.WriteLine("A read only bool value is declared.\n bool Bl = {0}",basics.Bl);



        }

        private void FileExample()
        {
            Basics basics = new Basics();
            Console.WriteLine("\n********** Files *************\n");
            File.Create("FileTest.txt");
            Console.WriteLine("Created a file named \"FileTest.txt\"");
            Console.WriteLine("File created on : {0}", File.GetCreationTime("FileTest.txt"));
            string txt = File.ReadAllText("FileTest.txt");
            Console.WriteLine("Content of files are: {0}", txt);

            Console.WriteLine("Writing the following text in the file:\n{0}", basics.s);
            File.WriteAllText("FileTest.text", basics.s);
            txt = File.ReadAllText("FileTest.txt");
            Console.WriteLine("Content of files are: {0}", txt);
        }

        private void EnumExample()
        {
            Console.WriteLine("\n********** Enum *************\n");

            Console.WriteLine("{0} : {1}", Days.Monday, (int)Days.Monday);
            Console.WriteLine("{0} : {1}", Days.Tuesday, (int)Days.Tuesday);
            Console.WriteLine("{0} : {1}", Days.Wednesday, (int)Days.Wednesday);
            Console.WriteLine("{0} : {1} \\\\ because we have given Thursday = 10", Days.Thursday, (int)Days.Thursday);
            Console.WriteLine("{0} : {1}", Days.Friday, (int)Days.Friday);
            Console.WriteLine("{0} : {1}", Days.Saturday, (int)Days.Saturday);
            Console.WriteLine("{0} : {1}", Days.Sunday, (int)Days.Sunday);
        }

        private void MathExample()
        {
            Basics basics = new Basics();
            Console.WriteLine("\n********** Math *************\n");
            Console.WriteLine("Max of {0} and {1} is {2}\n", basics.a, basics.d, Math.Max(basics.a, basics.d));
            Console.WriteLine("Min of {0} and {1} is {2}\n", basics.a, basics.d, Math.Min(basics.a, basics.d));
            Console.WriteLine("Round value of floating point number {0} is : {1}\n", basics.c, Math.Round(basics.c));
            Console.WriteLine("Cube of Long value {0} is: {1}\n", basics.b, Math.Pow(basics.b, 3));
            Console.WriteLine("Cube root of Long value {0} is: {1}\n", basics.b, Math.Cbrt(basics.b));
        }

        private void BreakExample()
        {
            Console.WriteLine("\n********** Break / Continue *************\n");
            Console.WriteLine("Print a series of whole numbers which skip even numbers and does'nt exceed 10:\n");
            for (int i = 1; ; i++)
            {
                if (i >= 10) { break; }
                if (i % 2 == 0) { continue; }
                Console.Write(i + "\t");
            }
        }

        private void typeExample()
        {
            Basics basics = new Basics();
            Console.WriteLine("********** Type Conversion *************\n");
            Console.WriteLine("--- Implicit type conversion ---\n");

            Console.WriteLine("Converting int 'a' to 'float'");
            try
            {
                float f = basics.a;
                Console.WriteLine("Converted value: {0}\n", f);
            }
            catch (Exception e) { Console.WriteLine(e); }

            Console.WriteLine("Converting int 'a' to 'char'");
            try
            {
                // char f1 = basics.a;
                Console.WriteLine("Cannot convert int to char implicitly as int is 4 bytes and char is only 2 bytes\n" +
                    "Thus implicit type conversion follows the rule: char -> int -> long -> float -> double\n");
            }
            catch (Exception e) { Console.WriteLine(e); }

            Console.WriteLine("\n--- Explicit type conversion ---\n");

            Console.WriteLine("Converting double 'd' to 'int'");
            try
            {
                int f1 = (int)basics.d;
                Console.WriteLine("Converted value: {0}\n", f1);
            }
            catch (Exception e) { Console.WriteLine(e); }

            Console.WriteLine("Converting double 'd' to 'char'");
            try
            {
                char f2 = (char)basics.d;
                Console.WriteLine("Converted value: {0}\n", f2);
            }
            catch (Exception e) { Console.WriteLine(e); }

            Console.WriteLine("Converting string 's' to 'int'");
            try
            {
                Console.WriteLine("Cannot convert string to char explicitly because we cannot perform type casting on strings, instead we can use Convert.To method\n" +
                    "Thus explicit type conversion follows the rule: char <- int <- long <- float <- double\n");
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
    }
}
