using System;
using System.Collections.Generic;
using System.Threading;

namespace ud6_m2
{
    class Program
    {
        public static int TipusCaracter(char a)
        {
            int tipus = 4; //return 1 per digits, 2 per vocals, 3 per espais, 4 per la resta
            if (a == '1' | a == '2' | a == '3' | a == '4' | a == '6' | a == '7' | a == '8' | a == '9' | a == '0')
            {
                tipus = 1;
            }
            if (a == 'a' | a == 'e' | a == 'i' | a == 'o' | a == 'u' | a == 'A' | a == 'E' | a == 'I' | a == 'O' | a == 'U')
            {
                tipus = 2;
            }
            if (a == ' ')
            {
                tipus = 3;
            }
            return tipus;
        }
        static void Main(string[] args)
        {
            //fase1
            char[] nom = { 'L', 'L', 'U', 'I', 'S', ' ', 'P', 'L', 'A', 'N','A','S', ' ', 'M', 'A', 'S', 'T','E','L' };
            for (int i = 0; i < nom.Length; i++)
            {
                Console.WriteLine("{0}", nom[i]);
            }

            //fase2

            List<char> Lista = new List<char>();
            int lletra;
            for (int i = 0; i < nom.Length; i++)
            {
                Lista.Add(nom[i]);
                lletra = TipusCaracter(nom[i]);
                switch (lletra)
                {
                    case 1:
                        Console.WriteLine("Els noms no poden contenir numeros");
                        break;
                    case 2:
                        Console.WriteLine("Vocal");
                        break;
                    case 3:
                        Console.WriteLine("Espai en blanc");
                        break;
                    default:
                        Console.WriteLine("Consonant");
                        break;
                }

            }

            //fase3

            Dictionary<char, int> Dic = new Dictionary<char, int>();
            for (int i = 0; i < nom.Length; i++)
            {
                if (Dic.ContainsKey(nom[i]) == true)
                {
                    Dic[nom[i]]++;
                }
                else
                {
                    Dic.Add(nom[i], 1);
                }
            }

            // foreach per imprimir tot un diccionari

            foreach (KeyValuePair<char, int> entrada in Dic)
            {
                Console.WriteLine("Lletra = {0}, Valor = {1}", entrada.Key, entrada.Value);
            }

            //fase4

            List<char> Nom = new List<char>() { 'L', 'L', 'U', 'I', 'S' };
            List<char> Cognom = new List<char>() { 'P', 'L', 'A', 'N','A','S' };
            List<char> FullNom = new List<char>();

            FullNom.AddRange(Nom);
            FullNom.Add(' ');
            FullNom.AddRange(Cognom);

            Console.WriteLine("\n Nom complet: [{0}]", string.Join(", ", FullNom));

            //Milestone2

            Console.WriteLine("Introdueix l'alçada de la piramide:");

            int alçada = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= alçada; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Introdueix l'alçada de la piramide d'asteriscs:");

            alçada = Convert.ToInt32(Console.ReadLine());

            char[] asteriscos = new char[alçada * 2];
            for (int i = 0; i < alçada * 2; i++)
            {
                asteriscos[i] = '*';
            }

            //for (int z = 0; z < alçada; z++) { Console.Write(asteriscos[z]); }

            for (int i = 0; i < alçada; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    asteriscos[x] = ' ';
                    asteriscos[(alçada * 2) - x - 1] = ' ';
                }
                for (int z = 0; z < alçada * 2; z++) { Console.Write(asteriscos[z]); }
                Console.WriteLine("");
            }

            //Milestone3

            Console.WriteLine("Press enter per començar el rellotge");
            Console.ReadLine();

            int hour, minutes, seconds;
            DateTime date = DateTime.Now;
            hour = date.Hour;
            minutes = date.Minute;
            seconds = date.Second;

            string hora;
            string minuts;
            string segons;

            while (true)
            {
                hora = string.Format("{0:00}", hour);
                minuts = string.Format("{0:00}", minutes);
                segons = string.Format("{0:00}", seconds);

                Console.Clear();
                Console.WriteLine(hora + ":" + minuts + ":" + segons);

                Thread.Sleep(1000);
                seconds++;
                if (seconds == 60)
                {
                    minutes++;
                    seconds = 0;
                }
                if (minutes == 60)
                {
                    hour++;
                    minutes = 0;
                }
                if (hour == 24)
                {
                    minutes = 0;
                    seconds = 0;
                    hour = 0;
                }
            }



        }
    }
}
