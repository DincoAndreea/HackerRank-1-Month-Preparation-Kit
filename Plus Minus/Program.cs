namespace Plus_Minus
{
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            int poz = 0, neg = 0, zero = 0;
            if (arr.Count > 0 && arr.Count <= 100 && arr.Max() <= 100 && arr.Min() >= -100)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] > 0)
                    {
                        poz++;
                    }
                    if (arr[i] < 0)
                    {
                        neg++;
                    }
                    if (arr[i] == 0)
                    {
                        zero++;
                    }
                }
            }

            double p = ((double)poz / (double)arr.Count);
            double n = ((double)neg / (double)arr.Count);
            double z = ((double)zero / (double)arr.Count);
            Console.WriteLine(string.Format("{0:0.0000000}", p) + "\n" + string.Format("{0:0.0000000}", n) + "\n" + string.Format("{0:0.0000000}", z));
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}