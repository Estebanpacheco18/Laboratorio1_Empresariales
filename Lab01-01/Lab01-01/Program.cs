// See https://aka.ms/new-console-template for more information

Saludar(); // Llamada a un procedimiento
int resultado = Sumar(5, 10); // Llamada a una función
Console.WriteLine("El resultado de la suma es: " + resultado);

int resta = Restar(10, 5);
Console.WriteLine("El resultado de la resta es: " + resta);

int multiplicacion = Multiplicar(5, 3);
Console.WriteLine("El resultado de la multiplicación es: " + multiplicacion);

double division = Dividir(10, 2);
Console.WriteLine("El resultado de la división es: " + division);

Console.WriteLine("Los 10 primeros números primos son:");
ImprimirPrimeros10Primos(); // Llamada a un procedimiento que imprime los primeros 10 números primos

// Conversión de temperaturas
double c = Cel(100);
double f = Fa(5);
Console.WriteLine("Conversion de fahrenheit a celsius:" + c);
Console.WriteLine("Conversion de celsius a fahrenheit:" + f);

static void Saludar()
{
    Console.WriteLine("¡Hola! Bienvenido a la sesión práctica de C#");
}

static int Sumar(int a, int b)
{
    return a + b;
}

static int Restar(int a, int b)
{
    return a - b;
}

static int Multiplicar(int a, int b)
{
    return a * b;
}

static double Dividir(int a, int b)
{
    return b != 0 ? (double)a / b : throw new DivideByZeroException("No se puede dividir por cero");
}

static bool EsPrimo(int numero)
{
    if (numero < 2) return false;
    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0) return false;
    }
    return true;
}

static void ImprimirPrimeros10Primos()
{
    int contador = 0;
    int numero = 2;
    while (contador < 10)
    {
        if (EsPrimo(numero))
        {
            Console.WriteLine(numero);
            contador++;
        }
        numero++;
    }
}

static double Cel(double f)
{
    return 5 * (f - 32) / 9;
}

static double Fa(double c)
{
    return (9 * c / 5) + 32;
}

