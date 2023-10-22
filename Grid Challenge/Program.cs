namespace Grid_Challenge
{
    class Result
    {

        /*
         * Complete the 'gridChallenge' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING_ARRAY grid as parameter.
         */

        public static string gridChallenge(List<string> grid)
        {
            List<List<char>> matrix = new List<List<char>>();

            string result = "";

            for (int i = 0; i < grid.Count; i++)
            {
                matrix.Add(grid[i].ToCharArray().ToList());
                matrix[i].Sort();
                Console.WriteLine(string.Join(" ", matrix[i]));
            }

            int count = 0;

            for (int i = 0; i < matrix[0].Count; i++)
            {
                for (int j = 0; j < grid.Count - 1; j++)
                {
                    if (matrix[j][i].CompareTo(matrix[j + 1][i]) <= 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

            if (count == (grid.Count - 1) * matrix[0].Count)
            {
                result = "YES";
            }
            else
            {
                result = "NO";
            }

            Console.WriteLine(result);

            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<string> grid = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    string gridItem = Console.ReadLine();
                    grid.Add(gridItem);
                }

                string result = Result.gridChallenge(grid);

                //textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}