using System;
using System.Collections.Generic;
using System.Text;

namespace Creacion_de_empleados
{
    class Menu
    {
        private List<Var> lista;


        public void menu()
        {
            lista = new List<Var>();
            int opcion = 0;

            do
            {
                Console.WriteLine("Elija la opcion que desea realizar: ");
                Console.WriteLine("1.- Crear empleado Gerencial");
                Console.WriteLine("2.- Crear empleado Administrativo");
                Console.WriteLine("3.- Crear empleado Operativo");
                Console.WriteLine("4.- Eliminar Empleado");
                Console.WriteLine("5.- Mostrar Empleados");
                Console.WriteLine("6.- Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Egerencial();
                        break;
                    case 2:
                        Eadministrativo();
                        break;
                    case 3:
                        //Temp();
                        break;
                    case 4:
                        //Eliminar();
                        break;
                    case 5:
                        mostrar();
                        break;
                }
            } while (opcion != 6);

        }

        public void Egerencial()
        {
            Random r = new Random();
            int a = r.Next(1, 9);
            int e = r.Next(1, 9);
            int i = r.Next(1, 9);
            int o = r.Next(1, 9);

            //Console.WriteLine("GER" + "-" + a + e + i + o);

            string codig = ("GER" + "-" + a + e + i + o);

            Gerencial gerencial1 = Gerencial.GetGerencial(codig);


            Console.Write("Ingrese la cedula empleado: ");
            gerencial1.Cedula = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del empleado: ");
            gerencial1.Nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido del empleado: ");
            gerencial1.Apellido = Console.ReadLine();

            Console.Write("Ingrese el email del empleado : ");
            gerencial1.Email = Console.ReadLine();

            Console.Write("Ingrese el telefono del empleado : ");
            gerencial1.telefono = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el departamento del empleado : ");
            gerencial1.Departamento = "Gerencial";
           
            Console.WriteLine("Ingrese el cargo del empleado : ");
            gerencial1.Cargo = "Jefe";

            Console.Write("Ingrese el Precio por hora del empleado : ");
            gerencial1.PrecioHoras = int.Parse(Console.ReadLine());

            Console.Write("Ingrese las Horas Laboradas del empleado :");
            gerencial1.HorasTrabajadas = int.Parse(Console.ReadLine());


            Console.WriteLine(" ");
            Console.WriteLine("Empleado Creado Correctamente");
            Console.WriteLine(" ");

            lista.Add(gerencial1);
        }

        public void Eadministrativo ()
        {

            Administrativo adm = new Administrativo();

            Console.Write("Ingrese la cedula empleado: ");
            adm.Cedula = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del empleado: ");
            adm.Nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido del empleado: ");
            adm.Apellido = Console.ReadLine();

            Console.Write("Ingrese el email del empleado : ");
            adm.Email = Console.ReadLine();

            Console.Write("Ingrese el telefono del empleado : ");
            adm.telefono = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el departamento del empleado : ");
            adm.Departamento = Console.ReadLine();

            Console.Write("Ingrese el cargo del empleado : ");
            adm.Cargo = Console.ReadLine();

            Console.Write("Ingrese el Precio por hora del empleado : ");
            adm.PrecioHoras = int.Parse(Console.ReadLine());

            Console.Write("Ingrese las Horas Laboradas del empleado :");
            adm.HorasTrabajadas = int.Parse(Console.ReadLine());


            Console.WriteLine(" ");
            Console.WriteLine("Empleado Creado Correctamente");
            Console.WriteLine(" ");

            lista.Add(adm);
        }

        public void mostrar()
        {
            

            Console.WriteLine(" ");
            Console.WriteLine("LISTA EMPLEADOS");
            Console.WriteLine("----------------");
            foreach (Var v in lista)
            {
                Console.WriteLine("La cedula Del Empleado Es: " + v.Cedula);
                Console.WriteLine("El Nombre Del Empleado Es: " + v.Nombre);
                Console.WriteLine("El Aoellido Del Empleado Es: " + v.Apellido);
                Console.WriteLine("El Email Del Empleado Es: " + v.Email);
                Console.WriteLine("El telefono del Empleado es: " + v.telefono);
                Console.WriteLine("El Departamento Del Empleado es: " + v.Departamento);
                Console.WriteLine("El Cargo Del Empleado Es: " + v.Cargo);
                Console.WriteLine("Precio Por Horas Del Empleado: " + v.PrecioHoras);
                Console.WriteLine("Las Horas Que Trabaja El Empleado Son: " + v.HorasTrabajadas);

               

                Console.WriteLine(" ");
            }
        }
    }
}