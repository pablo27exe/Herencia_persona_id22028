using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //labels
            lNombre.Visible = true;
            lFecNac.Visible = true;
            lAge.Visible = true;
            lDni.Visible = true;
            lPuesto.Visible = true;
            lArea.Visible = true;
            lSueldo.Visible = true;

            //Textbox
            tbNombre.Visible = true;
            tbFecha.Visible = true;
            tbEdad.Visible = true;
            tbId.Visible = true;
            tbCarrera.Visible = true;
            tbArea.Visible = true;
            tbSueldo.Visible = true;

            //descativar labels que no son necesarios para este caso
            lMatricula.Visible = false;
            lCarrera.Visible = false;
            lSemestre.Visible = false;
            lMateria.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbFecha.Clear();
            tbEdad.Clear();
            tbId.Clear();
            tbCarrera.Clear();
            tbSueldo.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del programa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void alumno_CheckedChanged(object sender, EventArgs e)
        {
            //labels
            lNombre.Visible = true;
            lFecNac.Visible = true;
            lAge.Visible = true;
            lMatricula.Visible = true;
            lCarrera.Visible = true;
            lSemestre.Visible = true;

            //Textbox
            tbNombre.Visible = true;
            tbFecha.Visible = true;
            tbEdad.Visible = true;
            tbId.Visible = true;
            tbCarrera.Visible = true;
            tbArea.Visible = true;

            //descativar labels que no son necesarios para este caso
            lMateria.Visible = false;
            lDni.Visible = false;
            lPuesto.Visible = false;
            lArea.Visible = false;
            lSueldo.Visible = false;
            tbSueldo.Visible = false;
        }

        private void docente_CheckedChanged(object sender, EventArgs e)
        {
            //labels
            lNombre.Visible = true;
            lFecNac.Visible = true;
            lAge.Visible = true;
            lDni.Visible = true;
            lMateria.Visible = true;
            lSueldo.Visible = true;

            //Textbox
            tbNombre.Visible = true;
            tbFecha.Visible = true;
            tbEdad.Visible = true;
            tbId.Visible = true;
            tbCarrera.Visible = true;
            tbSueldo.Visible = true;

            //descativar labels que no son necesarios para este caso
            lMatricula.Visible = false;
            lPuesto.Visible = false;
            lArea.Visible = false;
            lCarrera.Visible = false;
            lSemestre.Visible = false;
            tbArea.Visible=false;
        }
        private void guardar_Click(object sender, EventArgs e)
        {
                // Verifica si algún TextBox está vacío
                if (string.IsNullOrEmpty(tbNombre.Text) ||
                    string.IsNullOrEmpty(tbFecha.Text) ||
                    string.IsNullOrEmpty(tbEdad.Text) ||
                    string.IsNullOrEmpty(tbId.Text) ||
                    string.IsNullOrEmpty(tbCarrera.Text) ||
                    (alumno.Checked && string.IsNullOrEmpty(tbArea.Text)) || // Si es un alumno, verifica el TextBox del área
                    (docente.Checked && string.IsNullOrEmpty(tbSueldo.Text))) // Si es un docente, verifica el TextBox del sueldo
                {
                    // Muestra un MessageBox de advertencia si algún campo está vacío
                    MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Muestra un MessageBox de éxito indicando que los datos han sido guardados
                    MessageBox.Show("Los datos han sido guardados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCarrera_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
