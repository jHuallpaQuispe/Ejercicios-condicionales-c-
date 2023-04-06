using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            float importe, litros;

            Console.WriteLine("INGRESE EL IMPORTE: ");
            importe = float.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LA CANTIDAD DE LITROS QUE VA LLEVAR: ");
            litros = float.Parse(Console.ReadLine());
            
            //DESCUENTOS SEGUN LITROS VENDIDOS

            if(litros > 500){
                importe = importe * 0.75f; // descuento del 25%
                Console.WriteLine("EL IMPORTE CON EL DESCUENTO ES  DE: ARS$ "+ importe );
            }
            else if(litros >= 301){
                importe = importe * 0.85f; // descuento del 15%
                Console.WriteLine("EL IMPORTE CON EL DESCUENTO ES  DE: ARS$ "+ importe );
            }
            else if(litros >= 101){
                importe= importe * 0.90f; // decuento del 10%
                Console.WriteLine("EL IMPORTE CON EL DESCUENTO ES  DE: ARS$ "+ importe );
            }
            else
                Console.WriteLine("NO HAY DESCUENTO PORQUE LO MINIMO ES DE 100 LITROS, EN TOTAL A PAGAR ES: ARS$ "+ importe);

        }
    }
}
