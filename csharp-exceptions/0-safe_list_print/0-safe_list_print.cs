public static class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            // Check if the list is null
            if (myList == null)
            {
                throw new ArgumentNullException(nameof(myList), "List cannot be null");
            }

            // Check if the list is empty
            if (myList.Count == 0)
            {
                Console.WriteLine("The list is empty");
                return count;
            }

            // Check if n is less than 0
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "n cannot be less than 0");
            }

            // Use Math.Min to ensure we don't go out of bounds
            int elementsToPrint = Math.Min(n, myList.Count);

            for (int i = 0; i < elementsToPrint; i++)
            {
                Console.Write(myList[i] + " ");
                count++;
            }
            Console.WriteLine(); // Add a newline after printing
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        return count;
    }
}
