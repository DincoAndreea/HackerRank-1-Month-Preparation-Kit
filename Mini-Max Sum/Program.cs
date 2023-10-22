namespace Mini_Max_Sum
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            long sum = 0;
            List<long> list = new List<long>();   
            for(int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }

            for(int j = 0; j < arr.Count; j++)
            {
                long res = sum - arr[j];
                list.Add(res);
            }

            Console.WriteLine(list.Min() + " " + list.Max());
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}