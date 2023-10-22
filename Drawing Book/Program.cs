namespace Drawing_Book
{
    class Result
    {

        /*
         * Complete the 'pageCount' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER p
         */

        public static int pageCount(int n, int p)
        {
            int res = 0;
            if (p <= n / 2)
            {
                res = p / 2;
            }
            else
            {
                if (n % 2 == 0)
                {
                    if (p % 2 == 0)
                    {
                        res = (n - p) / 2;
                    }
                    else
                    {
                        res = (n - p) / 2 + 1;
                    }
                }
                else
                {
                    res = (n - p) / 2;
                }
            }

            if (p == n)
            {
                res = 0;
            }

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

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.pageCount(n, p);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}