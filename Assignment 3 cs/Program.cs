using System;

namespace Assignment_3_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
  //هنا انا جربت بعد كل مسأله مشتغلتش call لازم نعملهم 
            ReverseString();
           
            ReverseInteger();
          
            FindPrimesInRange();
          
            ConvertDecimalToBinary();

            CheckCollinearPoints();
           
            WorkerEfficiencyEvaluation();
        }

        

        #region 13. Reverse a String
        static void ReverseString()
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Input cannot be empty or whitespace.");
                return;
            }

            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reversed string: " + new string(charArray));
        }
        #endregion

        //----------------------------------------------------------------------------------------------------------------------------------------------

        #region 14. Reverse an Integer
        static void ReverseInteger()
        {
            Console.Write("Enter an integer: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            int reversed = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            Console.WriteLine("Reversed integer: " + reversed);
        }
        #endregion

        //-----------------------------------------------------------------------------------------------------------------

        #region 15. Find Prime Numbers Within a Range
        static void FindPrimesInRange()
        {
            Console.Write("Input starting number of range: ");
            if (!int.TryParse(Console.ReadLine(), out int start))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }
            Console.Write("Input ending number of range: ");
            if (!int.TryParse(Console.ReadLine(), out int end))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            if (start > end)
            {
                Console.WriteLine("Starting number cannot be greater than ending number.");
                return;
            }

            Console.WriteLine($"The prime numbers between {start} and {end} are:");
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

        //-------------------------------------------------------------------------------------------------------------------------

        #region 16. Convert Decimal to Binary
        static void ConvertDecimalToBinary()
        {
            Console.Write("Enter a number to convert: ");
            if (!int.TryParse(Console.ReadLine(), out int num) || num < 0)
            {
                Console.WriteLine("Please enter a non-negative integer.");
                return;
            }

            string binary = "";
            while (num > 0)
            {
                binary = (num % 2) + binary;
                num /= 2;
            }

            Console.WriteLine($"The Binary representation is: {binary}");
        }
        #endregion

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------

        #region 17. Check if Three Points Are Collinear
        
        static void CheckCollinearPoints()
        {
            try
            {
                Console.WriteLine("Enter coordinates of three points:");
                Console.Write("x1, y1: ");
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                Console.Write("x2, y2: ");
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());
                Console.Write("x3, y3: ");
                double x3 = double.Parse(Console.ReadLine());
                double y3 = double.Parse(Console.ReadLine());

                // عشان مكنتش اعرف القانون ده chatgpt بعد البحث و التدوير عن قانون الاستقامه ووللامانه استعانت ب 
                if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
                    Console.WriteLine("The points are collinear.");
                else
                    Console.WriteLine("The points are not collinear.");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter numerical values.");
            }
        }
        #endregion

        //--------------------------------------------------------------------------------------------------------------

        #region 18. Worker Efficiency Evaluation
        static void WorkerEfficiencyEvaluation()
        {
            Console.Write("Enter the time taken to complete the task (in hours): ");
            if (!double.TryParse(Console.ReadLine(), out double hours) || hours < 0)
            {
                Console.WriteLine("Invalid input. Time cannot be negative.");
                return;
            }

            if (hours >= 2 && hours < 3)
                Console.WriteLine("Highly efficient.");
            else if (hours >= 3 && hours < 4)
                Console.WriteLine("Increase your speed.");
            else if (hours >= 4 && hours <= 5)
                Console.WriteLine("Training is required to enhance your speed.");
            else if (hours > 5)
                Console.WriteLine("You need to leave the company.");
            else
                Console.WriteLine("Invalid input.");
        }
        #endregion

        //---------------------------------------------------------------------------------------------------------------------------------------------
    }
}
