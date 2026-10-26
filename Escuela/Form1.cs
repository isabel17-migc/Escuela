using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices.Marshalling;
using System.Windows.Forms;


namespace Escuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //conctamos los botones con sus eventos
            btnguardar.Click += btnguardar.Click;
            btnmostrar.Click += btnmostrar.Click;
            btnlimpiar.Click += btnlimpiar.Click;
            //consultamos los aalumnos al abrir la ventana
            Load
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarAlumnos();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //validamos que los campos no esten vacios 
            if (string.IsNullOrWhiteSpace(txtmatricula.Text) ||
               string.IsNullOrWhiteSpace(txtnombre.Text) ||
               string.IsNullOrWhiteSpace(txtgrupo.Text) ||
               string.IsNullOrWhiteSpace(txtespecialidad.Text))
            {
                MessageBox.Show(
                    "completa todos los campos antes de aguardar.",
                    "Datos Incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            try
            {
                using (OleDbConnection conexion =
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "INSERT INTO Alumnos" +
                        "(MATRICULA, NOMBRE, SEMESTRE, GRUPO,ESPECIALIDAD)" +
                        "VALUES(?,?,?,?,?)";
                    using (OleDbCommand comando =
                    new OleDbCommand(consulta, conexion))
                    {
                        //con OledDb importa el orden de los parametros
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtmatricula.Text.Trim();

                        comando.Parameters.Add(
                           "?", OleDbType.VarWChar, 20
                           ).Value = txtnombre.Text.Trim();

                        comando.Parameters.Add(
                           "?", OleDbType.VarWChar, 20
                           ).Value = nudsemestre.Value;

                        comando.Parameters.Add(
                           "?", OleDbType.VarWChar, 20
                           ).Value = txtgrupo.Text.Trim();

                        comando.Parameters.Add(
                           "?", OleDbType.VarWChar, 20
                           ).Value = txtespecialidad.Text.Trim();
                        comando.ExecuteNonQuery();

                    }
                }

                {


                }

            }

}
    }   }