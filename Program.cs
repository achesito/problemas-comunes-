using System;

namespace ejercicioK
{
    class Program
    {
        /// <summary>
        /// programa para obtener grados celsius a traves del medidor de grados farenheit de una empresa con un medidor en celsius descompuesto previamente, desplegando 
        /// un color determinado segun el rango de temperatura(azul si es frio, verde si es normal, amarillo por precaución y rojo si hay que detener las maquinas) junto
        /// a un mensaje que indique ese estado dependiendo del color tal como se detallo antes   
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double gradosF, gradosC, resultado;
            Console.WriteLine("laboratorio 1");
            Console.WriteLine("inserte el numero de grados");
            gradosF = leerDouble("gradosF");
            if (gradosF>= 32)
            {
                resultado = gradosF - 32;
                gradosC = resultado / 1.8;

                Console.WriteLine("la temperatura esta en {0:###0.00}C, tendencia: {1:###0.00}, estado: {2:####0}", gradosC, color(gradosC), mensaje(gradosC)) ;
            }

            else
            {
                Console.WriteLine("datos invalidos");
            }

            Console.ReadKey();
        }

        public static double leerDouble(string gradosF)
        {
            double valor;
            valor = double.Parse(Console.ReadLine());
            return valor;
        }

        public static string color(double gradosC)
        {
            string tono;
            tono = "'''''";
            if (gradosC >= 0 && gradosC <= 15)
            {
                tono = "azul";
            }
            if (gradosC > 15 && gradosC <= 35)
            {
                tono = "verde";
            }
            if (gradosC > 35 && gradosC <= 45)
            {
                tono = "amarillo";
            }
            if (gradosC > 45)
            {
                tono = "rojo";
            }
            return tono; 
        }
        
        public static string mensaje(double gradosC)
        {
            string respon;
            respon = "'''";
            if (gradosC >= 0 && gradosC <= 15)
            {
                respon = "frio";
            }
            if (gradosC > 15 && gradosC <= 35)
            {
                respon = "normal";
            }
            if (gradosC > 35 && gradosC <= 45)
            {
                respon = "precaucion";
            }
            if (gradosC > 45)
            {
                respon = "detener maquinas";
            }
            return respon;
        }
    }
}
