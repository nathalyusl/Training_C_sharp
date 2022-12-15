using System;

namespace Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INVERTIR NÚMEROS DE TRES CIFRAS");
            
            //Inicializar variables
            int num, aux, dec, uni, cen, nu;
            string linea;
            
            //Capturar datos
            Console.WriteLine("Ingrese el número de tres cifras: ");
            linea = Console.ReadLine();

            //Solucion
            num = int.Parse(linea);

            cen = num / 100;
            nu = num % 100;
            dec = nu / 10;
            uni = nu % 10;
            aux = (uni * 100) + (dec * 10) + cen;
            
            //Imrimir los datos
            Console.WriteLine("El número invertido es: " + aux);
        }
    }
}