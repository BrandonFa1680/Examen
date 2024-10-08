// See https://aka.ms/new-console-template for more information
using CodigoClase15.Clases;

List<EmpleadoBase> empleados = new List<EmpleadoBase>();

Gerente gerente = new Gerente
{
    IdEmpleado = 1,
    Nombre = "Alberto",
    Puesto = "gerente"
};

Desarrollador desarrollador = new Desarrollador
{
    IdEmpleado = 2,
    Nombre = "Franco",
    Puesto = "desarrollador"
};

GerenteRRHH rrhh = new GerenteRRHH
{
    IdEmpleado = 3,
    Nombre = "Diego",
    Puesto = "gerente RRHH"
};

ConsultorExterno consultor = new ConsultorExterno
{
    IdEmpleado = 4,
    Nombre = "Jose",
    Puesto = "Electricista"
};

empleados.Add(gerente);
empleados.Add(desarrollador);
empleados.Add(rrhh);
empleados.Add(consultor);


Empresa empresa = new Empresa(empleados);

void IngresarEmpleado(Empresa empresa)
{
    Console.WriteLine("Seleccione el tipo de empleado a ingresar:");
    Console.WriteLine("1. Gerente");
    Console.WriteLine("2. Gerente de RRHH");
    Console.WriteLine("3. Desarrollador");
    Console.WriteLine("4. Consultor Externo");
    int tipoEmpleado = Convert.ToInt32(Console.ReadLine());

    EmpleadoBase nuevoEmpleado = null;

    switch (tipoEmpleado)
    {
        case 1:
            nuevoEmpleado = new Gerente();
            break;
        case 2:
            nuevoEmpleado = new GerenteRRHH();
            break;
        case 3:
            nuevoEmpleado = new Desarrollador();
            break;
        case 4:
            nuevoEmpleado = new ConsultorExterno();
            break;
        default:
            Console.WriteLine("Tipo de empleado no válido. Inténtelo de nuevo.");
            return;
    }

    Console.Write("Ingrese el ID del empleado: ");
    nuevoEmpleado.IdEmpleado = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el nombre del empleado: ");
    nuevoEmpleado.Nombre = Console.ReadLine();

    Console.Write("Ingrese el puesto del empleado: ");
    nuevoEmpleado.Puesto = Console.ReadLine();

    empresa.AgregarEmpleado(nuevoEmpleado);
}

int opcion = 0;
do
{
    Console.WriteLine("Bienvenido");
    Console.WriteLine("Elige alguna de las opciones del menú");
    Console.WriteLine("1.Ingresar empleado");
    Console.WriteLine("2. Mostrar Listado de empleados");
    Console.WriteLine("3. Salir");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            IngresarEmpleado(empresa);
            break;
        case 2:
            empresa.MostrarListadoEmpleados();
            break;
        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
            break;
    }
} while (opcion != 3);
