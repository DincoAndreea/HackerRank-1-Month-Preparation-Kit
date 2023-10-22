namespace Dynamic_Array
{
    class Result
    {

        /*
         * Complete the 'dynamicArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         *  
         */

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            List<int> results = new List<int>();
            List<List<int>> array = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                array.Add(new List<int>());
            }

            int lastAnswer = 0;

            for (int i = 0; i < queries.Count; i++)
            {
                if (queries[i][0] == 1)
                {
                    int idx = (queries[i][1] ^ lastAnswer) % n;
                    array[idx].Add(queries[i][2]);
                }

                if (queries[i][0] == 2)
                {
                    int jdx = (queries[i][1] ^ lastAnswer) % n;
                    lastAnswer = array[jdx][queries[i][2] % array[jdx].Count];
                    results.Add(lastAnswer);
                }
            }

            Console.WriteLine(string.Join(", ", results));

            return results;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = Result.dynamicArray(n, queries);

            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}