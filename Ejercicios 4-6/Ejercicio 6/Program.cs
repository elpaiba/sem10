namespace Ejercicio_6;

class Program
{
    static void Main(string[] args)
    {
        
        double totalDia = 0;

        for (int turno = 1; turno <= 3; turno++)
        {
            Console.WriteLine($"Turno {turno}");

            double cantidad;
            double precio;

            // Validar cantidad (> 0)
            do
            {
                Console.Write("Ingrese  la cantidad: ");
                cantidad = double.Parse(Console.ReadLine());

                if (cantidad <= 0)
                {
                    Console.WriteLine("Error: la cantidad debe ser mayor que 0");
                }

            } while (cantidad <= 0);

            // Validar precio (> 0)
            do
            {
                Console.Write("Ingrese el precio unitario: ");
                precio = double.Parse(Console.ReadLine());

                if (precio <= 0)
                {
                    Console.WriteLine("Error: el precio debe ser mayor que 0");
                }

            } while (precio <= 0);

            double venta = CalcularVentaTurno(cantidad, precio);

            totalDia += venta;

            Console.WriteLine($"Venta del turno: S/{venta:F2}");
            Console.WriteLine();
        }

        Console.WriteLine($"Total vendido del día: S/{totalDia:F2}");
    }

    static double CalcularVentaTurno(double cantidad, double precio)
    {
        return cantidad * precio;

    }
}