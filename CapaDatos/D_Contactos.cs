using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Contactos : D_Base
    {
        // GetAll Metodo
        public DataTable GetAll()
        {
            oCnn.ConnectionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            oDA = new SqlDataAdapter("SELECT * FROM Contactos ORDER BY Nombre", oCnn);
            oDT = new DataTable("Contactos");
            oCnn.Open();
            oDA.Fill(oDT);
            oCnn.Close();
            return oDT;
        }

        // GetById Metodo
        public E_Contactos GetById(int Id)
        {
            E_Contactos oContacto = new E_Contactos();
            oCnn.ConnectionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            oDA = new SqlDataAdapter(oCmd);
            oDT = new DataTable("Contactos");
            oCnn.Open();
            oCmd.Connection = oCnn;
            oCmd.CommandText = "SELECT * FROM Contactos WHERE Id = @Id";
            oCmd.Parameters.Clear();
            oCmd.Parameters.AddWithValue("@Id", Id);
            oDA.Fill(oDT);

            if (oDT.Rows.Count > 0)
            {
                oContacto.Id = Convert.ToInt32(oDT.Rows[0]["Id"]);
                oContacto.Nombre = oDT.Rows[0]["Nombre"].ToString();
                oContacto.Direccion = oDT.Rows[0]["Direccion"].ToString();
                oContacto.Celular = oDT.Rows[0]["Celular"].ToString();
                oContacto.Email = oDT.Rows[0]["Email"].ToString();
                oContacto.Notas = oDT.Rows[0]["Notas"].ToString();
            }
            else
            {
                oContacto = null;
            }
            oCnn.Close();
            return oContacto;
        }

        // Insert Metodo
        public bool Insert(E_Contactos oContacto)
        {
            oCnn.ConnectionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            oCnn.Open();
            oCmd.Connection = oCnn;
            oCmd.CommandText = "INSERT INTO Contactos (Nombre, Direccion,Celular,Email, Notas) VALUES (@Nombre, @Direccion,@Celular,@Email,@Notas)";
            oCmd.Parameters.Clear();
            oCmd.Parameters.AddWithValue("@Nombre", oContacto.Nombre);
            oCmd.Parameters.AddWithValue("@Direccion", oContacto.Direccion);
            oCmd.Parameters.AddWithValue("@Celular", oContacto.Celular);
            oCmd.Parameters.AddWithValue("@Email", oContacto.Direccion);
            oCmd.Parameters.AddWithValue("@Notas", oContacto.Notas);
            oCmd.ExecuteNonQuery();
            oCnn.Close();
            return true;
        }

        // Update metodo
        public bool Update(E_Contactos oContacto)
        {
            oCnn.ConnectionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            oCnn.Open();
            oCmd.Connection = oCnn;
            oCmd.CommandText = "UPDATE Contactos  SET Nombre = @Nombre, Direccion = @Direccion , Celular = @Celular, Email = @Email, Notas = @Notas  WHERE Id = @Id";
            oCmd.Parameters.Clear();
            oCmd.Parameters.AddWithValue("@Id", oContacto.Id);
            oCmd.Parameters.AddWithValue("@Nombre", oContacto.Nombre);
            oCmd.Parameters.AddWithValue("@Direccion", oContacto.Direccion);
            oCmd.Parameters.AddWithValue("@Celular", oContacto.Celular);
            oCmd.Parameters.AddWithValue("@Email", oContacto.Direccion);
            oCmd.Parameters.AddWithValue("@Notas", oContacto.Notas);
            oCmd.ExecuteNonQuery();
            oCnn.Close();
            return true;
        }

        // Delete metodo
        public bool Delete(int Id)
        {
            oCnn.ConnectionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            oCnn.Open();
            oCmd.Connection = oCnn;
            oCmd.CommandText = "DELETE FROM Contactos WHERE Id = @Id";
            oCmd.Parameters.Clear();
            oCmd.Parameters.AddWithValue("@Id", Id);
            oCmd.ExecuteNonQuery();
            oCnn.Close();
            return true;
        }
    }
}

