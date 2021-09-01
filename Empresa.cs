using System;
using System.Collections.Generic;
using System.Text;

namespace Creacion_de_empleados
{
    class Empresa
    {
        public static IEmpleados GetEmpleados(int menu)
        {
            if (menu == 1)
            {
                return new Gerencial();
            }
            if (menu == 2)
            {
                return new Administrativo();
            }
            else
            {
                return new Operativo();
            }




        }



    }
}
