namespace Calculadora
{
    internal class Program : Calculadora
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, operacion = 0;

            while (operacion != 5)
            {
                operacion = MuestraMenu();

                if (operacion == 5)
                {
                    Console.WriteLine("Gracias por usar la calculadora.");
                    break;
                }

                Console.WriteLine("\nIngrese el primer número:");
                while (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Por favor, ingrese un número válido:");
                }

                Console.WriteLine("\nIngrese el segundo número:");
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Por favor, ingrese un número válido:");
                }
                Console.WriteLine(num2 == 0 && operacion == 4 ? "No se puede dividir entre cero" : $"El resultado es: {Calcular(num1, num2, operacion)}\n");

                Console.WriteLine($"Pulse enter para realizar una nueva operacion");
                Console.ReadLine();
            }

        }
    }
}
