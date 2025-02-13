using System;

namespace radius_length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            length();
        }

        private static void length()
        {
            Console.WriteLine("Please choose square or circle:");
            string choose = Console.ReadLine().ToLower(); 

            if (choose == "circle")
            {
                Console.WriteLine("Enter radius (edge) length:");
                int radius = Convert.ToInt32(Console.ReadLine());
                double area_circle = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"The area of the circle is: {area_circle}");
            }
            else if (choose == "square")
            {
                Console.WriteLine("Enter edge length:");
                int edge_square = Convert.ToInt32(Console.ReadLine());
                int area_square = edge_square * edge_square;
                Console.WriteLine($"The area of the square is: {area_square}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose either 'circle' or 'square'.");
            }
        }
    }
}
