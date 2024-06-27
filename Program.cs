using ProyectoUnoServicios;

class Program
    {
        static void Main(string[] args)
        {
            Procesos Procesos = new Procesos();
            int option;

            do
            {
                Console.WriteLine("=====Bienvenid@ al sistema de pagos de servicios públicos=====");
                Console.WriteLine("");
                Console.WriteLine("-------------Menú Principal---------------");
                Console.WriteLine("");
                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Realizar Pagos");
                Console.WriteLine("3. Consultar Pagos");
                Console.WriteLine("4. Modificar Pagos");
                Console.WriteLine("5. Eliminar Pagos");
                Console.WriteLine("6. Submenú Reportes");
                Console.WriteLine("7. Salir");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Procesos.InicializarVectores();
                        break;
                    case 2:
                        Procesos.RealizarPagos();
                        break;
                    case 3:
                        Procesos.ConsultarPagos();
                        break;
                    case 4:
                        Procesos.ModificarPagos();
                        break;
                    case 5:
                        Procesos.EliminarPagos();
                        break;
                    case 6:
                        SubmenuReportes(Procesos);
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (option != 7);
        }

        static void SubmenuReportes(Procesos Procesos)
        {
            int optionSub;

            do
        {
                Console.WriteLine("--------------Submenú Reportes--------------");        
                Console.WriteLine("1. Ver todos los Pagos");
                Console.WriteLine("2. Ver Pagos por tipo de Servicio");
                Console.WriteLine("3. Ver Pagos por código de caja");
                Console.WriteLine("4. Ver Dinero Comisionado por servicios");
                Console.WriteLine("5. Regresar Menú Principal");
                optionSub = int.Parse(Console.ReadLine());

                switch (optionSub)
                {
                    case 1:
                        Procesos.VerTodosLosPagos();
                        break;
                    case 2:
                        Procesos.VerPagosPorTipoDeServicio();
                        break;
                    case 3:
                        Procesos.VerPagosPorCodigoDeCaja();
                        break;
                    case 4:
                         Procesos.VerDineroComisionadoPorServicios();
                        break;
                    case 5:
                        Console.WriteLine("Regresando al Menú Principal...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida!!!");
                        break;
                }
            } while (optionSub != 5);
        }
}
