using System;

namespace laboratorio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int clave;
            double PrecioArticulo, preciofinal;
            String DescArt;
            Console.Write("ingrese descripcionn  del articulo");
            DescArt= Console.ReadLine();
            Console.Write("ingrese clave del articulo: ");
            clave =  int.Parse(Console.ReadLine());
            if (clave==1 || clave==2)
            {
                Console.Write("ingrese el precio del articulo ");
                PrecioArticulo = double.Parse(Console.ReadLine());
            
                if (clave== 1)
                {
                   preciofinal= PrecioArticulo * 0.9;

                }
                else
                {
                    preciofinal =PrecioArticulo * 0.8;
                }
                Console.WriteLine("articulo:"+ DescArt + "--clave:"+ clave + "--preecio original "+ PrecioArticulo + "--precion con descuento "+ preciofinal);

            }
            else 
            {
                Console.WriteLine("error de carga , valor de clave incorrecta...");
            }    
                

            
            
               
            



        
           
        }
    }
}
