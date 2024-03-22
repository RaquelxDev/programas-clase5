/*
static void suma()
{
    //ejercicio 1
    int num1, num2, resultado = 0;
    Console.WriteLine("Ingrese num1: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese num2: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    
    resultado = num1 + num2;
}

static int sumatoria(int num1, int num2, int num3)
{
    int resultado = 0;
    resultado = num1 + num2 + num3;
    return resultado;

}

static string datos()
{
    //ejercicio 2
    Console.WriteLine("Ingrese nombre: ");
    string nombre = Console.ReadLine()!;
    return nombre;
}


static int calculoEdad()
{
    //ejercicio 3
    Console.WriteLine("Ingrese su año de nacimiento");
    int año_nacimiento = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - año_nacimiento;
    return edad;
}


string nombre = datos();
int promedio = sumatoria(20, 25, 40) / 3;
Console.WriteLine($"hola {nombre} su promedio es {promedio} su edad es");


//Adivinar un número que está pensando

Console.WriteLine("- - - Piensa en un número - - - ");

Console.Write("\nIngresa un Numero: ");
int numero = int.Parse(Console.ReadLine()!);

Console.WriteLine("\nMultiplica tu numero por 2");
int Resultado = numero * 2;

Console.WriteLine("\nSumale 8");
Resultado += 8;

Console.WriteLine("\nMultiplicalo por 5");
Resultado *= 5;

Console.Write("\nIngresa el resultado final: ");
int ResultFinal = int.Parse(Console.ReadLine()!);

string SegundoResultado = ResultFinal.ToString();
SegundoResultado = SegundoResultado.Substring(0, SegundoResultado.Length - 1);

ResultFinal = int.Parse(SegundoResultado) - 4;

Console.WriteLine($"\nEl número que pensaste es {ResultFinal}");


//Contador de palabras
Console.WriteLine("Ingrese una frase ");
string Frase = Console.ReadLine()!;

Console.WriteLine("La frase ingresada fue:  " + Frase);

int Palabras = Frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
int Vocales = Contadorvocales(Frase);

Console.WriteLine($"El numero de palabras ingresadas: {Palabras}");
Console.WriteLine($"El numero de vocales ingresadas: {Vocales}");

static int Contadorvocales(string Frase)
{
    int contador = 0;
    foreach (char c in Frase.ToLower())
    {
        if ("aeiou".Contains(c))
        {
            contador++;
        }
    }
    return contador;
}



//Palíndromos

Console.WriteLine("Ingrese una palabra ");
string palabra = Console.ReadLine()!.ToLower();

bool Palindromo = true;

for (int i = 0; i < palabra.Length / 2; i++)
{
    if (palabra[i] != palabra[palabra.Length - 1 - i])
    {
        Palindromo = false;
        break;
    }
}

if (Palindromo)
{
    Console.WriteLine("La palabra ingresada es un palíndromo");
}
else
{
    Console.WriteLine("La palabra ingresada no es un palíndromo");
}


*/