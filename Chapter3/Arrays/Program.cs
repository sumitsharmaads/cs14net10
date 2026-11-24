internal class Program
{
    private static void Main(string[] args)
    {
        string[] names;
        names = new string[4];
        names[0] = "John";
        names[1] = "Jane";
        names[2] = "Jack";
        names[3] = "Jill";

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"The name is: {names[i]} is at position {i}");
        }
        ;

        string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" };

        //Two diemntional arry
        string[,] grid1 =
        {
    {"John", "Jane", "Jack", "Jill"},
    {"Kate", "Jack", "Rebecca", "Tom" }
};
        Console.WriteLine(grid1.GetUpperBound(1)); //Returns the number of rows

        for (int row = 0; row <= grid1.GetUpperBound(0); row++)
        {
            for (int col = 0; col <= grid1.GetUpperBound(1); col++)
            {
                Console.WriteLine($"The value at position ({row}, {col}) is: {grid1[row, col]}");
            }
        }

        // Alternative syntax for declaring and allocating memory
        // for a multi-dimensional array.
        /**  * The following statement allocates memory for a 3x4 array of strings.
         *  means the array can have 3 items in its first dimension (0) with an upper bound of 
           2, and the array can have 4 items in its second dimension (1) with an upper bound of 3
         */
        string[,] grid2 = new string[3, 4]; // Allocate memory.

        #region jagged array (multi-dimensional array)
        string[][] jagged =
        {
            new[] {"Alpha", "Beta", "Gamma"},
            new[] {"Delta", "Epsilon"},
            new[] {"Sugar"}
        };

        //with after c#12 we can write it like this way too
        string[][] jagged2 =
        [
            ["Alpha", "Beta", "Gamma"],
            ["Delta", "Epsilon"],
            ["Sugar"]
        ];
        Console.WriteLine(jagged.GetUpperBound(0)); //Returns the number of rows
        for(int row=0; row<=jagged2.GetUpperBound(0); row++)
        {
            for (int col=0; col <= jagged2[row].GetUpperBound(0); col++)
            {
                Console.WriteLine($"The value at position ({row}, {col}) is: {jagged2[row][col]}");
            }
        }

        for (int row = 0; row < jagged2.Length; row++)
        {
            for (int col = 0; col < jagged2[row].Length; col++)
            {
                Console.WriteLine($"jagged2[row][col] {jagged2[row][col]}");
            }
        }
        #endregion

        #region 
        int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] oneTwoNumbers = { 1, 2 };
        int[] oneTwoTenNumbers = { 1, 2, 10 };
        int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
        int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
        int[] emptyNumbers = { }; // Or use Array.Empty<int>()
        int[] threeNumbers = { 9, 7, 5 };
        int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };
        Console.WriteLine($"{nameof(sequentialNumbers)}: { CheckSwitch(sequentialNumbers)}");
        Console.WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
        Console.WriteLine($"{nameof(oneTwoTenNumbers)}: { CheckSwitch(oneTwoTenNumbers)}");
        Console.WriteLine($"{nameof(oneTwoThreeTenNumbers)}: { CheckSwitch(oneTwoThreeTenNumbers)}");
        Console.WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}"); 
        Console.WriteLine($"{nameof(fibonacciNumbers)}: { CheckSwitch(fibonacciNumbers)}");
        Console.WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
        Console.WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
        Console.WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");
        static string CheckSwitch(int[] values) => values switch
        {
            [] => "Empty array",
            [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
            [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
            [1, 2] => "Contains 1 then 2.",
            [int item1, int item2, int item3] =>
            $"Contains {item1} then {item2} then {item3}.",
            [0, _] => "Starts with 0, then one other number.",
            [0, ..] => "Starts with 0, then any range of numbers.",
            [2, .. int[] others] => $"Starts with 2, then {others.Length} more  numbers.",
            [..] => "Any items in any order.",

        };
         
        #endregion
    }
}