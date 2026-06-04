using System;

namespace Ejercicio_2
{
    class Program
    {
        static double CalcularImporte(int cantidad, double precio)
        {
            return cantidad * precio;
        }

        static void MostrarPedido(string plato, int cantidad, double importe)
        {
            Console.WriteLine($"Pedido: {plato} | Cantidad: {cantidad} | Importe: S/{importe:F2}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE PEDIDOS DEL DÍA ===");
            double totalDia = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"\nPedido {i}");
                Console.Write("Nombre del plato: ");
                string plato = Console.ReadLine();
                Console.Write("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.Write("Precio unitario: S/");
                double precio = double.Parse(Console.ReadLine());

                double importe = CalcularImporte(cantidad, precio);
                totalDia += importe;

                MostrarPedido(plato, cantidad, importe);
            }

            Console.WriteLine($"\nTotal vendido del día: S/{totalDia:F2}");
        }
    }
}

