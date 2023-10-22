namespace Sum_vs_XOR
{
    class Result
    {

        /*
         * Complete the 'sumXor' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER n as parameter.
         */

        public static long sumXor(long n)
        {
            string binary = Convert.ToString(n, 2);

            int count = 0;

            if(binary.Equals("0"))
            {
                return 1;
            }

            for(int i = 0; i < binary.Length; i++)
            {
                if (binary[i].Equals('0'))
                {
                    count++;
                }
            }

            return (long)Math.Pow(2, count);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.sumXor(n);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}