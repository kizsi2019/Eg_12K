namespace adatbekeres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("megadot szam: "+ Ellbeker("adj meg egy szamot 10 es 20 között: ",10,20));
            Console.ReadKey();
        }
        static int Ellbeker(string uzi,int x, int y)
        {
            int sum;
            do
            {
                Console.WriteLine(uzi);

            }while (!(int.TryParse(Console.ReadLine(), out sum) || (sum > x && sum < y)));
            
                return sum;
            
        }
    }
}