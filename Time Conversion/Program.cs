namespace Time_Conversion
{
    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string timeConversion(string s)
        {
            string[] str = s.Split(':');
            string time = str[2].Substring(2);
            string res = "";
            str[2].Remove(2);
            
            if(time.Equals("AM"))
            {
                if (int.Parse(str[0]) == 12)
                {
                    res = "00:" + str[1] + ":" + str[2].Remove(2);
                }
                else
                {
                    res = str[0] + ":" + str[1] + ":" + str[2].Remove(2);
                }                
            }

            if(time.Equals("PM"))
            {
                int t = int.Parse(str[0]);
                if(t == 12)
                {
                    res = str[0] + ":" + str[1] + ":" + str[2].Remove(2);
                }
                else
                {
                    int y = t + 12;
                    res = y.ToString() + ":" + str[1] + ":" + str[2].Remove(2);
                }
                
            }

            return res;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}