namespace referenciaparameter;
class Program
{
    static void Main(string[] args)
    {
        int a = 6, b = 4, c;
        c = KetszeresetOsszeadoFuggveny(a, b);
        Console.WriteLine("\'a\' értéke : {0}\n\'b\' értéke: {2}", a, b, c);
        Console.ReadKey(); 
    }
    static int KetszeresetOsszeadoFuggveny(int szam1, int szam2)
    {
        szam1 = szam1 * 2;
        szam2 = szam2 * 2;
        return szam1 * szam2;

    }

}