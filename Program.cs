using System;

namespace Creacion_de_empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("seleccione un numero");
            //int num = int.Parse(Console.ReadLine());

            //IEmpleados empleados = Empresa.GetEmpleados(num);

            //empleados.GenerarCodigo();

            //Random r = new Random();
            //int a = r.Next(1, 9);
            //int e = r.Next(1, 9);
            //int i = r.Next(1, 9);
            //int o = r.Next(1, 9);

            //Console.WriteLine("GER" + "-" + a + e + i + o);

            //string codig = ("GER" + "-" + a + e + i + o);

            //Gerencial gerencial1 = Gerencial.GetGerencial(codig);

            //gerencial1.GenerarCodigo();

            Menu men = new Menu();

            men.menu();

        }
    }
}
