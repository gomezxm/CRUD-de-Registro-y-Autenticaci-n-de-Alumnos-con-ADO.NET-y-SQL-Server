using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CRUD
{
    public class EstudianteRepository
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;

        // INSERTAR
        public bool Insertar(string nombre, string cedula, string contrasena, string carrera, string semestre, string jornada)
        {
            using var conn = new SqlConnection(connString);
            string sql = @"INSERT INTO Estudiantes 
                           (Nombre, Contrasena, Cedula, Carrera, Semestre, Jornada)
                           VALUES (@Nombre, @Contrasena, @Cedula, @Carrera, @Semestre, @Jornada)";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Contrasena", contrasena);
            cmd.Parameters.AddWithValue("@Cedula", cedula);
            cmd.Parameters.AddWithValue("@Carrera", carrera);
            cmd.Parameters.AddWithValue("@Semestre", semestre);
            cmd.Parameters.AddWithValue("@Jornada", jornada);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        // LISTAR PARA LISTBOX
        public List<string> ObtenerTodos()
        {
            var lista = new List<string>();
            using var conn = new SqlConnection(connString);
            string sql = "SELECT EstudianteID, Nombre, Carrera, Jornada FROM Estudiantes ORDER BY Nombre";

            using var cmd = new SqlCommand(sql, conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add($"{reader.GetInt32("EstudianteID")} - {reader.GetString("Nombre")} - {reader.GetString("Carrera")} - {reader.GetString("Jornada")}");
            }
            return lista;
        }

        // OBTENER POR ID (para actualizar)
        public DataRow? ObtenerPorId(int id)
        {
            using var conn = new SqlConnection(connString);
            string sql = "SELECT * FROM Estudiantes WHERE EstudianteID = @Id";
            using var adapter = new SqlDataAdapter(sql, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@Id", id);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // ACTUALIZAR
        public bool Actualizar(int id, string nombre, string cedula, string contrasena, string carrera, string semestre, string jornada)
        {
            using var conn = new SqlConnection(connString);
            string sql = @"UPDATE Estudiantes SET 
                           Nombre = @Nombre, Contrasena = @Contrasena, Cedula = @Cedula,
                           Carrera = @Carrera, Semestre = @Semestre, Jornada = @Jornada
                           WHERE EstudianteID = @Id";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Contrasena", contrasena);
            cmd.Parameters.AddWithValue("@Cedula", cedula);
            cmd.Parameters.AddWithValue("@Carrera", carrera);
            cmd.Parameters.AddWithValue("@Semestre", semestre);
            cmd.Parameters.AddWithValue("@Jornada", jornada);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        // ELIMINAR
        public bool Eliminar(int id)
        {
            using var conn = new SqlConnection(connString);
            using var cmd = new SqlCommand("DELETE FROM Estudiantes WHERE EstudianteID = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}