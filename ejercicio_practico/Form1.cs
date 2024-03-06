using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_practico
{
    public partial class Form1 : Form
    {

        private List<Estudiante> estudiante = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
         
        }


        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = false;
            btn_Agregar.Enabled = true;
            btn_Guardar.Enabled = true;
            btn_Limpiar.Enabled = true;
            btn_Salir.Enabled = true;
            btn_Eliminar.Enabled = false;
        }

        private void txt_Matricula_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Registros.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int fila;
                fila = dgv_Registros.CurrentRow.Index;
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Seguro que desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dgv_Registros.Rows.RemoveAt(fila);
                    MessageBox.Show("El registro ha sido eliminado");
                }
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Matricula.Clear();
            txt_Nombre.Clear();
            txt_Direccion.Clear();
            txt_Telefono.Clear();
            txt_Email.Clear();
            cbo_Curso.Items.Clear();
            cbo_Seccion.Items.Clear();
            cbo_Area.Items.Clear();
            txt_MaestroTitular.Clear();
        }



        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;
            Respuesta = MessageBox.Show("¿Seguro que desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            string genero = rb_Femenino.Checked ? "Femenino" : "Masculino";
            dgv_Registros.Rows.Add(txt_Matricula.Text, txt_Nombre.Text, txt_Direccion.Text,
            txt_Telefono.Text, genero, txt_Email.Text, cbo_Curso.Text, cbo_Seccion.Text,
            cbo_Area.Text, txt_MaestroTitular.Text);

            txt_Matricula.Focus();
            txt_Matricula.Clear();
            txt_Nombre.Clear();
            txt_Direccion.Clear();
            txt_Telefono.Clear();
            txt_Email.Clear();
            cbo_Curso.Items.Clear();
            cbo_Seccion.Items.Clear();
            cbo_Area.Items.Clear();
            txt_MaestroTitular.Clear();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Limpiar.Enabled = true;
            btn_Salir.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Nuevo.Enabled = true;

            DialogResult resultado = sfd_Guardar.ShowDialog();


            if (resultado == DialogResult.OK)
            {

                string ruta_archivo = sfd_Guardar.FileName;
                string crea_texto = ruta_archivo;


                using (StreamWriter archivo = File.CreateText(ruta_archivo))
                {
                    foreach (DataGridViewRow fila in dgv_Registros.Rows)
                    {
                        string valorColumna1 = fila.Cells[0].Value?.ToString() ?? "";
                        string valorColumna2 = fila.Cells[1].Value?.ToString() ?? "";
                        string valorColumna7 = fila.Cells[7].Value?.ToString() ?? "";
                        string valorColumna8 = fila.Cells[8].Value?.ToString() ?? "";
                        string valorColumna9 = fila.Cells[9].Value?.ToString() ?? "";

                        archivo.WriteLine($"{valorColumna1},{valorColumna2},{valorColumna7},{valorColumna8},{valorColumna9}");
                    }
                }
            }
        }

        public class Estudiante
        {
            public string Matricula { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Genero { get; set; }
            public string Email { get; set; }
            public string Curso { get; set; }
            public string Seccion { get; set; }
            public string AreaTecnica { get; set; }
            public string MaestroTitular { get; set; }

            public Estudiante(string matricula, string nombre, string direccion, string telefono, string genero, string email, string curso, string seccion, string areaTecnica, string maestro)
            {
                Matricula = matricula;
                Nombre = nombre;
                Direccion = direccion;
                Telefono = telefono;
                Genero = genero;
                Email = email;
                Curso = curso;
                Seccion = seccion;
                AreaTecnica = areaTecnica;
                MaestroTitular = maestro;
            }
        }
    }
}


   