namespace Subarray_Division_1
{
    class Result
    {

        /*
         * Complete the 'birthday' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY s
         *  2. INTEGER d
         *  3. INTEGER m
         */

        public static int birthday(List<int> s, int d, int m)
        {
            int res = 0;
            List<int> list = new List<int>();
            int sum = 0;

            list.Add(s.Take(m).Sum());
            for(int i = 1; i <= s.Count - m; i++)
            {
                sum = s.Skip(i).Take(m).Sum();
                list.Add(sum);
            }

            res = list.Where(x => x == d).Count();

            Console.WriteLine(res);

            return res;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.birthday(s, d, m);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}