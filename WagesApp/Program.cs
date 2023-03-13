using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagesApp
{
    class Program
    {
        //Global variables
        static string topEarner = "";
        static int topEarnerHours = -1;


        //Methods and/or functions

        static void CalculateWages(int totalHoursWorked, string employeeName)
        {
            //Display the total weekly hours stored
            Console.WriteLine($"Total hours worked : {totalHoursWorked}hrs");


            //Add 5 hours id sumHours = 30
            if (totalHoursWorked > 30)
            {
                totalHoursWorked += 5;

                //Display that 5 bonus hours have been added with the new total
                Console.WriteLine($"5 bonus hours added: {totalHoursWorked}hrs");
            }

            if (totalHoursWorked > topEarnerHours)
            {
                topEarnerHours = totalHoursWorked;
                topEarner = employeeName;

            }

            //Calculate the wage at a rate $22/hr

            int wages = totalHoursWorked * 22;

            float tax = 0.07f;


            //Calculate tax
            if (wages > 450)
            {
                tax = 0.08f;
            }

            //Calculate final pay

            float finalPay = wages - (float)Math.Round(wages * tax);

            //Display the results of the calculations followed by two blank lines
            Console.WriteLine($"Weekly pay: {wages}\n"+
                $"Tax rate: {tax}\n"+
                $"Tax: {Math.Round(wages + tax, 2)}\n"+
                $"Final pay: {finalPay}\n\n\n");
            Console.WriteLine("Press <ENTER> to add another employee or type 'XXX' then <ENTER> to quit");
        }

        static void OneEmployee()
        {
            List<string> weekDays = new List<string>()
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"
            };

            //Enter and store employee name
            Console.WriteLine("Enter the employee's name:\n");
            string employeeName = Console.ReadLine();
            Console.Clear();

            //Display employee name
            Console.WriteLine(employeeName);

            Random randGen = new Random();
            int sumHoursWorked = 0;

            //Loop 5 times
            for (int dayIndex = 0; dayIndex < 5; dayIndex++)
            {
                //Randomly generate the number of hours worked by a worker each day
                int hoursWorked = randGen.Next(2, 7);

                Console.WriteLine(hoursWorked);

                //Assign the name of the day of the week to a variable called day

                string day = weekDays[dayIndex];

                //store the total number of hours worked over five days
                sumHoursWorked += hoursWorked;

                //Display the name of the day and the number of hours generated for each worker
                Console.WriteLine($"\tHours worked on {day}: {hoursWorked}");

            }




            // Call the CalculateWages()
            CalculateWages(sumHoursWorked, employeeName);
        }


        //when run or main process
        static void Main(string[] args)
        {
            string flagMain = "";


            Console.WriteLine("\n" +
            @"                                             ___                  " + "\n" +
            @"/  \    /  \_____     ____   ____   ______ /  _  \ ______ ______   " + "\n" +
            @"\   \/\/   /\__  \   / ___\_/ __ \ /  ___//  /_\  \\____ \\____ \   " + "\n" +
            @" \        /  / __ \_/ /_/  >  ___/ \___ \/    |    \  |_> >  |_> >  " + "\n" +
            @"  \__/\  /  (____  /\___  / \___  >____  >____|__  /   __/|   __/   " + "\n" +
            @"       \/        \//_____/      \/     \/        \/|__|   |__|   " + "\n" + "\n");
            Console.WriteLine("<~----------------------------------------------------------------~>\n");

            Console.WriteLine(
                "Introduction:\n" +
                "Wages App will calculate wages for each employee and display the hours worked for the week.\n" +
                "It will produce an employee summary, showing the tax to be deducted and the total amount owed after tax\n" +
                "Lastly, Wages App display which employee worked the most hours for the week\n");
            Console.WriteLine("<~----------------------------------------------------------------~>\n");

            Console.WriteLine("Press enter to continue.....");
            Console.ReadLine();
            Console.Clear();


            while (!flagMain.Equals("XXX"))
            {
                Console.WriteLine("--------Employee Details--------");
                OneEmployee();


                flagMain = Console.ReadLine();

                Console.Clear();
                
            }
            
            Console.WriteLine($"{topEarner} has the most hours worked:{topEarnerHours}hrs");
            
            
        }
    }
}
