int entero;
decimal n1;

try
{
    Console.WriteLine("Ingresa un numero entero");
    entero = Convert.ToInt16(Console.ReadLine());
    n1 = (decimal)entero;
    Console.WriteLine("El numero en decimal es: " + n1);
}
catch (Exception ex)
{
    Console.WriteLine("¡Cuidado!, cometiste un error:" + ex.Message);
}

decimal d1;
float n2;

try
{
    Console.WriteLine("Por favor, ingresa un número decimal:");
    d1 = Convert.ToDecimal(Console.ReadLine());
    n2 = (float)d1;
    Console.WriteLine("Número flotante convertido: " + n2);
}
catch (Exception ex)
{
    Console.WriteLine("¡Cuidado! Ocurrió un error: " + ex.Message);
}

float n3;
int entero2;

try
{
    Console.WriteLine("Por favor ingresa un numero flotante");
    n3 = Convert.ToInt32(Console.ReadLine());
    entero2 = (int)n3;
    Console.WriteLine("El numero convertido a entero es: " + entero2);
}
catch (Exception ex)
{
    Console.WriteLine("¡Cuidado! Ocurrió un error: " + ex.Message);
}

char caracter;
int n4;

try
{
    Console.WriteLine("Por favor, ingresa una letra:");
    caracter = Console.ReadKey().KeyChar;
    n4 = (int)caracter;
    Console.WriteLine("El valor numérico de la letra ingresada es " + n4);
}
catch (Exception ex)
{
    Console.WriteLine("¡Cuidado! Ocurrió un error: " + ex.Message);
}

int n5;
char caracter2;

try
{
    Console.WriteLine("Por favor, ingresa un numero:");
    n5 = int.Parse(Console.ReadLine());
    caracter2 = (char)n5;
    Console.WriteLine("El numero ingresado equivale a la letra:" + caracter2);
}
catch (Exception ex)
{
    Console.WriteLine("¡Cuidado! Ocurrió un error: " + ex.Message);
}
