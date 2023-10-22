namespace Recursive_Digit_Sum
{
    class Result
    {

        /*
         * Complete the 'superDigit' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING n
         *  2. INTEGER k
         */

        public static int superDigit(string n, int k)
        {
            string num = (string)n.Clone();

            long sum = 0;

            double a = 5;
            int b = 2;

            a = a - b;

            for (int i = 0; i < num.Length; i++)
            {
                sum += (int)(num[i] - '0');
            }

            sum = sum * k;

            num = sum.ToString();

            while (num.Length > 1)
            {
                sum = 0;

                for (int i = 0; i < num.Length; i++)
                {
                    sum += (int)(num[i] - '0');
                }

                num = sum.ToString();
            }

            Console.WriteLine(num);

            return int.Parse(num);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //string n = firstMultipleInput[0];

            //int k = Convert.ToInt32(firstMultipleInput[1]);

            string[] linii = File.ReadAllLines("in.txt");

            (string n, int k) = (linii[0].Split(' ')[0], int.Parse(linii[0].Split(' ')[1]));

            int result = Result.superDigit(n, k);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}