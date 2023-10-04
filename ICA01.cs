//Name: Simbarashe Kandemiri
//Course:Cmpe1300
//Activity ICA01
//September 19, 2023

using System;

namespace ICA1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Display the title
            Console.WriteLine("            ICA01 - Simbarashe Kandemiri");
            Console.WriteLine("\n");

            // Input the number of cans
            Console.Write("Enter the number of cans: ");
            int numberOfCans = int.Parse(Console.ReadLine());

            // Input the cost per can
            Console.Write("Enter the cost per can: ");
            double costPerCan = double.Parse(Console.ReadLine());

            // Calculate the total cost before GST
            double totalCostBeforeGST = numberOfCans * costPerCan;

            // Calculate GST (5%)
            double gstAmount = totalCostBeforeGST * 0.05;

            // Calculate the total cost including GST
            double totalCostWithGST = totalCostBeforeGST + gstAmount;

            // Display the results
            Console.WriteLine("\nCost Breakdown:");
            Console.WriteLine("================");
            Console.WriteLine($"Number of Cans: {numberOfCans}");
            Console.WriteLine($"Cost per Can: ${costPerCan:F2}");
            Console.WriteLine($"Total Cost before GST: ${totalCostBeforeGST:F2}");
            Console.WriteLine($"GST (5%): ${gstAmount:F2}");
            Console.WriteLine($"Total Cost with GST: ${totalCostWithGST:F2}");

            Console.ReadLine(); // Pause to view the result
        }
    }
}
