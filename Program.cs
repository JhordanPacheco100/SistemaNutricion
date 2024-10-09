using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nutricion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio de Programacion el 19/03/2022 Hora: 11:25 p.m. - FinD = 03:00 a.m. hrs.
            Console.WriteLine(" SISTEMA DE NUTRICION");
            double peso = 0;
            double altura = 0;
            Console.WriteLine();
            Console.Write(" Intruduce cantidad de Empleados a evaluar: ");
            int N = Convert.ToInt16(Console.ReadLine());
            int PB = 0, PA = 0, SP = 0, OB = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                Console.WriteLine(" Ingrese sus Datos: ");
                Console.WriteLine();
                Console.Write(" Nombre Completo: ");
                string nom = Console.ReadLine();
                Console.Write(" Ingrese su Peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.Write(" Ingrese su Altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
                double IMC = peso / (altura * altura);
                Console.Write(" Indice de Masa Corporal: " + IMC);
                Console.WriteLine();
                if (IMC < 18.5)
                {
                    Console.Write(" Indice de Masa Coporarl(IMC) en: Peso Bajo");
                    Console.WriteLine();
                    PB++;
                }
                else
                {
                    if (IMC < 25)
                    {
                        Console.Write(" Indice de Masa Coporarl(IMC) en: Peso Adecuado");
                        Console.WriteLine();
                        PA++;
                    }
                    else
                    {
                        if (IMC < 30)
                        {
                            Console.Write(" Indice de Masa Coporarl(IMC) en: Sobre Peso");
                            Console.WriteLine();
                            SP++;
                        }
                        else
                        {
                            Console.Write(" Indice de Masa Coporarl(IMC) en: Obecidad");
                            Console.WriteLine();
                            OB++;
                        }
                    }
                }
            }
            double SUM = PB + PA + SP + OB;
            double POR1 = (PB / SUM) * 100;
            double POR2 = (PA / SUM) * 100;
            double POR3 = (SP / SUM) * 100;
            double POR4 = (OB / SUM) * 100;
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            Console.WriteLine();
            Console.WriteLine(" Empleados con Peso Bajo:     " + PB + " Porcentaje: " + POR1 + " %");
            Console.WriteLine(" Empleados con Peso Adecuado: " + PA + " Porcentaje: " + POR2 + " %");
            Console.WriteLine(" Empleados con Sobre Peso:    " + SP + " Porcentaje: " + POR3 + " %");
            Console.WriteLine(" Empleados con Obecidad:      " + OB + " Porcentaje: " + POR4 + " %");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            Console.WriteLine();
            if (POR1 >= 30)
            {
                Console.WriteLine(" Contratar a un Nutriologo para su Empresa");
            }
            else
            {
                if (POR3 >= 30 || POR4 >= 30)
                {
                    Console.WriteLine(" Contratar a un Nutriologo para su Empresa");
                }
                else
                {

                    Console.WriteLine(" No es Necesario Contratar a un Nutriologo");
                }
            }
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            Console.WriteLine("Modificacion para continuar con el sistema");
            string X = Console.ReadLine();
            Console.WriteLine("Modificacion = "+ X);
        }
    }
}