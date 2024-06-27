using System;

namespace ProyectoUnoServicios
{
    public class Variables_Lista
    {
        public int NumeroPago { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int NumeroCaja { get; set; }
        public int TipoServicio { get; set; }
        public string NumeroFactura { get; set; }
        public decimal MontoPagar { get; set; }
        public decimal MontoComision { get; set; }
        public decimal MontoDeducido { get; set; }
        public decimal MontoPagaCliente { get; set; }
        public decimal Vuelto { get; set; }
    }
}