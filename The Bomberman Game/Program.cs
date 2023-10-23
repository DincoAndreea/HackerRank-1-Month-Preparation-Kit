namespace The_Bomberman_Game
{
    class Result
    {

        /*
         * Complete the 'bomberMan' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. STRING_ARRAY grid
         */

        public static List<string> bomberMan(int n, List<string> grid)
        {
            List<string> result = new List<string>();

            char[][] bombed = new char[grid.Count][];

            if (n == 1)
            {
                return grid;
            }

            if (n % 2 == 0)
            {
                for (int i = 0; i < grid.Count; i++)
                {
                    string res = "";
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        res += "O";
                    }
                    result.Add(res);
                }
            }

            for (int i = 0; i < grid.Count; i++)
            {
                bombed[i] = new char[grid[0].Length];
                for(int j = 0; j < grid[0].Length; j++)
                {
                    bombed[i][j] = 'O';
                }
            }

            for (int i = 0; i < grid.Count; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 'O')
                    {
                        bombed[i][j] = '.';

                        if (i + 1 < grid.Count)
                        {
                            bombed[i + 1][j] = '.';
                        }

                        if (i - 1 >= 0)
                        {
                            bombed[i - 1][j] = '.';
                        }

                        if (j + 1 < grid[0].Length)
                        {
                            bombed[i][j + 1] = '.';
                        }

                        if (j - 1 >= 0)
                        {
                            bombed[i][j - 1] = '.';
                        }
                    }
                }
            }

            List<string> bomb = new List<string>();

            for (int i = 0; i < grid.Count; i++)
            {
                bomb.Add(new string(bombed[i]));
            }

            if ((n - 3) % 4 == 0)
            {
                return bomb;
            }

            if ((n - 1) % 4 == 0)
            {
                char[][] bombed1 = new char[grid.Count][];

                for (int i = 0; i < grid.Count; i++)
                {
                    bombed1[i] = new char[grid[0].Length];
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        bombed1[i][j] = 'O';
                    }
                }

                for (int i = 0; i < grid.Count; i++)
                {
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        if (bombed[i][j] == 'O')
                        {
                            bombed1[i][j] = '.';

                            if (i + 1 < grid.Count)
                            {
                                bombed1[i + 1][j] = '.';
                            }

                            if (i - 1 >= 0)
                            {
                                bombed1[i - 1][j] = '.';
                            }

                            if (j + 1 < grid[0].Length)
                            {
                                bombed1[i][j + 1] = '.';
                            }

                            if (j - 1 >= 0)
                            {
                                bombed1[i][j - 1] = '.';
                            }
                        }
                    }
                }

                List<string> bomb1 = new List<string>();

                for (int i = 0; i < grid.Count; i++)
                {
                    bomb1.Add(new string(bombed1[i]));
                }

                return bomb1;
            }

            return result;

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int r = Convert.ToInt32(firstMultipleInput[0]);

            int c = Convert.ToInt32(firstMultipleInput[1]);

            int n = Convert.ToInt32(firstMultipleInput[2]);

            List<string> grid = new List<string>();

            for (int i = 0; i < r; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            List<string> result = Result.bomberMan(n, grid);

            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}