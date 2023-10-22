// See https://aka.ms/new-console-template for more information


int t = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] nm = Console.ReadLine().Split(' ');
    (int n, int m) = (Convert.ToInt32(nm[0]), Convert.ToInt32(nm[1]));
    List<int> linii = new List<int>();
    List<int> coloane = new List<int>();
    int[][] matrice = new int[n][];

    for (int j = 0; j < n; j++)
    {
        List<char> simboluri = Console.ReadLine().ToCharArray().ToList();
        List<int> simbol = new List<int>();
        foreach(char c in simboluri)
        {
            if(c.Equals('#'))
            {
                simbol.Add(1);
            }
            else if(c.Equals('.'))
            {
                simbol.Add(0);
            }
        }
        matrice[j] = simbol.ToArray();
        int max1 = 0;
        int suma = 0;
        for(int y = 0; y < m; y++)
        {
            if (matrice[j][y] == 1)
            {
                suma += matrice[j][y];
            }
            else
            {
                suma = 0;
            }
            if(suma > max1)
            {
                max1 = suma;
            }
        }
        linii.Add(max1);
    }

    for(int k = 0; k < m; k++)
    {
        int sum = 0;
        List<int> sume2 = new List<int>();
        int max2 = 0;
        for(int l = 0; l < n; l++)
        {
            if (matrice[l][k] == 1)
            {
                sum += matrice[l][k];
            }
            else
            {
                sum = 0;
            }
            if(sum > max2)
            {
                max2 = sum;
            }
        }
        coloane.Add(max2);
    }

    int max = Math.Max(linii.Max(), coloane.Max());
    
    Console.WriteLine(max);
}
