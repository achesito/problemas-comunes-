using System;

namespace ejercicioK
{
    class Program
    {
        /// <summary>
        /// nombre: Hector ernesto Orellana Rodriguez
        /// grupo de laboratiorio: 1
        /// carnet: OR23005
        /// Evaluacion: laboratorio1
        /// Fecha: 25/03/2023
        /// </summary>
        /// <param name="args"></param>

        const double COLOR1 = 15, COLOR2 = 35, COLOR3 = 45, COLOR4 = 45.1;
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
