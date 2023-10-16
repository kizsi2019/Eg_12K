namespace gyakorlas;
class Program
{
    static void Main(string[] args)
    {
        bool paros;
        
        Console.WriteLine("szamot MOST!! ");
        int a =Convert.ToInt32(Console.ReadLine());
        Paros(a, out paros);
        Console.WriteLine(paros);
        Console.ReadKey();
    }
    static void Paros(int n, out bool paros)
    {
        if (n % 2 == 0)
        {
            paros = true;
        }
        else { paros = false; }
    }
    
}