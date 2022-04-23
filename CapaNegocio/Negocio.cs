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

        public String N_cliente(Entidad objc)
        {
            return datos.D_gestioncliente(objc);

        }
        public DataTable N_listarcli()
        {
            return datos.D_listarcliente();
        }

        public DataTable N_buscarCliente(Entidad objeBC)
        {
            return datos.D_buscarcliente(objeBC);


        }

        public String N_gestionProducto(Entidad objp)
        {
            return datos.D_gestionproducto(objp);

        }

        public DataTable N_listarpro()
        {
            return datos.D_listarproducto();
        }

        public DataTable N_cargarboxcli()
        {

            return datos.D_CargarCli();
        }

        public DataTable N_cargarboxPro()
        {

            return datos.D_CargarPro();
        }

        public DataTable N_cargarVen()
        {

            return datos.D_CargarVen();
        }

        public String N_gestionFactura(Entidad objf)
        {
            return datos.D_gestionfactura(objf);

        }

        public DataTable N_listarFactura()
        {
            return datos.D_listarFactura();
        }

        public DataTable N_buscarFactura(Entidad ObjetoBF)
        {
            return datos.D_buscarFactura(ObjetoBF);

        }

        public DataTable N_buscarFacturaCli(Entidad ObjetoBFC)
        {
            return datos.D_buscarFacturaCli(ObjetoBFC);

        }

        public String inventario(Entidad entidad)
        {
            return datos.Inventario(entidad);

        }


    }
}
