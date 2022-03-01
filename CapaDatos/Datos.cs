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
    }
}
