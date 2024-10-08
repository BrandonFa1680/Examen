using CodigoClase15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase15.Clases
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public string Nombre { get; set; }
        public int IdEmpleado { get; set; }
        public string Puesto { get; set; }
        public abstract int SueldoBase { get; }
        public abstract double CalcularSueldo();
        public virtual void MostrarDetalles()
        {
            Console.WriteLine(Nombre);
            Console.WriteLine(IdEmpleado);
            Console.WriteLine(Puesto);
            Console.WriteLine(SueldoBase);
        }
    }
}
