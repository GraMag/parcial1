using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Enum;

namespace Biblioteca
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, string apellido, string password)
            : base(nombre, apellido, password, ECargo.ADMIN)
        {

        }

        public static string MostrarEmpleados(List<Empleado> empleados)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("+-+-+-+-+-+-EMPLEADOS-+-+-+-+-+-+\n");
            foreach (Empleado empleado in empleados)
                sb.AppendLine(MostrarEmpleado(empleado));

            return sb.ToString();
        }

        public static string MostrarEmpleado(Empleado empleado)
        {
            return empleado.ToString();
        }
        /*  public Empleado ModificarEmpleado(List<Empleado> empleados, int id, Empleado empleadoModificado)
           {
               foreach (Empleado empleado in empleados)
               {
                   if(empleado.Id == id)
                   {
                      // empleado = empleadoModificado;
                       break;
                   }
               }
               return empleado;

           }*/
    }
}
