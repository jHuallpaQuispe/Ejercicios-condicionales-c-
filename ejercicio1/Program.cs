using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            
            int a, b;
            Console.WriteLine("INGRESE UN NÚMERO: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE OTRO NÚMERO: ");
            b = int.Parse(Console.ReadLine());

            //OPERACIONES

            if(a > b)
                Console.WriteLine("La resta es: "+ (a-b));
            else if(a == b)
                Console.WriteLine("La suma es: "+ (a+b));
            elses
                Console.WriteLine("El producto es: " + (a*b));



        }
    }
}
