using System;

namespace CesaròPasswordGeneratoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Generator");

            int[] numeri = new int[10];
            numeri[0] = 1;
            numeri[1] = 2;
            numeri[2] = 3;
            numeri[3] = 4;
            numeri[4] = 5;
            numeri[5] = 6;
            numeri[6] = 7;
            numeri[7] = 8;
            numeri[8] = 9;
            numeri[9] = 10;

            char[] lettere = new char[25];


            lettere[0] = 'a';
            lettere[1] = 'b';
            lettere[2] = 'c';
            lettere[3] = 'd';
            lettere[4] = 'e';
            lettere[5] = 'f';
            lettere[6] = 'g'; 
            lettere[7] = 'h';
            lettere[8] = 'i';
            lettere[9] = 'j';
            lettere[10] = 'l';
            lettere[11] = 'm';
            lettere[12] = 'n';
            lettere[13] = 'o';
            lettere[14] = 'p';
            lettere[15] = 'q'; 
            lettere[16] = 'r';
            lettere[17] = 's';
            lettere[18] = 't'; 
            lettere[19] = 'u';
            lettere[20] = 'v';
            lettere[21] = 'w'; 
            lettere[22] = 'x';
            lettere[23] = 'y';
            lettere[24] = 'z';

            Console.WriteLine("inserisci lunghezza password");
            int  lunghezza = Convert.ToInt32(Console.ReadLine());

            string nuovapass = "";

            Random generatore = new Random();


            for (int i = 0; i < lunghezza; i++) ;
            {
                int indicecasuale = generatore.Next(0, 24);
                nuovapass = nuovapass + lettere[indicecasuale];

            }
            Console.WriteLine("la password è" + nuovapass);
            Console.WriteLine("");
            




        }
    }
}
