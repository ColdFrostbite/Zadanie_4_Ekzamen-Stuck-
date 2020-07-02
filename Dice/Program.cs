using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxSum; //максимальная сумма
            int MaxPro; //максимальное произведение
            int Deli; //делитель произведения
            double Pa, Pb, Pv;
            double Ka, Kb, Kv;

            Pa = 0;
            Pb = 0;
            Pv = 0;
            Ka = 0;
            Kb = 0;
            Kv = 0;

            Console.Write("Введите максимальную сумму:  ");
            MaxSum = Convert.ToInt32(Console.ReadLine());
            if (MaxSum > 12)
            {
                Console.Write("Максимальная сумма превышает допустимое значение");
                return;
            }

            Console.Write("Введите максимальное произведение:  ");
            MaxPro = Convert.ToInt32(Console.ReadLine());
            if (MaxPro > 36)
            {
                Console.Write("Максимальное произведение превышает допустимое значение");
                return;
            }


            Console.Write("Делитель произведения:  ");
            Deli = Convert.ToInt32(Console.ReadLine());
            if (Deli > 36)
            {
                Console.Write("Делитель произведения превышает допустимое значение");
                return;
            }

            int[,] MassiveSum = new int[7, 7];
            int[,] MassivePro = new int[7, 7];

            
            for(int i=1; i<7;i++)
            {
                for(int k=1;k<7;k++)
                {
                    MassiveSum[i, k] = i + k;
                    MassivePro[i, k] = i * k;
                    if (MassiveSum[i, k] <= MaxSum)
                    {
                        Ka++;
                    }
                    if(MassivePro[i,k]<MaxPro)
                    {
                        Kb++;
                    }
                    if(MassivePro[i,k])
                    {
                       
                    }

                }
               
            }
            Pa = Ka / 36 * 100;

            Console.ReadLine();
        }
    }
}
