using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinderbijslag
{
    class Program
    {
        static void Main(string[] args)
        {
            // parameters
            DateTime Cdate;
            DateTime Kdate;
            bool kid = true;
            int countKids12 = 0;
            int countKids18 = 0;
            int totalKids;
            double percentage;
            double age;

            // enter kids
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the current date:");
                    Cdate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid: Please try again...");
                }
            }
            while (kid == true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Please enter the birthdate of your child");
                        Kdate = Convert.ToDateTime(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid: Please try again...");
                    }
                }
                age = (Cdate - Kdate).TotalDays;
                int ag = Convert.ToInt32(age/365);
                Console.WriteLine("Your kid is this old: " + (ag) + " years");
                if (age < 0)
                {
                    Console.WriteLine("Not possible to calculate the age");
                }
                else if (age < 4385)
                {
                    Console.WriteLine("Your kid is younger than 12 years");
                    countKids12++;
                }
                else if(age < 6578)
                {
                    Console.WriteLine("Your kid is too old");
                    countKids18++;
                }
                else
                {
                    Console.WriteLine("Not possible to calculate the age");
                }
                Console.WriteLine("Would you like to register another kid?");
                if (Console.ReadLine() == "no")
                {
                    kid = false;
                }
            }

            // math
            totalKids = countKids12 + countKids18;
            int cK12 = countKids12 * 150;
            int cK18 = countKids18 * 235;
            if (totalKids == 3 || totalKids == 4)
            {
                percentage = 2;
            }
            else if (totalKids == 5)
            {
                percentage = 3;
            }
            else if (totalKids >= 6)
            {
                percentage = 3.5;
            }
            else
            {
                percentage = 0;
            }
            double cost = cK12 + cK18;
            double totalCost = cost + (cost / 100 * percentage);

            // endresult
            Console.WriteLine("The total without extra is: " + cost);
            Console.WriteLine("The total cost is: " + totalCost);
        }
    }
}
