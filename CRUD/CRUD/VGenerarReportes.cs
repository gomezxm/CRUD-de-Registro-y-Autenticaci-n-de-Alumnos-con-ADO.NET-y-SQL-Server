using Microsoft.Data.SqlClient;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class VGenerarReportes : Form
    {
        public VGenerarReportes()
        {
            InitializeComponent();
            CargarEstudiantesEnListBox();
        }

        // ===============================================
        // MÉTODO PRINCIPAL PARA CARGAR ESTUDIANTES
        // ===============================================
        private void CargarEstudiantesEnListBox()
        {
            try
            {
                // Limpiar el ListBox
                lsb_Estudiante.Items.Clear();

                // Configurar el ListBox para mostrar objetos personalizados
                lsb_Estudiante.DisplayMember = "Nombre";
                lsb_Estudiante.ValueMember = "Id";

                using (var conn = new SqlConnection(connString)) // HAZ LA CONEXION AQUI
                {
                    conn.Open();

                    // Query para obtener estudiantes ordenados alfabéticamente
                    string query = @"
                        SELECT 
                            Id, 
                            Nombre,
                            Cedula,
                            Carrera
                        FROM Alumnos 
                        ORDER BY Nombre ASC";

                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            // Crear objeto estudiante
                            var estudiante = new Estudiante
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Cedula = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                Carrera = reader.IsDBNull(3) ? "" : reader.GetString(3)
                            };

                            // Agregar al ListBox
                            lsb_Estudiante.Items.Add(estudiante);
                            count++;
                        }

                        // Mostrar mensaje informativo
                        if (count == 0)
                        {
                            MessageBox.Show("No hay estudiantes registrados en la base de datos.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Opcional: mostrar cuántos estudiantes se cargaron
                            // lblTotalEstudiantes.Text = $"Total: {count} estudiantes";
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de conexión a la base de datos:\n{sqlEx.Message}",
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ===============================================
        // MÉTODO PARA BUSCAR ESTUDIANTE POR NOMBRE
        // ===============================================
        private void BuscarEstudiantePorNombre(string nombreBuscar)
        {
            try
            {
                lsb_Estudiante.Items.Clear();
                lsb_Estudiante.DisplayMember = "Nombre";
                lsb_Estudiante.ValueMember = "Id";

                using (var conn = new SqlConnection(connString)) // HAZ LA CONEXION
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            Id, 
                            Nombre,
                            Cedula,
                            Carrera
                        FROM Alumnos 
                        WHERE Nombre LIKE @Nombre
                        ORDER BY Nombre ASC";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", "%" + nombreBuscar + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                var estudiante = new Estudiante
                                {
                                    Id = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Cedula = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    Carrera = reader.IsDBNull(3) ? "" : reader.GetString(3)
                                };

                                lsb_Estudiante.Items.Add(estudiante);
                                count++;
                            }

                            if (count == 0)
                            {
                                MessageBox.Show($"No se encontraron estudiantes con el nombre '{nombreBuscar}'",
                                    "Búsqueda",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ===============================================
        // OBTENER ESTUDIANTE SELECCIONADO
        // ===============================================
        private Estudiante ObtenerEstudianteSeleccionado()
        {
            if (lsb_Estudiante.SelectedItem != null)
            {
                return (Estudiante)lsb_Estudiante.SelectedItem;
            }
            return null;
        }

        private void CargarDatosIniciales()
        {
            // Cargar carreras en el ComboBox
            cb_porCarrera.Items.Clear();
            cb_porCarrera.Items.Add("Ingenieria software");
            cb_porCarrera.Items.Add("Desarrollo en software");
            cb_porCarrera.SelectedIndex = 0;

            // Cargar jornadas
            cb_jornada.Items.Clear();
            cb_jornada.Items.Add("Matutina");
            cb_jornada.Items.Add("Vespertina");
            cb_jornada.SelectedIndex = 0;

            // Cargar estudiantes en el ListBox
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            lsb_Estudiante.Items.Clear();
            lsb_Estudiante.DisplayMember = "Nombre";
            lsb_Estudiante.ValueMember = "Id";

            using (var conn = new SqlConnection(connString)) // Conecta la base de dato aqui
            {
                conn.Open();
                string query = "SELECT Id, Nombre FROM Alumnos ORDER BY Nombre";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lsb_Estudiante.Items.Add(new
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        });
                    }
                }
            }
        }



        private void Lb_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void VGenerarReportes_Load(object sender, EventArgs e)
        {

        }

        private DataTable ObtenerDatosAlumnos(string jornada)
        {
            var dt = new DataTable("Alumnos");
            string connString = "Server=tu_servidor;Database=tu_base_datos;User Id=usuario;Password=pass;"; // ni idea, miguel hazlo tuyo

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = @"
            SELECT 
                Id,
                Nombre,
                Cedula,
                Carrera,
                Semestre,
                Jornada,
                Usuario,
                CASE WHEN RecibirNotificaciones = 1 THEN 'Sí' ELSE 'No' END as Notificaciones,
                FechaRegistro
            FROM Alumnos
            WHERE (@Jornada = 'Todas' OR Jornada = @Jornada)
            ORDER BY FechaRegistro DESC";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Jornada", jornada);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }



        private void bt_PorCarrera_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Cargar la plantilla MRT
                var report = new StiReport();
                report.Load("C:\\Users\\gerad\\OneDrive\\Escritorio\\LaboratorioCRUD\\CRUD-de-Registro-y-Autenticaci-n-de-Alumnos-con-ADO.NET-y-SQL-Server\\CRUD\\CRUD\\Reportes\\ReportePrueba.mrt");

                // No necesita datos, solo renderizar y mostrar
                report.Compile();
                report.Render(false);
                report.Show();

                MessageBox.Show("✅ Reporte generado exitosamente!", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("❌ No se encontró el archivo ReportePrueba.mrt\n\n" +
                               "Asegúrate de guardarlo en la misma carpeta del ejecutable.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al generar el reporte:\n\n{ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lb_General_Estuidante_Click(object sender, EventArgs e)
        {

        }

        private void bt_GeneralEstudiante_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Cargar la plantilla MRT
                var report = new StiReport();
                report.Load("ReporteAlumnos.mrt");

                // Obtener datos de la base de datos
                string jornadaFiltro = cmbJornada.SelectedItem?.ToString() ?? "Todas";
                DataTable dt = ObtenerDatosAlumnos(jornadaFiltro);

                // Registrar el DataSet en el reporte
                report.RegData("Data", dt);
                report.Dictionary.Synchronize();

                // Asignar el parámetro
                report.Dictionary.Variables["Jornada"].Value = jornadaFiltro;

                // Renderizar y mostrar
                report.Compile();
                report.Render(false);
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_porCarrera_Click_1(object sender, EventArgs e)
        {

            string carrera = cb_porCarrera.SelectedItem.ToString();
            GenerarReportePorCarrera(carrera);
        }

        private void GenerarReportePorCarrera(string carrera)
        {
            try
            {
                // Crear reporte
                var report = new StiReport();

                // Cargar plantilla (crear el archivo .mrt primero)
                report.Load("ReportePorCarrera.mrt");

                // Obtener datos
                DataTable dt = ObtenerDatosPorCarrera(carrera);

                // Registrar dataset
                report.RegData("Alumnos", dt);
                report.Dictionary.Synchronize();

                // Pasar parámetros
                report.Dictionary.Variables["Carrera"].Value = carrera;
                report.Dictionary.Variables["FechaGeneracion"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                // Renderizar y mostrar
                report.Render(false);
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerDatosPorCarrera(string carrera)
        {
            var dt = new DataTable("Alumnos");

            using (var conn = new SqlConnection(connString)) // HAZ LA CONEXION AQUI
            {
                conn.Open();

                string query = @"
                    SELECT 
                        Id,
                        Nombre,
                        Cedula,
                        Carrera,
                        Semestre,
                        Jornada,
                        Usuario,
                        CASE WHEN RecibirNotificaciones = 1 THEN 'Sí' ELSE 'No' END as Notificaciones,
                        FechaRegistro
                    FROM Alumnos
                    WHERE Carrera = @Carrera
                    ORDER BY Nombre";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Carrera", carrera);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        private void bt_Jornada_Click(object sender, EventArgs e)
        {
            string jornada = cb_jornada.SelectedItem.ToString();
            GenerarReportePorJornada(jornada);
        }

        private void GenerarReportePorJornada(string jornada)
        {
            try
            {
                var report = new StiReport();
                report.Load("ReportePorJornada.mrt");

                DataTable dt = ObtenerDatosPorJornada(jornada);

                report.RegData("Alumnos", dt);
                report.Dictionary.Synchronize();

                report.Dictionary.Variables["Jornada"].Value = jornada;
                report.Dictionary.Variables["FechaGeneracion"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                report.Render(false);
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerDatosPorJornada(string jornada)
        {
            var dt = new DataTable("Alumnos");

            using (var conn = new SqlConnection(connString)) // HAZ LA CONEXION AQUI
            {
                conn.Open();

                string query = @"
                    SELECT 
                        Id,
                        Nombre,
                        Cedula,
                        Carrera,
                        Semestre,
                        Jornada,
                        Usuario,
                        CASE WHEN RecibirNotificaciones = 1 THEN 'Sí' ELSE 'No' END as Notificaciones,
                        FechaRegistro
                    FROM Alumnos
                    WHERE Jornada = @Jornada
                    ORDER BY Jornada, Carrera, Nombre";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Jornada", jornada);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }



        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarEstudiantesEnListBox();
            MessageBox.Show("Lista de estudiantes actualizada.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void bt_AlumSelecionado_Click(object sender, EventArgs e)
        {
            dynamic estudiante = lsb_Estudiante.SelectedItem;
            int idEstudiante = estudiante.Id;

            GenerarReportePerfilAlumno(idEstudiante);
        }

        private void GenerarReportePerfilAlumno(int idEstudiante)
        {
            try
            {
                var report = new StiReport();
                report.Load("ReportePerfilAlumno.mrt");

                DataTable dt = ObtenerDatosAlumno(idEstudiante);

                report.RegData("Alumno", dt);
                report.Dictionary.Synchronize();

                report.Dictionary.Variables["IdAlumno"].Value = idEstudiante.ToString();
                report.Dictionary.Variables["FechaGeneracion"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                report.Render(false);
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerDatosAlumno(int idEstudiante)
        {
            var dt = new DataTable("Alumno");

            using (var conn = new SqlConnection(connString)) // HAZ LA CONEXION AQUI    
            {
                conn.Open();

                string query = @"
                    SELECT 
                        Id,
                        Nombre,
                        Cedula,
                        Carrera,
                        Semestre,
                        Jornada,
                        Usuario,
                        CASE WHEN RecibirNotificaciones = 1 THEN 'Sí' ELSE 'No' END as Notificaciones,
                        FechaRegistro,
                        CONVERT(VARCHAR, FechaRegistro, 103) as FechaRegistroFormato
                    FROM Alumnos
                    WHERE Id = @Id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idEstudiante);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
