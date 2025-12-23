using System;

namespace Day2
{
    /// <summary>
    /// This class implements a deep-nested loop search that uses goto to exit all levels instantly.
    /// Searches for a specific target value in a 3D array structure.
    /// Demonstrates goto usage for breaking out of deeply nested loops efficiently.
    /// </summary>
    public class SearchWithGoto
    {
        #region Functionality
        public static void Search()
        {
            #region Declarations
            int[,,] data;
            int target, depth, rows, cols;
            bool found;
            #endregion

            #region Code Functionality
            // Initialize 3D array with sample data
            depth = 3;
            rows = 4;
            cols = 5;
            data = new int[depth, rows, cols];

            // Fill array with sequential numbers
            int value = 1;
            for (int d = 0; d < depth; d++)
            {
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        data[d, r, c] = value++;
                    }
                }
            }

            Console.WriteLine($"Searching in a 3D array [{depth} x {rows} x {cols}]");
            Console.WriteLine($"Array contains values from 1 to {depth * rows * cols}\n");

            Console.Write("Enter a number to search: ");
            if (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            found = false;
            Console.WriteLine($"\nSearching for {target}...\n");

            // Nested loop search with goto for instant exit
            for (int d = 0; d < depth; d++)
            {
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        Console.WriteLine($"Checking position [{d},{r},{c}] = {data[d, r, c]}");

                        if (data[d, r, c] == target)
                        {
                            Console.WriteLine($"\n✓ Found {target} at position: Depth={d}, Row={r}, Column={c}");
                            found = true;
                            goto SearchComplete;
                        }
                    }
                }
            }

            SearchComplete:
            if (!found)
            {
                Console.WriteLine($"\n✗ {target} not found in the array.");
            }
            else
            {
                Console.WriteLine("Search terminated immediately using goto statement.");
            }
            #endregion
        }
        #endregion
    }
}
