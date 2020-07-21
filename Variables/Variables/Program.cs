using System;

namespace Variables
{
    class Program
    {        
        static void Main(string[] args)
        {
            string nom, cognom1, cognom2, frase1, frase2, nomCognom, data;
            int any, mes, dia, traspas, aux;
            const int anyInici= 1948;
            bool esTraspas;

            //Fase 1
            nom = "Miguel Ánmgel";
            cognom1 = "Barceló";
            cognom2 = "Hernández";

            dia = 29;
            mes = 1;
            any = 1972;

            Console.WriteLine(cognom1+" "+cognom2+", "+nom);
            Console.WriteLine(dia + "/" + mes + "/" + any);

            //Fase 2
            traspas = (any - anyInici)/4;

            Console.WriteLine("Entre el 1948 y "+any+" hay "+traspas+" años bisiestos");

            for (int i = anyInici; i<= any; i++)
            {
                if (i%4==0)
                    Console.WriteLine(i + " es un año bisiesto");
            }

            //Fase 3
            if (any % 4 == 0)
                esTraspas = true;
            else
                esTraspas = false;

            frase1 = "mi año de nacimiento es bisiesto";
            frase2 = "mi año de nacimiento no es bisiesto";

            nomCognom = nom + " " + cognom1 + " " + cognom2;
            data = dia + "/" + mes + "/" + any;

            Console.WriteLine("El meu nom és " + nomCognom);
            Console.WriteLine("Vaig néixer el " + data);

            if (esTraspas)
                Console.WriteLine(frase1);
            else
                Console.WriteLine(frase2);
        }
    }
}
