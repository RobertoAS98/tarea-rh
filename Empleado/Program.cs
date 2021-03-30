using System;
using System.Collections.Generic;

namespace Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(new Empleado(1000, "Ana", "Lee", new DateTime(1995, 8, 23), new DateTime(2014, 1, 12), 15000));
            empleados.Add(new Empleado(1000, "Joe", "Biden", new DateTime(1934, 3, 12), new DateTime(2021, 1, 12), 25000));

            //empleados[0].AgregaHoras(new HorasTrabajadas(6, new DateTime(2021, 3, 1, 8, 0, 0, 0)));
            //empleados[0].AgregaHoras(new HorasTrabajadas(7, new DateTime(2021, 3, 2, 8, 0, 0, 0)));
            //empleados[0].AgregaHoras(new HorasTrabajadas(8, new DateTime(2021, 3, 3, 8, 0, 0, 0)));
            //empleados[0].AgregaHoras(new HorasTrabajadas(9, new DateTime(2021, 3, 4, 8, 0, 0, 0)));

            var fechaInicio = new DateTime(1916, 10, 12);
            var fechaHoy = DateTime.Today;

            var edad = fechaHoy.Year - fechaInicio.Year;
            if (fechaInicio.Date > fechaHoy.AddYears(-edad)) edad--;
            Console.WriteLine(edad);

        }
    }
}
