/*
* Author: Lionel Villanueva
* Course COMP003A
* Purpose: Methods & XML Comments
*/


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Triangle");
            Console.WriteLine("Please enter a single character:");
            char inputChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a positive whole number:");
            int size = Convert.ToInt32(Console.ReadLine());
            IsoscelesTriangleBuilder(inputChar, size);
            PrintSeparator("Favorite Characters");
            CharacterInfo("Spider-Man", 1962);
            CharacterInfo("Batman", 1939);
            CharacterInfo("Superman", 1938);
            CharacterInfo("Iron Man", 1963);
            CharacterInfo("Wonder Woman", 1941);
        }
        static void PrintSeparator()
        {
            Console.WriteLine("**************************************************");
        }

        static void PrintSeparator(string label)
        {
            Console.WriteLine($"********** {label} **********");
        }

        /// <summary>
        /// Outputs an isosceles triangle made up of a single character to the console.
        /// </summary>
        /// <param name="inputCharacter">The character to use for the triangle</param>
        /// <param name="size">The height of the triangle</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }

            for (int i = size - 1; i >= 1; i--)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
        }

        /// <summary>
        /// Calculates the age based on a given birth year and the current year.
        /// </summary>
        /// <param name="year">The birth year</param>
        /// <returns>The age based on the current year and the given birth year</returns>
        static int AgeCalculator(int year)
        {
            return DateTime.Now.Year - year;
        }

        /// <summary>
        /// Outputs the name and calculated age of a character to the console.
        /// </summary>
        /// <param name="name">The name of the character</param>
        /// <param name="birthYear">The year the character was born or first appeared</param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} is {age} years old.");
        }
    }
}