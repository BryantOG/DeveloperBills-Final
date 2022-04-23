using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidad;


namespace CapaDatos
{
    public class Datos
    {

        SqlConnection conecta = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        //Gestion empleado


        public String D_gestionempleado(Entidad objeto3)
        {
            String accion = "";
            SqlCommand sql3 = new SqlCommand("sp_Empleados", conecta);
            sql3.CommandType = CommandType.StoredProcedure;
            sql3.Parameters.AddWithValue("@CedulaE", objeto3.CedulaE);
            sql3.Parameters.AddWithValue("@NombreE", objeto3.NombreE);
            sql3.Parameters.AddWithValue("@ApellidoE", objeto3.ApellidoE);
            sql3.Parameters.AddWithValue("@TelefonoE", objeto3.CelE);
            sql3.Parameters.AddWithValue("@DepartamentoE", objeto3.DepartamentoE);
            sql3.Parameters.AddWithValue("@CorreE", objeto3.CorreE);
            sql3.Parameters.Add("@accionE", SqlDbType.VarChar, 50).Value = objeto3.accion;
            sql3.Parameters["@accionE"].Direction = ParameterDirection.InputOutput;
            if (conecta.State == ConnectionState.Open) conecta.Close();
            conecta.Open();
            sql3.ExecuteNonQuery();
            accion = sql3.Parameters["@accionE"].Value.ToString();
            conecta.Close();
            return accion;

        }

        public DataTable D_listarEmp()
        {
            SqlCommand cmd2 = new SqlCommand("sp_listarEmp", conecta);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            return dt2;
        }

        public DataTable D_buscarempleado(Entidad ObjetoBP)
        {
            SqlCommand c = new SqlCommand("sp_buscarempleado", conecta);
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.AddWithValue("@CedulaE", ObjetoBP.CedulaE);
            SqlDataAdapter d = new SqlDataAdapter(c);
            DataTable dataTable = new DataTable();
            d.Fill(dataTable);
            return dataTable;

        }


        //Gestion del cliente
        public String D_gestioncliente(Entidad objc)
        {
            String accion = "";
            SqlCommand sql4 = new SqlCommand("sp_Cliente", conecta);
            sql4.CommandType = CommandType.StoredProcedure;
            sql4.Parameters.AddWithValue("@CedulaC", objc.CedulaC);
            sql4.Parameters.AddWithValue("@NombresC", objc.NombreC);
            sql4.Parameters.AddWithValue("@ApellidosC", objc.ApellidoC);
            sql4.Parameters.AddWithValue("@TelefonoC", objc.CelC);
            sql4.Parameters.AddWithValue("@DireccionC", objc.DireccionC);
            sql4.Parameters.AddWithValue("@CorreoC", objc.CorreoC);
            sql4.Parameters.Add("@accionC", SqlDbType.VarChar, 50).Value = objc.accion;
            sql4.Parameters["@accionC"].Direction = ParameterDirection.InputOutput;
            if (conecta.State == ConnectionState.Open) conecta.Close();
            conecta.Open();
            sql4.ExecuteNonQuery();
            accion = sql4.Parameters["@accionC"].Value.ToString();
            conecta.Close();
            return accion;
        }

        public DataTable D_listarcliente()
        {
            SqlCommand cmd2 = new SqlCommand("sp_listarCliente", conecta);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            return dt2;
        }

        public DataTable D_buscarcliente(Entidad ObjetoBC)
        {
            SqlCommand c = new SqlCommand("sp_buscarCliente", conecta);
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.AddWithValue("@CedulaC", ObjetoBC.CedulaC);
            SqlDataAdapter d = new SqlDataAdapter(c);
            DataTable dataTable = new DataTable();
            d.Fill(dataTable);
            return dataTable;

        }

        //Gestion Producto
        public String D_gestionproducto(Entidad objp)
        {
            String accion = "";
            SqlCommand sql4 = new SqlCommand("sp_productos", conecta);
            sql4.CommandType = CommandType.StoredProcedure;
            sql4.Parameters.AddWithValue("@Codigo_producto", objp.CodigoP);
            sql4.Parameters.AddWithValue("@NombresP", objp.NombreP);
            sql4.Parameters.AddWithValue("@DetallesP", objp.DetalleP);
            sql4.Parameters.AddWithValue("@PrecioP", objp.PrecioP);
            sql4.Parameters.AddWithValue("@CantidadP", objp.CantidadP);
            sql4.Parameters.Add("@accionP", SqlDbType.VarChar, 50).Value = objp.accion;
            sql4.Parameters["@accionP"].Direction = ParameterDirection.InputOutput;
            if (conecta.State == ConnectionState.Open) conecta.Close();
            conecta.Open();
            sql4.ExecuteNonQuery();
            accion = sql4.Parameters["@accionP"].Value.ToString();
            conecta.Close();
            return accion;
        }

        public DataTable D_listarproducto()
        {
            SqlCommand cmd2 = new SqlCommand("sp_listarProducto", conecta);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            return dt2;
        }

        //Gestion Factura public String D_gestionproducto(Entidad objp)
        
        public String D_gestionfactura(Entidad objf)
        {
            String accion = "";
            SqlCommand sql4 = new SqlCommand("sp_Factura", conecta);
            sql4.CommandType = CommandType.StoredProcedure;
            sql4.Parameters.AddWithValue("@Codigo_cliente ", objf.IdC);
            sql4.Parameters.AddWithValue("@Nombre_cliente", objf.NombreC2);
            sql4.Parameters.AddWithValue("@Fecha_Factura", objf.FechaF);
            sql4.Parameters.AddWithValue("@Codigo_Producto", objf.CodigoP2);
            sql4.Parameters.AddWithValue("@Nombre_producto", objf.NombreC2);
            sql4.Parameters.AddWithValue("@Detalle_Producto", objf.DetalleP2);
            sql4.Parameters.AddWithValue("@Precio_producto", objf.PreciopP2);
            sql4.Parameters.AddWithValue("@Cantidad_producto ", objf.CantidadP2);
            sql4.Parameters.AddWithValue("@total_producto", objf.totalf);
            sql4.Parameters.AddWithValue("@Codigo_Vendedor", objf.CodigoEm2);
            sql4.Parameters.Add("@accionF", SqlDbType.VarChar, 50).Value = objf.accion;
            sql4.Parameters["@accionF"].Direction = ParameterDirection.InputOutput;
            if (conecta.State == ConnectionState.Open) conecta.Close();
            conecta.Open();
            sql4.ExecuteNonQuery();
            accion = sql4.Parameters["@accionF"].Value.ToString();
            conecta.Close();
            return accion;
        }
    

    public DataTable D_CargarCli()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("sp_cargarClientes", conecta);
            da2.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            return dt2;

        }

        public DataTable D_CargarPro()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("sp_cargarProducto", conecta);
            da2.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            return dt2;

        }

        public DataTable D_CargarVen()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("sp_vendedor", conecta);
            da2.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            return dt2;

        }

        public DataTable D_listarFactura()
        {
            SqlCommand cmd2 = new SqlCommand("sp_listarFactura", conecta);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            return dt2;
        }

        public DataTable D_buscarFactura(Entidad ObjetoBF)
        {
            SqlCommand c = new SqlCommand("sp_buscarFacFec", conecta);
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.AddWithValue("@Fecha", ObjetoBF.FechaF);
            SqlDataAdapter d = new SqlDataAdapter(c);
            DataTable dataTable = new DataTable();
            d.Fill(dataTable);
            return dataTable;

        }

        public DataTable D_buscarFacturaCli(Entidad ObjetoBFC)
        {
            SqlCommand c = new SqlCommand("sp_buscarFacClie", conecta);
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.AddWithValue("@Codigo", ObjetoBFC.IdC);
            SqlDataAdapter d = new SqlDataAdapter(c);
            DataTable dataTable = new DataTable();
            d.Fill(dataTable);
            return dataTable;

        }

        public String Inventario(Entidad entidad)
        {

            String accion = "";
            SqlCommand sql3 = new SqlCommand("sp_inventario", conecta);
            sql3.CommandType = CommandType.StoredProcedure;
            sql3.Parameters.AddWithValue("@CodigoPr", entidad.CodigoP2);
            sql3.Parameters.AddWithValue("@cantidad", entidad.CantidadP);
            sql3.Parameters.Add("@accionI", SqlDbType.VarChar, 50).Value = entidad.accion;
            sql3.Parameters["@accionI"].Direction = ParameterDirection.InputOutput;
            if (conecta.State == ConnectionState.Open) conecta.Close();
            conecta.Open();
            sql3.ExecuteNonQuery();
            accion = sql3.Parameters["@accionI"].Value.ToString();
            conecta.Close();
            return accion;

        
        }

    }
}
