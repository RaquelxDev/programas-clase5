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


