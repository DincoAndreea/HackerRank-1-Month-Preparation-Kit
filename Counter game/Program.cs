namespace Counter_game
{
    class Result
    {

        /*
         * Complete the 'counterGame' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts LONG_INTEGER n as parameter.
         */

        public static string counterGame(long n)
        {
            double m = Convert.ToDouble(n);
            int count = 0;

            while (m > 1)
            {
                if (Math.Log(m, 2) % 1 == 0)
                {
                    m = m / 2;
                }
                else
                {
                    double substract = Math.Pow(2, Convert.ToInt32((Math.Log(m, 2)))) > m ? Math.Pow(2, Convert.ToInt32((Math.Log(m, 2) - 1))) : Math.Pow(2, Convert.ToInt32((Math.Log(m, 2))));
                    m = m - substract;
                }
                count++;
            }

            return count % 2 == 0 ? "Richard" : "Louise";
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
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                string result = Result.counterGame(n);

                //textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}