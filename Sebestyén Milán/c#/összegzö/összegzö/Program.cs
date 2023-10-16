namespace összegzö;

class Program
{
    static void Main(string[] args)
    {
        int[] tomb = { 1, 2, 3, 4, 5, 6, 7 };
        int osszeg = Osszegzo(tomb);
        Console.WriteLine(  osszeg);
        int maxi = Max(tomb);
        Console.WriteLine(maxi);
        int mini = Min(tomb);
        Console.WriteLine(mini);
    }
    static int Osszegzo(int[] tomb)
    {
        int ossz = 0;
        foreach (int i in tomb)
        {
            ossz += i;
        }
        return ossz;
    }
    static int Max(int[] tomb)
    {
        int max = 0;
        foreach (int i in tomb)
        {
            if (max < i)
            {
                max = i;
            }
        }
        return max;
    }
    static int Min(int[] tomb)
    {
        int min = 9999999;
        foreach (int i in tomb)
        {
            if (min> i)
            {
                min = i;
            }
        }
        return min;
    }
}
