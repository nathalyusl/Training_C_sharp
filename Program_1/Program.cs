using System;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invertir números de dos cifras");
            
            //Inicializar variables
            int num, aux, dec, uni;
            string linea;  
            
            //Capturar dato
            Console.WriteLine("Ingrese un numero de dos cifras:");
            linea = Console.ReadLine();   //Recordar que el dato que se captura es string
            
            //Conversion

            num = int.Parse(linea);
            dec = num / 10;
            uni = num % 10;

            aux = (uni * 10) + dec;
            
            //Impresion de datos 
            Console.WriteLine("El numero invetido es:" + aux);

        }
    }
}