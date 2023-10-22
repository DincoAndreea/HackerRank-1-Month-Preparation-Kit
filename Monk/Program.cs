namespace Monk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            List<List<int>> list = new List<List<int>>();

            for (int i = 0; i < t; i++)
            {
                string[] nm = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(nm[0]);
                int m = Convert.ToInt32(nm[1]);
                List<int> lst = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < m; j++)
                {
                    int aux = lst[n - 1];
                    lst.RemoveAt(n - 1);
                    lst.Insert(0, aux);
                }

                list.Add(lst);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(string.Join(" ", list[i]));
            }
        }
    }
}