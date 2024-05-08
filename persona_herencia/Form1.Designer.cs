namespace persona_herencia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.docente = new System.Windows.Forms.RadioButton();
            this.alumno = new System.Windows.Forms.RadioButton();
            this.empleado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lArea = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.lSemestre = new System.Windows.Forms.Label();
            this.lMateria = new System.Windows.Forms.Label();
            this.lDni = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.tbSueldo = new System.Windows.Forms.TextBox();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lSueldo = new System.Windows.Forms.Label();
            this.lPuesto = new System.Windows.Forms.Label();
            this.lMatricula = new System.Windows.Forms.Label();
            this.lFecNac = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.lCarrera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.docente);
            this.groupBox1.Controls.Add(this.alumno);
            this.groupBox1.Controls.Add(this.empleado);
            this.groupBox1.Location = new System.Drawing.Point(257, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // docente
            // 
            this.docente.AutoSize = true;
            this.docente.Location = new System.Drawing.Point(32, 123);
            this.docente.Name = "docente";
            this.docente.Size = new System.Drawing.Size(121, 20);
            this.docente.TabIndex = 2;
            this.docente.Text = "Soy un docente";
            this.docente.UseVisualStyleBackColor = true;
            this.docente.CheckedChanged += new System.EventHandler(this.docente_CheckedChanged);
            // 
            // alumno
            // 
            this.alumno.AutoSize = true;
            this.alumno.Location = new System.Drawing.Point(32, 84);
            this.alumno.Name = "alumno";
            this.alumno.Size = new System.Drawing.Size(116, 20);
            this.alumno.TabIndex = 1;
            this.alumno.Text = "Soy un alumno";
            this.alumno.UseVisualStyleBackColor = true;
            this.alumno.CheckedChanged += new System.EventHandler(this.alumno_CheckedChanged);
            // 
            // empleado
            // 
            this.empleado.AutoSize = true;
            this.empleado.Location = new System.Drawing.Point(32, 47);
            this.empleado.Name = "empleado";
            this.empleado.Size = new System.Drawing.Size(134, 20);
            this.empleado.TabIndex = 0;
            this.empleado.Text = "Soy un empleado";
            this.empleado.UseVisualStyleBackColor = true;
            this.empleado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lArea);
            this.groupBox2.Controls.Add(this.tbArea);
            this.groupBox2.Controls.Add(this.lSemestre);
            this.groupBox2.Controls.Add(this.lMateria);
            this.groupBox2.Controls.Add(this.lCarrera);
            this.groupBox2.Controls.Add(this.lDni);
            this.groupBox2.Controls.Add(this.Salir);
            this.groupBox2.Controls.Add(this.limpiar);
            this.groupBox2.Controls.Add(this.guardar);
            this.groupBox2.Controls.Add(this.tbSueldo);
            this.groupBox2.Controls.Add(this.tbCarrera);
            this.groupBox2.Controls.Add(this.tbId);
            this.groupBox2.Controls.Add(this.tbEdad);
            this.groupBox2.Controls.Add(this.tbFecha);
            this.groupBox2.Controls.Add(this.tbNombre);
            this.groupBox2.Controls.Add(this.lSueldo);
            this.groupBox2.Controls.Add(this.lPuesto);
            this.groupBox2.Controls.Add(this.lMatricula);
            this.groupBox2.Controls.Add(this.lFecNac);
            this.groupBox2.Controls.Add(this.lNombre);
            this.groupBox2.Controls.Add(this.lAge);
            this.groupBox2.Location = new System.Drawing.Point(42, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 313);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lArea
            // 
            this.lArea.AutoSize = true;
            this.lArea.Location = new System.Drawing.Point(258, 185);
            this.lArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lArea.Name = "lArea";
            this.lArea.Size = new System.Drawing.Size(44, 16);
            this.lArea.TabIndex = 34;
            this.lArea.Text = "AREA";
            this.lArea.Visible = false;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(326, 179);
            this.tbArea.Margin = new System.Windows.Forms.Padding(4);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(132, 22);
            this.tbArea.TabIndex = 33;
            this.tbArea.Visible = false;
            // 
            // lSemestre
            // 
            this.lSemestre.AutoSize = true;
            this.lSemestre.Location = new System.Drawing.Point(220, 185);
            this.lSemestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSemestre.Name = "lSemestre";
            this.lSemestre.Size = new System.Drawing.Size(82, 16);
            this.lSemestre.TabIndex = 32;
            this.lSemestre.Text = "SEMESTRE";
            this.lSemestre.Visible = false;
            this.lSemestre.Click += new System.EventHandler(this.label10_Click);
            // 
            // lMateria
            // 
            this.lMateria.AutoSize = true;
            this.lMateria.Location = new System.Drawing.Point(233, 152);
            this.lMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMateria.Name = "lMateria";
            this.lMateria.Size = new System.Drawing.Size(67, 16);
            this.lMateria.TabIndex = 31;
            this.lMateria.Text = "MATERIA";
            this.lMateria.Visible = false;
            this.lMateria.Click += new System.EventHandler(this.label9_Click);
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(271, 117);
            this.lDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(30, 16);
            this.lDni.TabIndex = 29;
            this.lDni.Text = "DNI";
            this.lDni.Visible = false;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(370, 253);
            this.Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(127, 53);
            this.Salir.TabIndex = 28;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(236, 253);
            this.limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(127, 53);
            this.limpiar.TabIndex = 27;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(101, 253);
            this.guardar.Margin = new System.Windows.Forms.Padding(4);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(127, 53);
            this.guardar.TabIndex = 18;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // tbSueldo
            // 
            this.tbSueldo.Location = new System.Drawing.Point(326, 212);
            this.tbSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.Size = new System.Drawing.Size(132, 22);
            this.tbSueldo.TabIndex = 26;
            this.tbSueldo.Visible = false;
            // 
            // tbCarrera
            // 
            this.tbCarrera.Location = new System.Drawing.Point(326, 149);
            this.tbCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(132, 22);
            this.tbCarrera.TabIndex = 25;
            this.tbCarrera.Visible = false;
            this.tbCarrera.TextChanged += new System.EventHandler(this.tbCarrera_TextChanged);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(326, 117);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(132, 22);
            this.tbId.TabIndex = 24;
            this.tbId.Visible = false;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(326, 85);
            this.tbEdad.Margin = new System.Windows.Forms.Padding(4);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(132, 22);
            this.tbEdad.TabIndex = 23;
            this.tbEdad.Visible = false;
            this.tbEdad.TextChanged += new System.EventHandler(this.tbEdad_TextChanged);
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(326, 53);
            this.tbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(132, 22);
            this.tbFecha.TabIndex = 22;
            this.tbFecha.Visible = false;
            this.tbFecha.TextChanged += new System.EventHandler(this.tbFecha_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(326, 14);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 22);
            this.tbNombre.TabIndex = 21;
            this.tbNombre.Visible = false;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // lSueldo
            // 
            this.lSueldo.AutoSize = true;
            this.lSueldo.Location = new System.Drawing.Point(239, 212);
            this.lSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSueldo.Name = "lSueldo";
            this.lSueldo.Size = new System.Drawing.Size(62, 16);
            this.lSueldo.TabIndex = 20;
            this.lSueldo.Text = "SUELDO";
            this.lSueldo.Visible = false;
            // 
            // lPuesto
            // 
            this.lPuesto.AutoSize = true;
            this.lPuesto.Location = new System.Drawing.Point(239, 152);
            this.lPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPuesto.Name = "lPuesto";
            this.lPuesto.Size = new System.Drawing.Size(63, 16);
            this.lPuesto.TabIndex = 19;
            this.lPuesto.Text = "PUESTO";
            this.lPuesto.Visible = false;
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Location = new System.Drawing.Point(217, 117);
            this.lMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(84, 16);
            this.lMatricula.TabIndex = 17;
            this.lMatricula.Text = "MATRICULA";
            this.lMatricula.Visible = false;
            this.lMatricula.Click += new System.EventHandler(this.label4_Click);
            // 
            // lFecNac
            // 
            this.lFecNac.AutoSize = true;
            this.lFecNac.Location = new System.Drawing.Point(141, 53);
            this.lFecNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFecNac.Name = "lFecNac";
            this.lFecNac.Size = new System.Drawing.Size(160, 16);
            this.lFecNac.TabIndex = 16;
            this.lFecNac.Text = "FECHA DE NACIMIENTO";
            this.lFecNac.Visible = false;
            this.lFecNac.Click += new System.EventHandler(this.label3_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(158, 20);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(143, 16);
            this.lNombre.TabIndex = 15;
            this.lNombre.Text = "NOMBRE COMPLETO";
            this.lNombre.Visible = false;
            this.lNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(256, 85);
            this.lAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(45, 16);
            this.lAge.TabIndex = 14;
            this.lAge.Text = "EDAD";
            this.lAge.Visible = false;
            this.lAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // lCarrera
            // 
            this.lCarrera.AutoSize = true;
            this.lCarrera.Location = new System.Drawing.Point(227, 152);
            this.lCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCarrera.Name = "lCarrera";
            this.lCarrera.Size = new System.Drawing.Size(73, 16);
            this.lCarrera.TabIndex = 30;
            this.lCarrera.Text = "CARRERA";
            this.lCarrera.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton empleado;
        private System.Windows.Forms.RadioButton docente;
        private System.Windows.Forms.RadioButton alumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox tbSueldo;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lSueldo;
        private System.Windows.Forms.Label lPuesto;
        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.Label lFecNac;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.Label lMateria;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label lSemestre;
        private System.Windows.Forms.Label lArea;
        private System.Windows.Forms.Label lCarrera;
    }
}

