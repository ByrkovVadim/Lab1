using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class NumericManipulater
    {
        Random rnd = new Random();
        public bool Check_simplenumber(int num) // Проверка на простоту
        {
            bool isSimple = true;

            for (int i = 2; i < num; i++)
            {
                int promnum = num % i;
                if (promnum == 0)
                {
                    isSimple = false;
                    break; // число непростое
                }
            }
            if (isSimple == true)
            {
                isSimple = true; // Число простое 
            }
            return isSimple;
        }


        public bool MutuallyPrimeNumbers(int a, int b) // Метод проверяющий числа на взаимную простату
        {
            if (NOD(a, b) == 1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }


        int NOD(int numA, int numB) // Метод находящий наибольший общий делитель
        {
            if(numA < numB) 
            {
                int bufnum = numA;
                numA = numB;
                numB = bufnum;
            }

            for(int i=0; numA > numB; i++)
            {
                numA = numA - numB;
                if(numA == 0)
                {
                    return numB;
                }
                if(numA < numB)
                {
                    int bufnum = numA;
                    numA = numB;
                    numB = bufnum;
                }
            }
            return numA;
        }

        public int NumberE(int numberD, int numberF) // Метод вычисляющий е
        {
            int numberE;
            numberE = rnd.Next(2, 10000);
            if (numberE > numberD)
            {
                numberE = rnd.Next(2, numberD);
            }
            do
            {
                numberE++;
            } while ((numberE*numberD)%numberF != 1);

            return numberE;
        }
    }
}
