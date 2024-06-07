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

            //Colocar imagen de empleado
            string rutaImagen = "C://Users//arm00//source//repos//pablo27exe//Herencia_persona_id22028//persona_herencia//imagenes//Pablopelon.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
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
            tbArea.Clear();
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

            string rutaImagen = "C://Users//arm00//source//repos//pablo27exe//Herencia_persona_id22028//persona_herencia//imagenes//Pablotraje.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
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
            tbArea.Visible = false;

            string rutaImagen = "C://Users//arm00//source//repos//pablo27exe//Herencia_persona_id22028//persona_herencia//imagenes//Pablobigote.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
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

                try
                {
                    string filename = @"C:\Users\arm00\source\repos\pablo27exe\Herencia_persona_id22028\persona_herencia\registros\datos.txt";
                    StreamWriter writer = File.AppendText(filename);

                    {
                        if (alumno.Checked)
                        {
                            writer.WriteLine("Datos del alumno.");
                            writer.WriteLine("Nombre: " + tbNombre.Text);
                            writer.WriteLine("Fecha: " + tbFecha.Text);
                            writer.WriteLine("Edad: " + tbEdad.Text);
                            writer.WriteLine("Matricula: " + tbId.Text);
                            writer.WriteLine("Carrera: " + tbCarrera.Text);
                            writer.WriteLine("Semestre: " + tbArea.Text);
                            writer.WriteLine(" ");
                            writer.Close();
                        }
                        else if (docente.Checked)
                        {
                            writer.WriteLine("Datos del docente.");
                            writer.WriteLine("Nombre: " + tbNombre.Text);
                            writer.WriteLine("Fecha: " + tbFecha.Text);
                            writer.WriteLine("Edad: " + tbEdad.Text);
                            writer.WriteLine("ID: " + tbId.Text);
                            writer.WriteLine("Materia " + tbCarrera.Text);
                            writer.WriteLine("Área: " + tbArea.Text);
                            writer.WriteLine("Sueldo:" + tbSueldo.Text);
                            writer.WriteLine(" ");
                            writer.Close();
                        }
                        else if (empleado.Checked)
                        {
                            writer.WriteLine("Datos del empleado.");
                            writer.WriteLine("Nombre: " + tbNombre.Text);
                            writer.WriteLine("Fecha: " + tbFecha.Text);
                            writer.WriteLine("Edad: " + tbEdad.Text);
                            writer.WriteLine("ID: " + tbId.Text);
                            writer.WriteLine("Puesto " + tbCarrera.Text);
                            writer.WriteLine("Área: " + tbArea.Text);
                            writer.WriteLine("Sueldo:" + tbSueldo.Text);
                            writer.WriteLine(" ");
                            writer.Close();
                        }
                        else
                        {
                            writer.WriteLine("Nombre: " + tbNombre.Text);
                            writer.WriteLine("Fecha: " + tbFecha.Text);
                            writer.WriteLine("Edad: " + tbEdad.Text);
                            writer.WriteLine(" ");
                            writer.Close();
                        }
                    }

                    // Muestra un MessageBox de éxito indicando que los datos han sido guardados
                    MessageBox.Show("Los datos han sido guardados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // MessageBox de error
                    MessageBox.Show("Ocurrió un error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

        private void mostrarInformacion_Click(object sender, EventArgs e)
        {
            // Verifica si el radio button de Alumno está seleccionado
            if (alumno.Checked)
            {
                // Crea una instancia de la clase Alumno y asignar los valores de los TextBox
                Alumno alumno = new Alumno();
                alumno.Nombre = tbNombre.Text;
                alumno.Fecha = tbFecha.Text;
                alumno.Edad = tbEdad.Text;
                alumno.Id = tbId.Text;
                alumno.Carrera = tbCarrera.Text;
                alumno.Semestre = tbArea.Text;

                // Muestra información del alumno
                MostrarInformacion(alumno);
            }
            // Verifica si el radio button de Empleado está seleccionado
            else if (empleado.Checked)
            {
                // Crea una instancia de la clase Empleado y asignar los valores de los TextBox
                Empleado empleado = new Empleado();
                empleado.Nombre = tbNombre.Text;
                empleado.Fecha = tbFecha.Text;
                empleado.Edad = tbEdad.Text;
                empleado.Id = tbId.Text;
                empleado.Puesto = tbCarrera.Text;
                empleado.Area = tbArea.Text;
                empleado.Sueldo = tbSueldo.Text;

                // Muestra información del empleado
                MostrarInformacion(empleado);
            }
            // Verifica si el radio button de Docente está seleccionado
            else if (docente.Checked)
            {
                // Crea una instancia de la clase Docente y asignar los valores de los TextBox
                Docente docente = new Docente();
                docente.Nombre = tbNombre.Text;
                docente.Fecha = tbFecha.Text;
                docente.Edad = tbEdad.Text;
                docente.Id = tbId.Text;
                docente.Materia = tbCarrera.Text;
                docente.Materia = tbCarrera.Text;
                docente.Sueldo = tbSueldo.Text;

                // Muestra información del docente
                MostrarInformacion(docente);
            }
            else
            {
                Persona persona = new Persona();
                persona.Nombre = tbNombre.Text;
                persona.Fecha = tbFecha.Text;
                persona.Edad = tbEdad.Text;
                MostrarInformacion(persona);
            }
        }

        // Método para mostrar la información de una persona
        private void MostrarInformacion(Persona persona)
        {
            // Inicialización de un StringBuilder para construir el mensaje
            StringBuilder mensaje = new StringBuilder();
            // Verificar el tipo de persona y agregar detalles específicos
            if (persona is Alumno)
            {
                Alumno alumno = (Alumno)persona;
                mensaje.AppendLine("Nombre: " + alumno.Nombre);
                mensaje.AppendLine("Fecha de Nacimiento: " + alumno.Fecha);
                mensaje.AppendLine("Edad: " + alumno.Edad);
                mensaje.AppendLine("Matricula: " + alumno.Id);
                mensaje.AppendLine("Carrera: " + alumno.Carrera);
                mensaje.AppendLine("Semestre: " + alumno.Semestre);
            }
            else if (persona is Empleado)
            {
                Empleado empleado = (Empleado)persona;
                // Agregar los detalles comunes a todas las personas
                mensaje.AppendLine("Nombre: " + empleado.Nombre);
                mensaje.AppendLine("Fecha de Nacimiento: " + empleado.Fecha);
                mensaje.AppendLine("Edad: " + empleado.Edad);
                mensaje.AppendLine("ID: " + empleado.Id);
                mensaje.AppendLine("Puesto: " + empleado.Puesto);
                mensaje.AppendLine("Área: " + empleado.Area);
                mensaje.AppendLine("Sueldo: " + empleado.Sueldo);
            }
            else if (persona is Docente)
            {
                Docente docente = (Docente)persona;
                // Agregar los detalles comunes a todas las personas
                mensaje.AppendLine("Nombre: " + docente.Nombre);
                mensaje.AppendLine("Fecha de Nacimiento: " + docente.Fecha);
                mensaje.AppendLine("Edad: " + docente.Edad);
                mensaje.AppendLine("ID: " + docente.Id);
                mensaje.AppendLine("Materia: " + docente.Materia);
                mensaje.AppendLine("Sueldo: " + docente.Sueldo);
            }
            else
            {
                mensaje.AppendLine("Nombre: " + persona.Nombre);
                mensaje.AppendLine("Fecha de Nacimiento: " + persona.Fecha);
                mensaje.AppendLine("Edad: " + persona.Edad);
            }

            // Mostrar el mensaje en un MessageBox
            MessageBox.Show(mensaje.ToString(), "Información de Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
