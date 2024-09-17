// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;


/*void mostrarTexto()
{
    Console.WriteLine("Primer commit");
}*/

int numero()
{
    Console.WriteLine("Ingrese un numero");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero > 0)
    {
        Console.WriteLine("Es positivo");
        return numero;
    }
    else if (numero < 0)
    {
        Console.WriteLine("Es negativo");
        return numero;
    }
    else 
    {
        Console.WriteLine("Es cero");
        return numero;
    }
}
void diaSemana()
{
    Console.WriteLine("Escribe un día");
    string dia = Console.ReadLine().ToUpper();
  
    switch (dia)
    {
        case "LUNES":
            Console.WriteLine("Hoy es Lunes");
            break;
        case "MARTES":
            Console.WriteLine("Hoy es Lunes");
            break;
        case "MIERCOLES":
            Console.WriteLine("Hoy es Lunes");
            break;
        case "JUEVES":
            Console.WriteLine("Hoy es Lunes");
            break;
        case "VIERNES":
            Console.WriteLine("Hoy es Lunes");
            break;
        case "SABADO":
            Console.WriteLine("Hoy es Lunes");
            break;
        default:
            Console.WriteLine("Hoy es Lunes");
            break;
    }
}
int sumaNaturales()
{
    int suma = 0;
    for (int i = 0; i <= 100; i++)
    {
        suma += i;
    }
    return suma;
}
void enumerado()
{
    Console.WriteLine("Ingresa un limite");
    int numero = Convert.ToInt32(Console.ReadLine());

    for (int i = 1;i <= numero; i++)
    {
        Console.WriteLine(i);
    }
}
double areaCirculo()
{
    Console.WriteLine("Ingresa un valor para el radio");
    double radio = Convert.ToDouble(Console.ReadLine());
    double area = Math.Pow(radio, 2)*Math.PI;
    return area;
}
void listar(string[] arr)
{
    Console.WriteLine("Los elementos de la lista son :");
    foreach (string item in arr)
    {
        Console.WriteLine(item);
    }
}
string[] lista = { "gato", "perro", "conejo", "loro" };
void listarNombres(List<string> arr)
{
    Console.WriteLine("Los nombres de la lista son :");
    foreach (var item in arr)
    {
        Console.WriteLine(item);
    }
}
List<string> listaNombres = new List<string> { "Juan", "María", "Pedro", "Ana", "Luis" };

int opcion = 0;
do
{
    Console.WriteLine("Escoge una opción ");
    Console.WriteLine("1");
    Console.WriteLine("2");
    Console.WriteLine("3");
    Console.WriteLine("4");
    Console.WriteLine("5");
    Console.WriteLine("6");
    Console.WriteLine("7");
    Console.WriteLine("8");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            numero();
            break;
        case 2:
            diaSemana();
            break;
        case 3:
            Console.WriteLine(sumaNaturales());
            break;
        case 4:
            enumerado();
            break;
        case 5:
            Console.WriteLine(areaCirculo());
            break;
        case 6:
            listar(lista);
            break;
        case 7:
            listarNombres(listaNombres);
            break;
        case 8:
            Console.WriteLine("Usted salio del menú");
            break;
    }

} while (opcion != 8);