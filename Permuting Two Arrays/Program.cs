namespace Permuting_Two_Arrays
{
    class Result
    {

        /*
         * Complete the 'twoArrays' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY A
         *  3. INTEGER_ARRAY B
         */

        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            string res = "";

            int count = 0;
            int contor = 0;
            int maxA = A.Max();
            int minA = A.Min();
            int maxB = B.Max();
            int minB = B.Min();

            List<int> list = new List<int>(new int[A.Count]);

            if (maxA + maxB < k || maxA + minB < k || minA + maxB < k)
            {
                return "NO";
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] + B[i] >= k)
                {
                    count++;
                }
            }

            if (count == A.Count)
            {
                return "YES";
            }

            for (int i = 0; i < B.Count; i++)
            {
                if (A[i] + minB >= k)
                {
                    list[i] = A.Count;
                }
                else
                {
                    for (int j = 0; j < B.Count; j++)
                    {
                        if (A[i] + B[j] >= k)
                        {
                            list[i]++;
                        }
                    }
                }               
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (list[i] <= 1)
                {
                    contor++;
                }
            }

            if (contor > 1)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }

            return res;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int k = Convert.ToInt32(firstMultipleInput[1]);

                List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

                List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

                string result = Result.twoArrays(k, A, B);

                //textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}