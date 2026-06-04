namespace Ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
       
        double sumaPorcentajes = 0;

        for (int sesion = 1; sesion <= 4; sesion++)
        {
            Console.WriteLine($"Sesión {sesion}:");

            Console.Write("Ingrese la cantidad de presentes: ");
            double presentes = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de matriculados: ");
            double matriculados = double.Parse(Console.ReadLine());

            double porcentaje = CalcularPorcentaje(presentes, matriculados);

            sumaPorcentajes += porcentaje;
        }

        double promedio = sumaPorcentajes / 4;

        Console.WriteLine($"Promedio de asistencia: {promedio:F2}%");

        if (promedio >= 75)
        {
            Console.WriteLine("Participación adecuada");
        }
        else
        {
            Console.WriteLine("Reforzar asistencia");
        }
    }

    static double CalcularPorcentaje(double presentes, double matriculados)
    {
        if (matriculados == 0)
            return 0; // evitar división por cero

        return (presentes * 100) / matriculados;
    }
}