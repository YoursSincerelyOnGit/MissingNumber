public class MissingNumberFinder
{
    // Finds and prints the first missing number in a sorted sequence starting from 1.
    // Assumes the input array contains consecutive numbers with exactly one missing.
    public void FindMissingNumber(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int expected = i + 1; // The value that should be at the current index
            if (numbers[i] != expected) // Check if the current number matches the expected value
            {
                Console.WriteLine("Missing number was " + expected); // Output the missing number
                return;
            }
        }
    }

    public static void Main()
    {

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 9, 10 };
        MissingNumberFinder finder = new MissingNumberFinder();
        finder.FindMissingNumber(numbers);
    }
}
