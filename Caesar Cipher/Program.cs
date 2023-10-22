namespace Caesar_Cipher
{
    class Result
    {

        /*
         * Complete the 'caesarCipher' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. INTEGER k
         */

        public static string caesarCipher(string s, int k)
        {
            List<char> alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList();
            List<char> alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList();
            List<char> text = s.ToCharArray().ToList();

            for (int i = 0; i < k; i++)
            {
                char temp = alphabet.First();
                alphabet.RemoveAt(0);
                alphabet.Add(temp);
            }

            string result = "";

            for (int i = 0; i < text.Count; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    result += char.IsLower(text[i]) ? alphabet[alpha.IndexOf(char.ToLower(text[i]))] : char.ToUpper(alphabet[alpha.IndexOf(char.ToLower(text[i]))]);
                }
                else
                {
                    result += text[i];
                }
            }

            Console.WriteLine(result);

            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.caesarCipher(s, k);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}