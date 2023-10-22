namespace Lonely_Integer
{
    class Result
    {

        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int lonelyinteger(List<int> a)
        {
            var res = 0;
            if(a.Count >= 1 && a.Count <= 100 && a.Min() >= 0 && a.Max() <= 100) 
            {
                var dict = a.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                res = dict.Where(x => x.Value == 1).Select(x => x.Key).First();
            }

            return res;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.lonelyinteger(a);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}