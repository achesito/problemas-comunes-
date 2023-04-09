using System;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// programa para obtener el total a cancelar de un producto el cual tiene distintas categorias,
        /// siendo nuevo, abierto o usado, y se le debe aplicar un descuento a los nuevos dependiendo su departamento, y a los abiertos
        /// y usados un descuento solamente por su condición
        /// </summary>
        /// <param name="args"></param>
        const double ELECTRO = 0.05, ENSER = 0.07, MUEBLE = 0.1, ABIERTODES = 0.25, USADODES = 0.50;
        static void Main(string[] args)
        {
            //declaracion de variables de entrada 
            string nom, departamento, condicion;
            double precioOrigen, monto1;
            Console.WriteLine("ingrese el nombre del producto");
            nom = Console.ReadLine();
            Console.WriteLine("ingrese el departamento del producto");
            departamento = Console.ReadLine();
            Console.WriteLine("inserte el precio original del producto");
            precioOrigen = leerDouble("INGRESE EL VALOR");
            Console.WriteLine("especifique la condicion del producto");
            condicion = Console.ReadLine();

            if (precioOrigen > 0)
            {
                monto1 = precioOrigen - descuento(precioOrigen, condicion, departamento);
                Console.WriteLine("el {0:####} correspondiente al departamento de {1:####} tiene un costo final de {2:###0.00}", nom, departamento, monto1);
            }

            else
            {
                Console.WriteLine("datos invalidos");
            }
            Console.ReadKey();
        }

        public static double leerDouble(string pene)
        {
            double valor;
            Console.WriteLine(pene);
            valor = double.Parse(Console.ReadLine());
            return valor;
        }

        public static double descuento(double precioOrigen, string condicion, string departamento)
        {
            double resultado;
            resultado = 0;
            if (condicion == "nuevo")
            {
                if (departamento == "electronicos")
                {
                    resultado = precioOrigen * ELECTRO;
                }

                if (departamento == "enseres")
                {
                    resultado = precioOrigen * ENSER;
                }

                if (departamento == "muebles")
                {
                    resultado = precioOrigen * MUEBLE;
                }
            }

            if (condicion == "abierto")
            {
                resultado = precioOrigen * ABIERTODES;
            }

            if (condicion == "usado")
            {
                resultado = precioOrigen * USADODES;
            }

            return resultado;
        }
    }
}
