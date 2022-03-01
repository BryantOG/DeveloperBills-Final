using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidad;


namespace CapaNegocio
{
    public class Negocio
    {
        Datos datos = new Datos();
        public String N_gestionEmpleado(Entidad obje3)
        {
            return datos.D_gestionempleado(obje3);

        }

        public DataTable N_listarEmp()
        {
            return datos.D_listarEmp();
        }

        public DataTable N_buscarempleado(Entidad objeBP)
        {
            return datos.D_buscarempleado(objeBP);


        }
    }
}
