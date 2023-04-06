using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

            int n1, n2, n3, n4, Bandera;
            

            Console.WriteLine("INGRESE EL 1ER NUMERO: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL 2DO NUMERO: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL 3ER NUMERO: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL 4TO NUMERO: ");
            n4 = int.Parse(Console.ReadLine());

            //Bandera para para saber si esta ordenado, si solo 1 no lo esta, directamente no esta ordenado
            Bandera = 1;

            //BUSCAR EL ORDENAMIENTO DECRECIENTE

            if(!(n1 > n2))
                Bandera = 0;
            if(!(n2 > n3))
                Bandera = 0;
            if(!(n3 > n4))
                Bandera = 0;
            
            if(Bandera == 1)
                Console.WriteLine("ESTA ORDENADO");
            else
                Console.WriteLine("NO ESTA ORDENADO");
        }
    }
}
