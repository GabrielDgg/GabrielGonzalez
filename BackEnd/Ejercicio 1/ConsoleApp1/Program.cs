using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
   
    class Program
    {
        static void PedirDatos()
        {
            Console.WriteLine("hola");
        }

        static void Main(string[] args)
        {
            
            int [] x= new int[3];
            int [] y = new int[3];
            string n1;
            string n2;
            bool esNumeroX, esNumeroY;


            for (int i = 0; i < 3; i++)
            {


                do
                {
                    Console.WriteLine("introdusca cordenadas del Punto: " + (i + 1));
                    Console.WriteLine("X:");
                    n1 = Console.ReadLine();
                  
                    esNumeroX = int.TryParse(n1, out x[i]);
                   
                 

                    if (esNumeroX)
                    {
                        x[i] = int.Parse(n1);
                    }
                    else
                    {
                        Console.WriteLine("ingrese un numero entero");
                    }


                    Console.WriteLine("y:");
                    n2 = Console.ReadLine();
                    esNumeroY = int.TryParse(n2, out y[i]);

                    if (esNumeroY)
                    {
                        y[i] = int.Parse(n2);
                        Console.WriteLine("ingrese un numero entero");
                    }
                    else
                    {
                        Console.WriteLine("ingrese un numero entero");
                    }



                    Console.Clear();
                } while (!(esNumeroX && esNumeroY));
            }

            //distancia
            double resultado = 0;
            //primer numero con el segundo
            resultado += Math.Sqrt(((x[1] - x[0]) ^ 2) + ((y[1] - y[0]) ^ 2));
            //primer numero con el tercero
            resultado += Math.Sqrt(((x[2] - x[0]) ^ 2) + ((y[2] - y[0]) ^ 2));
            //segundo numero con el tercero
            resultado += Math.Sqrt(((x[1] - x[2]) ^ 2) + ((y[1] - y[2]) ^ 2));

            //calculo promedio
            resultado = resultado / 3;

            Console.WriteLine("El promedio de la distacia es: " + resultado);

            Console.ReadKey();
        }
    }
}
