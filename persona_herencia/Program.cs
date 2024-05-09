using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona //clase padre
    {
        //variables
        protected string tbNombre;
        protected string tbFecha;
        protected string tbEdad;
        protected string tbId;
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        //aqui va el constructor para cargar datos en las cajas de memoria
        //nombre, edad, fecha de nacimiento(es un tipo cadena!!!!! string)
        public string Nombre
        {
            get { return tbNombre; }//se obtiene el valor de la caja de texto
            set { tbNombre = value; }//se guarda en memoria
        }
        public string Fecha
        {
            get { return tbFecha; }//se obtiene el valor de la caja de texto
            set { tbFecha = value; }//se guarda en memoria
        }
        public string Edad
        {
            get { return tbEdad; }//se obtiene el valor de la caja de texto
            set { tbEdad = value; }//se guarda en memoria
        }
        public string Id
        {
            get { return tbId; }//se obtiene el valor de la caja de texto
            set { tbId = value; }//se guarda en memoria
        }
    }
    class Alumno : Persona //clase hija alumno
    {
        protected string tbArea;
        protected string tbCarrera;

        public string Semestre
        {
            get { return tbArea; }//se obtiene el valor de la caja de texto
            set { tbArea = value; }//se guarda en memoria
        }
        public string Carrera
        {
            get { return tbCarrera; }//se obtiene el valor de la caja de texto
            set { tbCarrera = value; }//se guarda en memoria
        }
    }
    class Empleado : Persona //clase hija
    {
        protected string tbSueldo;
        protected string tbArea;
        protected string tbCarrera;
        public string Sueldo
        {
            get { return tbSueldo; }//se obtiene el valor de la caja de texto
            set { tbSueldo = value; }//se guarda en memoria
        }
        public string Area
        {
            get { return tbArea; }//se obtiene el valor de la caja de texto
            set { tbArea = value; }//se guarda en memoria
        }
        public string Puesto
        {
            get { return tbCarrera; }
            set { tbCarrera = value; }
        }
    }

    class Docente : Persona //clase Hija
    {
        protected  string tbSueldo;
        protected string tbCarrera;
        protected string tbArea;
        public string Sueldo
        {
            get { return tbSueldo; }//se obtiene el valor de la caja de texto
            set { tbSueldo = value; }//se guarda en memoria
        }
        public string Materia
        {
            get { return tbCarrera; }//se obtiene el valor de la caja de texto
            set { tbCarrera = value; }//se guarda en memoria
        }
        public string Area
        {
            get { return tbArea; }
            set { tbArea = value; }
        }
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
