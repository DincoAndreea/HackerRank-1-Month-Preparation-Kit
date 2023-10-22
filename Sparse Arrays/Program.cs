namespace Sparse_Arrays
{
    class Result
    {

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY strings
         *  2. STRING_ARRAY queries
         */

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>(new int[queries.Count]);

            for(int i = 0; i < queries.Count; i++)
            {
                foreach(string s in strings)
                {
                    if (s.Equals(queries[i]))
                    {
                        result[i]++;
                    }
                }
            }

            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = Result.matchingStrings(strings, queries);

            textWriter.WriteLine(String.Join("\n", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}