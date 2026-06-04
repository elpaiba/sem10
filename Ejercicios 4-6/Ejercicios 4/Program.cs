namespace Ejercicios_4;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Ingrese el código: ");
        int codigo = int.Parse(Console.ReadLine());

        int digitos = ContarDigitos(codigo);

        if (digitos >= 6 && digitos <= 8)
        {
            Console.WriteLine("Código válido");
        }
        else
        {
            Console.WriteLine("Código inválido");
        }
    }

    static int ContarDigitos(int codigo)
    {
        int contador = 0;

        // Trabajar con valor absoluto
        codigo = Math.Abs(codigo);

        // Caso especial: 0 tiene 1 dígito
        if (codigo == 0)
        {
            return 1;
        }

        while (codigo > 0)
        {
            contador++;
            codigo = codigo / 10;
        }

        return contador;
    }
}