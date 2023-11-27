using System;

namespace Program{
    class Program{

        static int ParatlanSzam(int[] szamokT){
            int count = 0;

            for (int i = 0; i < szamokT.Length; i++)
            {
                if(szamokT[i] % 2 != 0){
                    count++;
                }
            }
            return count;
        }

        static int[] ParatlanSzamok(int[] szamokT, out int paratlanIndex){
            int[] paratlanok = new int[ParatlanSzam(szamokT)];
            paratlanIndex = 0;

            for (int i = 0; i < szamokT.Length; i++)
            {
                if(szamokT[i] % 2 != 0){
                    paratlanok[paratlanIndex] = szamokT[i];
                    paratlanIndex++;
                }
            }
            return paratlanok;
        }

        static int[] OszthatoHarom(int[] szamokT){
            int[] szamok = new int[szamokT.Length];

            int index = 0;

            for (int i = 0; i < szamokT.Length; i++)
            {
                if(szamokT[i] % 3 == 0){
                    szamok[index] = szamokT[i];
                    index++;
                }
            }

            return szamok;

        }
        static int[] NegyzetSzam(int[] szamokT){
            int[] szamok = new int[szamokT.Length];

            int index = 0;

            for (int i = 0; i < szamokT.Length; i++)
            {
                if(Math.Sqrt(szamokT[i]) % 1 == 0){
                    szamok[index] = szamokT[i];
                    index++;
                }
            }

            return szamok;

        }

        static void Main(string[] args){
            int n = 40;

            int[] nums = new int[n];

            Random rnd = new Random();


            int index = 0;
            while(index != n){
                int rndNum = rnd.Next(1, 100);
                if(!Array.Exists(nums, x => x == rndNum)){
                    nums[index] = rndNum;
                    index++;
                }
            }

            /*
            int paratlanIndex = 0;

            int[] paratlan = ParatlanSzamok(nums, out paratlanIndex);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < paratlan.Length; i++)
            {
                Console.Write(paratlan[i] + " ");
            }
            */
            
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
            int[] harommal = OszthatoHarom(nums);

            for (int i = 0; i < harommal.Length; i++)
            {
                if(harommal[i] == 0){
                    break;
                }
                Console.Write(harommal[i] + " ");
            }
            Console.WriteLine();
            int[] negyzet = NegyzetSzam(nums);
            
            for (int i = 0; i < negyzet.Length; i++)
            {
                if(negyzet[i] == 0){
                    break;
                }
                Console.Write(negyzet[i] + " ");
            }

        }

    }
}