using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int n1,n2,n3,n4, Menor;
            //CARAGA DE DATOS
            Console.WriteLine("INGRESE EL 1ER NUMERO: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL 2DO NUMERO: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL 3ER NUMERO: ");
            n3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("INGRESE EL CUARTO NUMERO: ");
            n4 = int.Parse(Console.ReadLine());

            // EL MENOR LO PUSE AL 1RO PARA COMPARARLO CON LOS DEMAS
            Menor = n1;

            if(n2 < Menor)
                Menor = n2;
            if(n3 < Menor)
                Menor = n3;
            if(n4 < Menor)
                Menor = n4;
            
            //MOSTRAR EN PANTALLA

            Console.WriteLine("El Número menor es: "+ Menor);


        }
    }
}
