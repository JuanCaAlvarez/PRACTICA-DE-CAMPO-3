// See https://aka.ms/new-console-template for more information

using System;
public class NumeroPrimo
{
    static void Main()
    {
        Console.WriteLine("Ingrese un numero entero positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        bool esPrimo = true;
        if (numero <= 1)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)

                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;

                }
        }

        if (esPrimo)
        {
            Console.WriteLine("El numero " + numero + " es primo.");
        }
        else
        {
            Console.WriteLine("El numero " + numero + " no es primo.");

        }
    }
}
