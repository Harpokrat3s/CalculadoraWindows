using System;

class CalculadoraWindows
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora Windows");

        while (true)
        {
            MostrarMenu();

            Console.Write("Ingrese la opción deseada: ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RealizarOperacion(Sumar);
                    break;
                case "2":
                    RealizarOperacion(Restar);
                    break;
                case "3":
                    RealizarOperacion(Multiplicar);
                    break;
                case "4":
                    RealizarOperacion(Dividir);
                    break;
                case "5":
                    RealizarOperacion(Potencia);
                    break;
                case "6":
                    RealizarOperacion(RaizCuadrada);
                    break;
                case "7":
                    RealizarOperacion(Seno);
                    break;
                case "8":
                    RealizarOperacion(Coseno);
                    break;
                case "9":
                    RealizarOperacion(Tangente);
                    break;
                case "10":
                    Console.WriteLine("Gracias por utilizar la Calculadora Windows. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("---- Menú de Opciones ----");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Potencia");
        Console.WriteLine("6. Raíz Cuadrada");
        Console.WriteLine("7. Seno");
        Console.WriteLine("8. Coseno");
        Console.WriteLine("9. Tangente");
        Console.WriteLine("10. Salir");
    }

    static void RealizarOperacion(Func<double[], double> operacion)
    {
        Console.Write("Ingrese la cantidad de números que desea utilizar: ");
        int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

        double[] numeros = new double[cantidadNumeros];

        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.Write("Ingrese el número {0}: ", i + 1);
            string? entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out numeros[i]))
            {
                Console.WriteLine("¡Debe ingresar un número válido!");
                i--;
            }
        }

        double resultado = operacion(numeros);
        Console.WriteLine("El resultado es: " + resultado);
    }

    static double Sumar(double[] numeros)
    {
        double resultado = 0;

        foreach (double numero in numeros)
        {
            resultado += numero;
        }

        return resultado;
    }

    static double Restar(double[] numeros)
    {
        double resultado = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            resultado -= numeros[i];
        }

        return resultado;
    }

    static double Multiplicar(double[] numeros)
    {
        double resultado = 1;

        foreach (double numero in numeros)
        {
            resultado *= numero;
        }

        return resultado;
    }

    static double Dividir(double[] numeros)
    {
        double resultado = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] != 0)
            {
                resultado /= numeros[i];
            }
            else
            {
                Console.WriteLine("¡No se puede dividir por cero!");
                return 0;
            }
        }

        return resultado;
    }

    static double Potencia(double[] numeros)
    {
        if (numeros.Length == 2)
        {
            return Math.Pow(numeros[0], numeros[1]);
        }
        else
        {
            Console.WriteLine("Se requieren dos números para la operación de potencia.");
            return 0;
        }
    }

    static double RaizCuadrada(double[] numeros)
    {
        if (numeros.Length == 1)
        {
            return Math.Sqrt(numeros[0]);
        }
        else
        {
            Console.WriteLine("Se requiere un número para la operación de raíz cuadrada.");
            return 0;
        }
    }

    static double Seno(double[] numeros)
    {
        if (numeros.Length == 1)
        {
            return Math.Sin(numeros[0]);
        }
        else
        {
            Console.WriteLine("Se requiere un número para la operación de seno.");
            return 0;
        }
    }

    static double Coseno(double[] numeros)
    {
        if (numeros.Length == 1)
        {
            return Math.Cos(numeros[0]);
        }
        else
        {
            Console.WriteLine("Se requiere un número para la operación de coseno.");
            return 0;
        }
    }

    static double Tangente(double[] numeros)
    {
        if (numeros.Length == 1)
        {
            return Math.Tan(numeros[0]);
        }
        else
        {
            Console.WriteLine("Se requiere un número para la operación de tangente.");
            return 0;
        }
    }
}

