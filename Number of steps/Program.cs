// See https://aka.ms/new-console-template for more information

int n = Convert.ToInt32(Console.ReadLine());
List<int> a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> b = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int min = a.Min();
int step = 0;
int ok = 1;

if(a.Min() >= 0 && a.Max() <= 5000 && b.Min() >= 0 && b.Max() <= 5000 && n >= 0 && n <= 5000 && a.Count == n && b.Count == n)
{
    int i = 0;
    while(i < a.Count)
    {
        while (a[i] >= b[i] && a[i] > min)
        {
            a[i] = a[i] - b[i];
            step++;

            if (a[i] < min)
            {
                min = a[i];
                i = 0;
            }
            else
            {
                i++;
            }
        }
    }
    
    int count = 0;

    for (int j = 0; j < a.Count; j++)
    {
        if (a[j] == a[0])
        {
            count++;
        }
    }

    if (count == n)
    {
        ok = 0;
        Console.WriteLine(step);
    }
    else
    {
        ok = 0;
        Console.WriteLine(-1);
    }
}  
else
{
    Console.WriteLine(-1);
}


