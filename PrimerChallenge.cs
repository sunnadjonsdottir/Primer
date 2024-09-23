namespace Verkefni1
    class PrimerChallenge
    {
        static void Main()
        {
            // Get user input numbers
            List<int> userInputNumbers = GetUserNumbers();

            // Check if any numbers were entered
            if (userInputNumbers.Count > 0)
            {
                int largest = FindLargestNumber(userInputNumbers); // Find the largest number
                int smallest = FindSmallestNumber(userInputNumbers); // Find the smallest number

                DisplayResults(largest, smallest); // Display the results
            }
            else
            {
                Console.WriteLine("No numbers entered. Maybe next time!"); // Message if no numbers are entered
            }
        }

        // Get numbers from the user
        static List<int> GetUserNumbers()
        {
            List<int> numbers = new List<int>();
            string? input; // Nullable input to avoid null warnings

            Console.WriteLine("Enter numbers (press Enter without input to stop):");

            // Read input until user presses enter without entering a number
            while (true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) break; // Break if input is empty

                if (int.TryParse(input, out int number)) // Try to parse the input as an integer
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Oops! That's not a valid number, try again when you're ready.");
                }
            }
            return numbers; // Return the list of numbers entered by the user
        }

        // Find the largest number in the list
        static int FindLargestNumber(List<int> numbers)
        {
            int largest = numbers[0]; // Start with the first number

            // Loop through the list to find the largest number
            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            return largest; // Return the largest number
        }

        // Find the smallest number in the list
        static int FindSmallestNumber(List<int> numbers)
        {
            int smallest = numbers[0]; // Start with the first number

            // Loop through the list to find the smallest number
            foreach (int num in numbers)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            return smallest; // Return the smallest number
        }

        // Display the largest and smallest numbers
        static void DisplayResults(int largest, int smallest)
        {
            Console.WriteLine($"Largest number: {largest}"); // Display the largest number
            Console.WriteLine($"Smallest number: {smallest}"); // Display the smallest number
        }
    }
}
