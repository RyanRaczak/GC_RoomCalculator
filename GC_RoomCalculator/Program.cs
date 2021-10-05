using System;

namespace GC_RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars continue, length, width, height, paint, carpet, area, perimeter, volume, continue
            //Go in loop
            //Get Length Width and Height - accept decimals.
            //Calculate
            //display
            //ask for continue - validate

            double length, width, height, paint, carpet, area, perimeter, volume;

            Console.WriteLine("Welcome to the Room Calculator!\n  For all your detail needs.\n\n");

            bool userContinue = true;
            while (userContinue)
            {
                //Getting user input
                Console.Write("\nPlease enter the length: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("\nPlease enter the width: ");
                width = double.Parse(Console.ReadLine());
                Console.Write("\nPlease enter the height: ");
                height = double.Parse(Console.ReadLine());

                //Calculating

                area = length * width;

                perimeter = 2 * (length + width);

                volume = length * width * height;


                //Calculating Method 1
                carpet = area / 5;
                carpet = Math.Ceiling(carpet); //Can't order half a tile of carpet...i think.

                paint = perimeter / 5;
                paint = Math.Ceiling(paint); //Can't order a half can of paint.

                //Displaying data for Method 1
                Console.WriteLine($"\nMethod 1 Results\n\n" +
                    $"Area: {area}\nPerimeter: {perimeter}\nVolume: {volume}\nCarpet: {carpet}\nPaint: {paint}");

                //Calculating Method 2
                double longWallPaint = (length * height) * 2;
                double shortWallPaint = (width * height) * 2;
                double ceilingFloor = width * length;
                paint = (longWallPaint + shortWallPaint + ceilingFloor) / 25;
                paint = Math.Ceiling(paint);
                carpet = ceilingFloor / 5;
                carpet = Math.Ceiling(carpet);

                //Displaying data for Method 2
                Console.WriteLine($"\nMethod 2 Results\n\n" +
                    $"Area: {area}\nPerimeter: {perimeter}\nVolume: {volume}\nCarpet: {carpet}\nPaint: {paint}");

                //Getting user continue and checking for valid input
                bool valid = false;
                while (!valid)
                {
                    Console.WriteLine("\n\nWould you like to calculate another room? (y/n)");
                    string userC = Console.ReadLine().ToLower();

                    if (userC == "y")
                    {
                        valid = true;
                        userContinue = true;
                    }
                    else if (userC == "n")
                    {
                        valid = true;
                        userContinue = false;
                        Console.WriteLine("\n\nThanks for using Room Calculator!");
                    }
                    else
                    {
                        Console.WriteLine("\nNot a valid selection. Please enter 'y' for yes or 'n' for no.");
                    }
                }
            }
        }
    }
}
