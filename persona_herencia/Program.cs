using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona //clase padre
    {
        //variables
        protected string nombre;
        protected string fecha;
        protected string edad;
        protected string id;
        protected string ocupacion;
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        //aqui va el constructor para cargar datos en las cajas de memoria
        //nombre, edad, fecha de nacimiento(es un tipo cadena!!!!! string)
        public string Nombre
        {
            get { return Nombre; }//se obtiene el valor de la caja de texto
            set { Nombre = value; }//se guarda en memoria
        }
        public string Fecha
        {
            get { return Fecha; }//se obtiene el valor de la caja de texto
            set { Fecha = value; }//se guarda en memoria
        }
        public string Edad
        {
            get { return Edad; }//se obtiene el valor de la caja de texto
            set { Edad = value; }//se guarda en memoria
        }
        public string Id
        {
            get { return Id; }//se obtiene el valor de la caja de texto
            set { Id = value; }//se guarda en memoria
        }
        public string Ocupacion
        {
            get { return Ocupacion; }//se obtiene el valor de la caja de texto
            set { Ocupacion = value; }//se guarda en memoria
        } 
    }

    class Alumno : Persona //clase hija alumno
    {
        protected string semestre;
        protected string carrea;
        public string Semestre
        {
            get { return Semestre; }//se obtiene el valor de la caja de texto
            set { Semestre = value; }//se guarda en memoria
        }
        public string Carrera
        {
            get { return Carrera; }//se obtiene el valor de la caja de texto
            set { Carrera = value; }//se guarda en memoria
        }
    }
    class Empleado : Persona //clase hija
    {
        protected int sueldo;
        protected string area;
        protected string puesto;
        public string Sueldo
        {
            get { return Sueldo; }//se obtiene el valor de la caja de texto
            set { Sueldo = value; }//se guarda en memoria
        }
        public string Area
        {
            get { return Area; }//se obtiene el valor de la caja de texto
            set { Area = value; }//se guarda en memoria
        }
        public string Puesto
        {
            get { return Puesto; }
            set { Puesto = value; }
        }
    }

    class Docente : Persona //clase Hija
    {
        protected  int sueldo;
        protected string materia;
        protected string area;
        public int Sueldo
        {
            get { return Sueldo; }//se obtiene el valor de la caja de texto
            set { Sueldo = value; }//se guarda en memoria
        }
        public int Materia
        {
            get { return Materia; }//se obtiene el valor de la caja de texto
            set { Materia = value; }//se guarda en memoria
        }
        public string Area
        {
            get { return Area; }
            set { Area = value; }
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
