
namespace TP_POLIMORFISMO_EJERCICIO_PERSONAS
{
    partial class fPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.pCarga = new System.Windows.Forms.Panel();
            this.RBEmpleado = new System.Windows.Forms.RadioButton();
            this.RBEstudiante = new System.Windows.Forms.RadioButton();
            this.RBPersona = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtDni = new System.Windows.Forms.MaskedTextBox();
            this.lDNI = new System.Windows.Forms.Label();
            this.pEstudiante = new System.Windows.Forms.Panel();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MTLegajoEstudiante = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pPersona = new System.Windows.Forms.Panel();
            this.LCantPersonas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPersonas = new System.Windows.Forms.ListBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.pEmpleado = new System.Windows.Forms.Panel();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MTLegajoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BMostrar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCerrar = new System.Windows.Forms.Button();
            this.EPDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPLegajo = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPCarrera = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPCargo = new System.Windows.Forms.ErrorProvider(this.components);
            this.pCarga.SuspendLayout();
            this.pEstudiante.SuspendLayout();
            this.pPersona.SuspendLayout();
            this.pEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPLegajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // pCarga
            // 
            this.pCarga.BackColor = System.Drawing.Color.PowderBlue;
            this.pCarga.Controls.Add(this.RBEmpleado);
            this.pCarga.Controls.Add(this.RBEstudiante);
            this.pCarga.Controls.Add(this.RBPersona);
            this.pCarga.Controls.Add(this.label2);
            this.pCarga.Controls.Add(this.dtFechaNacimiento);
            this.pCarga.Controls.Add(this.tNombre);
            this.pCarga.Controls.Add(this.label1);
            this.pCarga.Controls.Add(this.mtDni);
            this.pCarga.Controls.Add(this.lDNI);
            this.pCarga.Location = new System.Drawing.Point(12, 12);
            this.pCarga.Name = "pCarga";
            this.pCarga.Size = new System.Drawing.Size(237, 120);
            this.pCarga.TabIndex = 0;
            // 
            // RBEmpleado
            // 
            this.RBEmpleado.AutoSize = true;
            this.RBEmpleado.Location = new System.Drawing.Point(153, 95);
            this.RBEmpleado.Name = "RBEmpleado";
            this.RBEmpleado.Size = new System.Drawing.Size(72, 17);
            this.RBEmpleado.TabIndex = 8;
            this.RBEmpleado.Text = "Empleado";
            this.RBEmpleado.UseVisualStyleBackColor = true;
            this.RBEmpleado.CheckedChanged += new System.EventHandler(this.RBEmpleado_CheckedChanged);
            // 
            // RBEstudiante
            // 
            this.RBEstudiante.AutoSize = true;
            this.RBEstudiante.Location = new System.Drawing.Point(72, 95);
            this.RBEstudiante.Name = "RBEstudiante";
            this.RBEstudiante.Size = new System.Drawing.Size(75, 17);
            this.RBEstudiante.TabIndex = 7;
            this.RBEstudiante.Text = "Estudiante";
            this.RBEstudiante.UseVisualStyleBackColor = true;
            this.RBEstudiante.CheckedChanged += new System.EventHandler(this.RBEstudiante_CheckedChanged);
            // 
            // RBPersona
            // 
            this.RBPersona.AutoSize = true;
            this.RBPersona.Checked = true;
            this.RBPersona.Location = new System.Drawing.Point(7, 95);
            this.RBPersona.Name = "RBPersona";
            this.RBPersona.Size = new System.Drawing.Size(64, 17);
            this.RBPersona.TabIndex = 6;
            this.RBPersona.TabStop = true;
            this.RBPersona.Text = "Persona";
            this.RBPersona.UseVisualStyleBackColor = true;
            this.RBPersona.CheckedChanged += new System.EventHandler(this.RBPersona_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Nac.:";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Checked = false;
            this.dtFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(80, 65);
            this.dtFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(121, 20);
            this.dtFechaNacimiento.TabIndex = 4;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(80, 39);
            this.tNombre.MaxLength = 20;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(121, 20);
            this.tNombre.TabIndex = 3;
            this.tNombre.Enter += new System.EventHandler(this.tNombre_Enter);
            this.tNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tNombre_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // mtDni
            // 
            this.mtDni.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtDni.Location = new System.Drawing.Point(80, 13);
            this.mtDni.Mask = "99,999,999";
            this.mtDni.Name = "mtDni";
            this.mtDni.Size = new System.Drawing.Size(67, 20);
            this.mtDni.TabIndex = 1;
            this.mtDni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtDni.ValidatingType = typeof(int);
            this.mtDni.Enter += new System.EventHandler(this.mtDni_Enter);
            this.mtDni.Validating += new System.ComponentModel.CancelEventHandler(this.mtDni_Validating);
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Location = new System.Drawing.Point(45, 16);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(29, 13);
            this.lDNI.TabIndex = 0;
            this.lDNI.Text = "DNI:";
            // 
            // pEstudiante
            // 
            this.pEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pEstudiante.Controls.Add(this.cbCarrera);
            this.pEstudiante.Controls.Add(this.label4);
            this.pEstudiante.Controls.Add(this.MTLegajoEstudiante);
            this.pEstudiante.Controls.Add(this.label3);
            this.pEstudiante.Location = new System.Drawing.Point(12, 138);
            this.pEstudiante.Name = "pEstudiante";
            this.pEstudiante.Size = new System.Drawing.Size(237, 78);
            this.pEstudiante.TabIndex = 1;
            this.pEstudiante.Visible = false;
            // 
            // cbCarrera
            // 
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Items.AddRange(new object[] {
            "Abogacia",
            "Arquitectura",
            "Bioquímica",
            "Contador Público",
            "Farmacia",
            "Ingeniería Agronómica",
            "Ingeniería Civil",
            "Ingeniería Electricista",
            "Ingeniería Electrónica",
            "Ingeniería En Computación",
            "Ingeniería Industrial",
            "Ingeniería Mecánica",
            "Ingeniería Química",
            "Licenciatura En Administración",
            "Licenciatura En Ciencias De La Computación",
            "Licenciatura En Ciencias Geológicas",
            "Licenciatura En Economía",
            "Licenciatura En Enfermería",
            "Licenciatura En Filosofía",
            "Licenciatura En Física",
            "Licenciatura En Geofísica",
            "Licenciatura En Geografía",
            "Licenciatura En Historia",
            "Licenciatura En Letras",
            "Licenciatura En Matemática",
            "Licenciatura En Obstetricia",
            "Licenciatura En Oceanografía",
            "Licenciatura En Química",
            "Licenciatura En Seguridad Pública",
            "Licenciatura En Turismo",
            "Medicina"});
            this.cbCarrera.Location = new System.Drawing.Point(80, 40);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(128, 21);
            this.cbCarrera.TabIndex = 3;
            this.cbCarrera.Validating += new System.ComponentModel.CancelEventHandler(this.cbCarrera_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carrera:";
            // 
            // MTLegajoEstudiante
            // 
            this.MTLegajoEstudiante.Location = new System.Drawing.Point(80, 12);
            this.MTLegajoEstudiante.Mask = "000000";
            this.MTLegajoEstudiante.Name = "MTLegajoEstudiante";
            this.MTLegajoEstudiante.Size = new System.Drawing.Size(67, 20);
            this.MTLegajoEstudiante.TabIndex = 1;
            this.MTLegajoEstudiante.ValidatingType = typeof(int);
            this.MTLegajoEstudiante.Validating += new System.ComponentModel.CancelEventHandler(this.MTLegajoEstudiante_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Legajo:";
            // 
            // pPersona
            // 
            this.pPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pPersona.Controls.Add(this.LCantPersonas);
            this.pPersona.Controls.Add(this.label5);
            this.pPersona.Controls.Add(this.lbPersonas);
            this.pPersona.Controls.Add(this.cbFiltro);
            this.pPersona.Location = new System.Drawing.Point(255, 12);
            this.pPersona.Name = "pPersona";
            this.pPersona.Size = new System.Drawing.Size(237, 233);
            this.pPersona.TabIndex = 2;
            // 
            // LCantPersonas
            // 
            this.LCantPersonas.AutoSize = true;
            this.LCantPersonas.Location = new System.Drawing.Point(68, 214);
            this.LCantPersonas.Name = "LCantPersonas";
            this.LCantPersonas.Size = new System.Drawing.Size(13, 13);
            this.LCantPersonas.TabIndex = 3;
            this.LCantPersonas.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad:";
            // 
            // lbPersonas
            // 
            this.lbPersonas.FormattingEnabled = true;
            this.lbPersonas.Location = new System.Drawing.Point(13, 34);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.Size = new System.Drawing.Size(209, 173);
            this.lbPersonas.TabIndex = 1;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "TODO",
            "PERSONAS",
            "ESTUDIANTES",
            "EMPLEADOS"});
            this.cbFiltro.Location = new System.Drawing.Point(13, 7);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(209, 21);
            this.cbFiltro.TabIndex = 0;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // pEmpleado
            // 
            this.pEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pEmpleado.Controls.Add(this.cbCargo);
            this.pEmpleado.Controls.Add(this.label7);
            this.pEmpleado.Controls.Add(this.MTLegajoEmpleado);
            this.pEmpleado.Controls.Add(this.label6);
            this.pEmpleado.Location = new System.Drawing.Point(12, 138);
            this.pEmpleado.Name = "pEmpleado";
            this.pEmpleado.Size = new System.Drawing.Size(237, 78);
            this.pEmpleado.TabIndex = 3;
            this.pEmpleado.Visible = false;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(80, 40);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(128, 21);
            this.cbCargo.TabIndex = 6;
            this.cbCargo.Validating += new System.ComponentModel.CancelEventHandler(this.cbCargo_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cargo:";
            // 
            // MTLegajoEmpleado
            // 
            this.MTLegajoEmpleado.Location = new System.Drawing.Point(80, 12);
            this.MTLegajoEmpleado.Mask = "000000";
            this.MTLegajoEmpleado.Name = "MTLegajoEmpleado";
            this.MTLegajoEmpleado.Size = new System.Drawing.Size(67, 20);
            this.MTLegajoEmpleado.TabIndex = 3;
            this.MTLegajoEmpleado.ValidatingType = typeof(int);
            this.MTLegajoEmpleado.Validating += new System.ComponentModel.CancelEventHandler(this.MTLegajoEmpleado_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Legajo:";
            // 
            // BMostrar
            // 
            this.BMostrar.Location = new System.Drawing.Point(12, 222);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(75, 23);
            this.BMostrar.TabIndex = 4;
            this.BMostrar.Text = "&Mostrar";
            this.BMostrar.UseVisualStyleBackColor = true;
            this.BMostrar.Click += new System.EventHandler(this.BMostrar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(93, 222);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 5;
            this.BGuardar.Text = "&Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCerrar
            // 
            this.BCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCerrar.Location = new System.Drawing.Point(174, 222);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(75, 23);
            this.BCerrar.TabIndex = 6;
            this.BCerrar.Text = "&Cerrar";
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // EPDni
            // 
            this.EPDni.ContainerControl = this;
            // 
            // EPLegajo
            // 
            this.EPLegajo.ContainerControl = this;
            // 
            // EPNombre
            // 
            this.EPNombre.ContainerControl = this;
            // 
            // EPCarrera
            // 
            this.EPCarrera.ContainerControl = this;
            // 
            // EPCargo
            // 
            this.EPCargo.ContainerControl = this;
            // 
            // fPrincipal
            // 
            this.AcceptButton = this.BGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.CancelButton = this.BCerrar;
            this.ClientSize = new System.Drawing.Size(504, 262);
            this.Controls.Add(this.BCerrar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.pEmpleado);
            this.Controls.Add(this.pPersona);
            this.Controls.Add(this.pEstudiante);
            this.Controls.Add(this.pCarga);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 300);
            this.MinimumSize = new System.Drawing.Size(520, 300);
            this.Name = "fPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personas";
            this.pCarga.ResumeLayout(false);
            this.pCarga.PerformLayout();
            this.pEstudiante.ResumeLayout(false);
            this.pEstudiante.PerformLayout();
            this.pPersona.ResumeLayout(false);
            this.pPersona.PerformLayout();
            this.pEmpleado.ResumeLayout(false);
            this.pEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPLegajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCarga;
        private System.Windows.Forms.MaskedTextBox mtDni;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.Panel pEstudiante;
        private System.Windows.Forms.Panel pPersona;
        private System.Windows.Forms.Panel pEmpleado;
        private System.Windows.Forms.RadioButton RBEmpleado;
        private System.Windows.Forms.RadioButton RBEstudiante;
        private System.Windows.Forms.RadioButton RBPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MTLegajoEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BMostrar;
        private System.Windows.Forms.Label LCantPersonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPersonas;
        private System.Windows.Forms.MaskedTextBox MTLegajoEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider EPDni;
        private System.Windows.Forms.ErrorProvider EPLegajo;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.ErrorProvider EPNombre;
        private System.Windows.Forms.ErrorProvider EPCarrera;
        private System.Windows.Forms.ErrorProvider EPCargo;
    }
}

