using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject_pt4
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Passing by value
            double x = 5;
            double y = 4;
            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));
            Console.WriteLine();
            Console.WriteLine("x {0}", x);
            Console.WriteLine("y {0}", y);

            Console.WriteLine();
            Console.WriteLine();


            //      Out parameter
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("Double it up!: 15 * 2 = {0}", solution);

            Console.WriteLine();
            Console.WriteLine();


            //      Pass by reference
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Before Swap num1 is {0} and num2 is {1}", num1, num2);

            Swap(ref num1, ref num2);
            Console.WriteLine("After Swap num1 is {0} and num2 is {1}", num1, num2);

            Console.WriteLine();
            Console.WriteLine();


            //      Parameters
            Console.WriteLine("1 + 2 + 3 = {0}", GetSumMore(1, 2, 3));
            Console.WriteLine();


            //      Named parameters
            PrintInfo(zipCode: 12123, name: "Stig McDuck");
            Console.WriteLine();


            //      Method Overloading
            Console.WriteLine("5,0 + 4,5 = {0}", GetSumThing(5.0, 4.5));
            Console.WriteLine("21,4 + 8,6 = {0}", GetSumThing(21.4, 8.6));
            Console.WriteLine("3 + 8 = {0}", GetSumThing(3, 8));
            Console.WriteLine();


            //      Enum
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);



            Console.ReadLine();
        }


        //      Passing by value
        static double GetSum(double x = 1, double y = 1) {
            double temp = x;
            x=y;
            y=temp;

            return x+y;
        }

        //      Out parameter
        static void DoubleIt(int x, out int solution) {
            solution=x*2;
        }

        //      Pass by reference
        public static void Swap(ref int num1, ref int num2) {
            int temp = num1;
            num1=num2;
            num2=temp;
        }

        //      Parameters
        static double GetSumMore(params double[] nums) {
            double sum = 0;
            foreach (int i in nums) {
                sum+=i;     // sum = sum + i
            }
            return sum;
        }


        //      Named parameters
        static void PrintInfo(string name, int zipCode) {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }


        //      Method Overloading
        static double GetSumThing(double x = 1, double y = 1) {
            return x+y;
        }

        static double GetSumThing(string x = "1", string y = "1") {
            double dblx = Convert.ToDouble(x);
            double dbly = Convert.ToDouble(y);
            return dblx+dbly;
        }


        //      Enum
        enum CarColor: byte {
            Black = 1,
            White, // 2
            Green, // 3
            Blue,  // 4
            Red    // 5
        }

        static void PaintCar(CarColor cc) {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }
    }
}
