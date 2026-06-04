using System;

namespace EJERCICIO_1
{
    class Program
    {
        static double CalcularSalario(double valorHora, int horas)
        {
            if (horas <= 192)
            {
                return valorHora * horas;
            }
            else
            {
                int horasExtra = horas - 192;
                double pagoNormal = valorHora * 192;
                double pagoExtra = horasExtra * valorHora * 1.50;
                return pagoNormal + pagoExtra;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== PLANILLA INDUSTRIAL ===");
            Console.Write("Cantidad de obreros: ");
            int n = int.Parse(Console.ReadLine());

            double totalPlanilla = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nObrero {i}");
                Console.Write("Valor por hora: S/");
                double vh = double.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                int hmt = int.Parse(Console.ReadLine());

                double salario = CalcularSalario(vh, hmt);
                totalPlanilla += salario;

                Console.WriteLine($"Salario: S/{salario:F2}");
            }

            Console.WriteLine($"\nTotal de planilla: S/{totalPlanilla:F2}");
        }
    }
}
    
    
   