namespace TesttingApplications
{
    public class Program
    {
        static void ReverseArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                // Swap arr[left] and arr[right]
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                // Move the pointers
                left++;
                right--;
            }
        }

        static void Main(string[] args)
        {
            // Read the number of elements
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            // Initialize the array
            int[] arr = new int[n];

            // Read array elements
            Console.WriteLine("Enter the elements separated by space:");
            string[] inputs = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            // Display original array
            Console.WriteLine("Original Array: " + string.Join(", ", arr));

            // Reverse the array
            ReverseArray(arr);

            // Display reversed array
            Console.WriteLine("Reversed Array: " + string.Join(", ", arr));

            /* Please uncomment below code if you want to reverse string like Hello -> olleH

            // Read input string
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Convert string to character array for in-place modification
            char[] charArray = input.ToCharArray();

            // Reverse characters in place
            ReverseCharacters(charArray);

            // Convert back to string and print
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed String: " + reversedString); 
            */


        }
    }
}