using System;
using System.Collections.Generic;
using System.Text;

namespace Creacion_de_empleados
{
    class Gerencial : Var, IEmpleados
    {

        private static Gerencial gerencial;

        private string Codigo;

        public Gerencial()
        {
        }

        private Gerencial(string Codigo)
        {

            this.Codigo = Codigo;
        }

        public static Gerencial GetGerencial(string cod)
        {
            if(gerencial==null)
            {
                gerencial = new Gerencial(cod);
            }
            return gerencial;
        }

        
        public void Cobrar()
        {
            Salario = HorasTrabajadas * PrecioHoras;

            Console.WriteLine(Salario * 1.50);
        }

        public void GenerarCodigo()
        {
            //Random r = new Random();
            //int a = r.Next(1, 9);
            //int e = r.Next(1, 9);
            //int i = r.Next(1, 9);
            //int o = r.Next(1, 9);

            //Console.WriteLine("GER" + "-" + a+e+i+o);

            Console.WriteLine($"El codigo del gerente es : {Codigo}");
        }

        public void ReciboPago()
        {
            throw new NotImplementedException();
        }

       
    }
}
