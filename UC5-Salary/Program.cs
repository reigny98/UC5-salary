using System;

namespace UC5_Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int perhoursalary = 20;
            int workinghour = 0;

            int day;
            int totalhour = 0;
            int empWage = 0;
            for (day = 1; day <= 20; day++)
            {
                Random random = new Random();
                int hours = random.Next(0, 3);

                switch (hours)
                { 

                    case 1:
                        workinghour = 8;
                        break;

                    case 2:
                        workinghour = 4;
                        break;

                    default:
                        workinghour = 0;
                        break;

                }
                totalhour = totalhour + workinghour;
            }
            empWage = totalhour * perhoursalary;
            
            Console.WriteLine("Emp Wages :" + empWage);


        }

    }
}


