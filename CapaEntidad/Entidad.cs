using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Entidad
    {

        //Tabla empleados
        public string CedulaE { get; set; }
        public string NombreE { get; set; }
        public string ApellidoE { get; set; }
        public string CelE { get; set; }
        public string DepartamentoE { get; set; }
        public string CorreE { get; set; }

        public string accion { get; set; }


        //Tabla Clientes
        public string Id { get; set; }
        public string CedulaC { get; set; }
        public string NombreC { get; set; }
        public string ApellidoC { get; set; }
        public string CelC { get; set; }
        public string DireccionC { get; set; }
        public string CorreoC { get; set; }

        //Tabla productos
        public string CodigoP { get; set; }
        public string NombreP { get; set; }
        public string DetalleP { get; set; }
        public string PrecioP { get; set; }
        public string CantidadP { get; set; }

        //Tabla de facturacion
        public string IdC { get; set; }
        public string NombreC2 { get; set; }
        public string CodigoP2 { get; set; }
        public string NombreP2 { get; set; }
        public string DetalleP2 { get; set; }
        public string PreciopP2 { get; set; }
        public string CantidadP2 { get; set; }
        public string totalf { get; set; }
        public string CodigoEm2 { get; set; }
        public DateTime FechaF { get; set; }

    }
}
