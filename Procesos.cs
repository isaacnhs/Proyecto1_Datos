using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUnoServicios
{
    public class Procesos
    {
        
        private Variables_Lista[] Variables_Lista = new Variables_Lista[10];
        private int count = 0;
        private Random random = new Random();

        public void InicializarVectores()
        {
            for (int i = 0; i < 10; i++)
            {
                Variables_Lista[i] = new Variables_Lista();
            }
            count = 0;
            Console.WriteLine("Vectores inicializados");
        }

        public void RealizarPagos()
        {
            if (count >= 10)
            {
                Console.WriteLine("Vectores Llenos.");
                return;
            }

            Variables_Lista Variables_Lista = new Variables_Lista();

            Console.WriteLine("Ingrese la cédula:");
            Variables_Lista.Cedula = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre:");
            Variables_Lista.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el primer apellido:");
            Variables_Lista.Apellido1 = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo apellido:");
            Variables_Lista.Apellido2 = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de servicio (1= Recibo de Luz, 2= Recibo de Teléfono, 3= Recibo de Agua):");
            Variables_Lista.TipoServicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de factura:");
            Variables_Lista.NumeroFactura = Console.ReadLine();

            Console.WriteLine("Ingrese el monto a pagar:");
            Variables_Lista.MontoPagar = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el monto paga cliente:");
            Variables_Lista.MontoPagaCliente = decimal.Parse(Console.ReadLine());

            Variables_Lista.NumeroCaja = new Random().Next(1, 4);  
            Variables_Lista.Fecha = DateTime.Now;
            Variables_Lista.Hora = DateTime.Now.ToString("HH:mm:ss");
            Variables_Lista.NumeroPago = count + 1;

            decimal commissionRate = 0;
            switch (Variables_Lista.TipoServicio)
            {
                case 1:
                    commissionRate = 0.04m;
                    break;
                case 2:
                    commissionRate = 0.055m;
                    break;
                case 3:
                    commissionRate = 0.065m;
                    break;
                default:
                    Console.WriteLine("Tipo de servicio inválido.");
                    return;
            }

            Variables_Lista.MontoComision = Variables_Lista.MontoPagar * commissionRate;
            Variables_Lista.MontoDeducido = Variables_Lista.MontoPagar - Variables_Lista.MontoComision;
            Variables_Lista.Vuelto = Variables_Lista.MontoPagaCliente - Variables_Lista.MontoPagar;

            if (Variables_Lista.MontoPagaCliente < Variables_Lista.MontoPagar)
            {
                Console.WriteLine("El monto paga cliente no puede ser menor al monto a pagar.");
                return;
            }

            this.Variables_Lista[count] = Variables_Lista;
            count++;

            Console.WriteLine($"Pago realizado con éxito. Número de Pago: {Variables_Lista.NumeroPago}");
        }

        public void ModificarPagos()
        {
            Console.WriteLine("Ingrese el número de pago a modificar:");
            int num = int.Parse(Console.ReadLine());
            bool pagoEncontrado = false;

            for (int i = 0; i < count; i++)
            {
                if (Variables_Lista[i].NumeroPago == num)
                {
                    pagoEncontrado = true;
                    Variables_Lista Dato_Arreglo = Variables_Lista[i];
                    Console.Clear();
                    Console.WriteLine($"\nNúmero de Pago: {Dato_Arreglo.NumeroPago},\n Fecha: {Dato_Arreglo.Fecha}, \nHora: {Dato_Arreglo.Hora}, " +
                        $"\nCédula: {Dato_Arreglo.Cedula},\n Nombre: {Dato_Arreglo.Nombre},\n Apellido: {Dato_Arreglo.Apellido1}," +
                        $"\n Apellido2: {Dato_Arreglo.Apellido2},\n Número de Caja: {Dato_Arreglo.NumeroCaja},\n Tipo de Servicio: {Dato_Arreglo.TipoServicio}, " +
                        $"\n Número de Factura: {Dato_Arreglo.NumeroFactura},\n Monto a Pagar: {Dato_Arreglo.MontoPagar},\n Monto Comisión: {Dato_Arreglo.MontoComision}," +
                        $" \n Monto Deducido: {Dato_Arreglo.MontoDeducido},\n Monto Paga Cliente: {Dato_Arreglo.MontoPagaCliente},\n Vuelto: {Dato_Arreglo.Vuelto}");

                    bool modificar = true;
                    while (modificar)
                    {
                        Console.WriteLine("\n---------------Seleccione el campo a modificar:---------------");
                        Console.WriteLine("1. Cédula");
                        Console.WriteLine("2. Nombre");
                        Console.WriteLine("3. Primer Apellido");
                        Console.WriteLine("4. Segundo Apellido");
                        Console.WriteLine("5. Tipo de Servicio");
                        Console.WriteLine("6. Número de Factura");
                        Console.WriteLine("7. Monto a Pagar");
                        Console.WriteLine("8. Monto Paga Cliente");
                        Console.WriteLine("9. Salir");
                        int opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Ingrese la nueva cédula:");
                                Dato_Arreglo.Cedula = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el nuevo nombre:");
                                Dato_Arreglo.Nombre = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el nuevo primer apellido:");
                                Dato_Arreglo.Apellido1 = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Ingrese el nuevo segundo apellido:");
                                Dato_Arreglo.Apellido2 = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Ingrese el nuevo tipo de servicio (1= Recibo de Luz, 2= Recibo Teléfono, 3= Recibo de Agua):");
                                Dato_Arreglo.TipoServicio = int.Parse(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Ingrese el nuevo número de factura:");
                                Dato_Arreglo.NumeroFactura = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Ingrese el nuevo monto a pagar:");
                                Dato_Arreglo.MontoPagar = decimal.Parse(Console.ReadLine());
                                break;
                            case 8:
                                Console.WriteLine("Ingrese el nuevo monto paga cliente:");
                                Dato_Arreglo.MontoPagaCliente = decimal.Parse(Console.ReadLine());
                                break;
                            case 9:
                                modificar = false;
                                break;
                            default:
                                Console.WriteLine("Opción inválida. Por favor, intente de nuevo.");
                                break;
                        }
                       
                        if (opcion == 7 || opcion == 8)
                        {
                            Dato_Arreglo.MontoComision = Dato_Arreglo.MontoPagar * 0.05m; 
                            Dato_Arreglo.MontoDeducido = Dato_Arreglo.MontoPagar - Dato_Arreglo.MontoComision;
                            Dato_Arreglo.Vuelto = Dato_Arreglo.MontoPagaCliente - Dato_Arreglo.MontoPagar;
                            if (Dato_Arreglo.MontoPagaCliente < Dato_Arreglo.MontoPagar)
                            {
                                Console.WriteLine("El monto paga cliente no puede ser menor al monto a pagar.");
                                modificar = false;
                            }
                        }

                        Variables_Lista[i] = Dato_Arreglo; 
                    }

                    Console.WriteLine("Datos modificados con éxito.");
                    break;
                }
            }

            if (!pagoEncontrado)
            {
                Console.WriteLine("Pago no se encuentra registrado.");
            }
        }
        public void EliminarPagos()
        {
            try
            {
                Console.WriteLine("Ingrese el número de pago a eliminar:");
                int num = int.Parse(Console.ReadLine());
                bool pagoEncontrado = false;

                for (int i = 0; i < count; i++)
                {
                    if (Variables_Lista[i].NumeroPago == num)
                    {
                        pagoEncontrado = true;
                        Variables_Lista Dato_Arreglo = Variables_Lista[i];
                        Console.Clear();
                        Console.WriteLine($"\nNúmero de Pago: {Dato_Arreglo.NumeroPago},\n Fecha: {Dato_Arreglo.Fecha}, \nHora: {Dato_Arreglo.Hora}, " +
                             $"\nCédula: {Dato_Arreglo.Cedula},\n Nombre: {Dato_Arreglo.Nombre},\n Apellido: {Dato_Arreglo.Apellido1}," +
                             $"\n Apellido2: {Dato_Arreglo.Apellido2},\n Número de Caja: {Dato_Arreglo.NumeroCaja},\n Tipo de Servicio: {Dato_Arreglo.TipoServicio}, " +
                             $"\n Número de Factura: {Dato_Arreglo.NumeroFactura},\n Monto a Pagar: {Dato_Arreglo.MontoPagar},\n Monto Comisión: {Dato_Arreglo.MontoComision}," +
                             $" \n Monto Deducido: {Dato_Arreglo.MontoDeducido},\n Monto Paga Cliente: {Dato_Arreglo.MontoPagaCliente},\n Vuelto: {Dato_Arreglo.Vuelto}");

                        Console.WriteLine("¿Está seguro de eliminar el dato (S/N)?");
                        string confirmacion = Console.ReadLine().ToUpper();

                        if (confirmacion == "S")
                        {
                            for (int j = i; j < count - 1; j++)
                            {
                                Variables_Lista[j] = Variables_Lista[j + 1];
                            }

                            Variables_Lista[count - 1] = new Variables_Lista();
                            count--;

                            Console.WriteLine("La información ya fue eliminada.");
                        }
                        else
                        {
                            Console.WriteLine("La información no fue eliminada.");
                        }
                        break;
                    }
                }

                if (!pagoEncontrado)
                {
                    Console.WriteLine("Pago no se encuentra registrado.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar un número para el número de pago.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }

        public void ConsultarPagos()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ingrese el número de pago a consultar:");
                int numeroPago;
                if (!int.TryParse(Console.ReadLine(), out numeroPago))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    continue;
                }

                var pago = BuscarPago(numeroPago);

                if (pago != null)
                {
                    Console.WriteLine("Detalles del pago:");
                    Console.WriteLine($"Número de Pago: {pago.NumeroPago}");
                    Console.WriteLine($"Fecha: {pago.Fecha:dd/MM/yyyy}");
                    Console.WriteLine($"Hora: {pago.Hora}");
                    Console.WriteLine($"Cédula: {pago.Cedula}");
                    Console.WriteLine($"Nombre: {pago.Nombre}");
                    Console.WriteLine($"Primer Apellido: {pago.Apellido1}");
                    Console.WriteLine($"Segundo Apellido: {pago.Apellido2}");
                    Console.WriteLine($"Número de Caja: {pago.NumeroCaja}");
                    Console.WriteLine($"Tipo de Servicio: {ObtenerNombreTipoServicio(pago.TipoServicio)}");
                    Console.WriteLine($"Número de Factura: {pago.NumeroFactura}");
                    Console.WriteLine($"Monto a Pagar: {pago.MontoPagar}");
                    Console.WriteLine($"Monto Comisión: {pago.MontoComision}");
                    Console.WriteLine($"Paga con: {pago.MontoPagaCliente}");
                    Console.WriteLine($"Monto Deducido: {pago.MontoDeducido}");
                    Console.WriteLine($"Vuelto: {pago.Vuelto}");
                }
                else
                {
                    Console.WriteLine("Pago no se encuentra registrado");
                }

                continuar = PreguntarSiDeseaContinuar();
            }
        }

        private Variables_Lista BuscarPago(int numeroPago)
        {
            foreach (var pago in Variables_Lista)
            {
                if (pago.NumeroPago == numeroPago)
                {
                    return pago;
                }
            }
            return null;
        }

        private string ObtenerNombreTipoServicio(int tipoServicio)
        {
            switch (tipoServicio)
            {
                case 1:
                    return "Recibo de Luz";
                case 2:
                    return "Recibo de Teléfono";
                case 3:
                    return "Recibo de Agua";
                default:
                    return "Tipo de Servicio Desconocido";
            }
        }

        static bool PreguntarSiDeseaContinuar()
{
    while (true)
    {
        Console.WriteLine("¿Desea continuar? (S/N)");
        string respuesta = Console.ReadLine().Trim().ToUpper();

        if (respuesta == "S")
        {
            return true;
        }
        else if (respuesta == "N")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Respuesta no válida. Por favor, ingrese 'S' para sí o 'N' para no.");
        }
    }
}

public void VerTodosLosPagos()
        {
            Console.Clear();
            Console.WriteLine("Sistema Pago de Servicios Publicos");
            Console.WriteLine("Tienda La Favorita - Reporte Todos los Pagos");
            Console.WriteLine();
            Console.WriteLine("# Pago  Fecha        Hora     Cédula   Nombre   Apellido 1  Apellido 2  Monto Recibo");
            Console.WriteLine("====================================================================================");

            decimal montoTotal = 0;

            for (int i = 0; i < count; i++)
            {
                Variables_Lista Dato_Arreglo = Variables_Lista[i];
                Console.WriteLine($"{Dato_Arreglo.NumeroPago,-7} {Dato_Arreglo.Fecha:dd/MM/yyyy}  {Dato_Arreglo.Hora,-8} {Dato_Arreglo.Cedula,-8} " +
                    $"{Dato_Arreglo.Nombre,-7} {Dato_Arreglo.Apellido1,-9} {Dato_Arreglo.Apellido2,-9} {Dato_Arreglo.MontoPagar,10}");
                montoTotal += Dato_Arreglo.MontoPagar;
            }

            Console.WriteLine("======================================================================================");
            Console.WriteLine($"Total de Registros  {count,-3}                             Monto Total {montoTotal,10}");
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para ver Registro");
            Console.ReadKey();
        }

        public void VerPagosPorTipoDeServicio()
        {
            Console.Clear();
            Console.WriteLine("Pagos por Tipo de Servicio:");
            Console.WriteLine();

            var tiposDeServicio = new Dictionary<int, string>
    {
        { 1, "Recibo de Luz" },
        { 2, "Recibo de Teléfono" },
        { 3, "Recibo de Agua" }
    };

            foreach (var tipo in tiposDeServicio)
            {
                Console.WriteLine($"Tipo de Servicio: {tipo.Value}");
                Console.WriteLine("# Pago  Fecha        Hora     Cédula   Nombre   Apellido 1  Apellido 2   Monto Recibo");
                Console.WriteLine("=====================================================================================");

                for (int i = 0; i < count; i++)
                {
                    if (Variables_Lista[i].TipoServicio == tipo.Key)
                    {
                        Variables_Lista Dato_Arreglo = Variables_Lista[i];
                        Console.WriteLine($"{Dato_Arreglo.NumeroPago,-7} {Dato_Arreglo.Fecha:dd/MM/yyyy}  {Dato_Arreglo.Hora,-8} {Dato_Arreglo.Cedula,-8} " +
                            $"{Dato_Arreglo.Nombre,-7} {Dato_Arreglo.Apellido1,-9} {Dato_Arreglo.Apellido2,-9} {Dato_Arreglo.MontoPagar,10}");
                    }
                }

                Console.WriteLine("======================================================================================");
                Console.WriteLine();
            }
        }

        public void VerPagosPorCodigoDeCaja()
        {
            Console.Clear();
            Console.WriteLine("Pagos por Código de Caja:");
            Console.WriteLine();

            for (int caja = 1; caja <= 3; caja++)
            {
                Console.WriteLine($"Código de Caja: {caja}");
                Console.WriteLine("# Pago  Fecha        Hora     Cédula   Nombre   Apellido 1  Apellido 2  Monto Recibo");
                Console.WriteLine("====================================================================================");

                for (int i = 0; i < count; i++)
                {
                    if (Variables_Lista[i].NumeroCaja == caja)
                    {
                        Variables_Lista Dato_Arreglo = Variables_Lista[i];
                        Console.WriteLine($"{Dato_Arreglo.NumeroPago,-7} {Dato_Arreglo.Fecha:dd/MM/yyyy}  {Dato_Arreglo.Hora,-8} {Dato_Arreglo.Cedula,-8} " +
                            $"{Dato_Arreglo.Nombre,-7} {Dato_Arreglo.Apellido1,-9} {Dato_Arreglo.Apellido2,-9} {Dato_Arreglo.MontoPagar,10}");
                    }
                }

                Console.WriteLine("======================================================================================");
                Console.WriteLine();
            }
        }

        public void VerDineroComisionadoPorServicios()
        {
            Console.Clear();
            Console.WriteLine("Dinero Comisionado por Tipo de Servicio:");
            Console.WriteLine();

            var tiposDeServicio = new Dictionary<int, string>
    {
        { 1, "Recibo de Luz" },
        { 2, "Recibo de Teléfono" },
        { 3, "Recibo de Agua" }
    };

            foreach (var tipo in tiposDeServicio)
            {
                decimal totalComisionado = 0;

                for (int i = 0; i < count; i++)
                {
                    if (Variables_Lista[i].TipoServicio == tipo.Key)
                    {
                        totalComisionado += Variables_Lista[i].MontoComision;
                    }
                }

                Console.WriteLine($"{tipo.Value}: {totalComisionado:C}");
            }

            Console.WriteLine("======================================================================================");
            Console.WriteLine();
        }

    }
}
