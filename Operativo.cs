using System;
using System.Collections.Generic;
using System.Text;

namespace Creacion_de_empleados
{
    class Operativo : Var, IEmpleados
    {
        public void Cobrar()
        {
            Salario = HorasTrabajadas * PrecioHoras;

            Console.WriteLine(Salario * 1.10);
        }

        public void GenerarCodigo()
        {
            Random r = new Random();
            int a = r.Next(1, 9);
            int e = r.Next(1, 9);
            int i = r.Next(1, 9);
            int o = r.Next(1, 9);

            Console.WriteLine("OPE" + "-" + a + e + i + o);
        }

        public void ReciboPago()
        {
            throw new NotImplementedException();
        }
    }
}
