using System.Text.RegularExpressions;

namespace Pangrams
{
    class Result
    {

        /*
         * Complete the 'pangrams' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string pangrams(string s)
        {
            string res = "";

            string r = s.ToLower();

            res = "pangram";

            for(char i = 'a'; i <= 'z'; i++)
            {
                if(!r.Contains(i))
                {
                    res = "not pangram";
                    break;
                }
            }

            return res;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.pangrams(s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}