using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_POLIMORFISMO_EJERCICIO_PERSONAS
{
    public partial class fPrincipal : Form
    {
        #region Estructuras
        #endregion

        #region Variables Globales
        Persona[] APersonas;
        int ultimo, tope;
        #endregion

        #region Métodos Propios
        private void InsertarPersona(ref Persona[] alista, ref int ult,Persona persona)
        {
            int indice = ult;
            while(indice >= 0 && persona.Dni.CompareTo(alista[indice].Dni) < 0)
                alista[indice + 1] = alista[indice--];
            alista[indice + 1] = persona;
            ult++;
        }

        private int BuscarPosicionPersona(ref Persona[] alista, int ult, int dni)
        {
            Persona personaNueva = new Persona(dni);
            Persona personaActual;

            int indice = -1;
            bool encontro = false;

            while (indice < ult && !encontro)
            {
                personaActual = new Persona(alista[++indice].Dni);
                encontro = personaActual.Equals(personaNueva);
            }

            if (!encontro)
                indice = -1;

            return indice;
        }

        private int BuscarPosicionEstudiante(ref Persona[] alista, int ult, int legajo)
        {
            Estudiante estudianteNuevo = new Estudiante(0,legajo);
            int indice = ult;

            while (indice >= 0 && !(alista[indice].Equals(estudianteNuevo)))
                indice--;

            return indice;
        }

        private int BuscarPosicionEmpleado(ref Persona[] alista, int ult, int legajo)
        {
            Empleado empleadoNuevo = new Empleado(0, legajo);
            int indice = ult;

            while (indice >= 0 && !(alista[indice].Equals(empleadoNuevo)))
                indice--;

            return indice;
        }

        private bool ExistePersona(ref Persona[] alista, int ult, int dni)
        {
            return BuscarPosicionPersona(ref alista, ult, dni) > -1;
        }

        private void EliminarPersona(ref Persona[] aPersonas, ref int ult, int posicion)
        {
            if(ult != -1)
            {
                for (int indice = posicion; indice < ult; indice++)
                    aPersonas[indice] = aPersonas[indice+1];
                ult--;
            }
        }

        private void Listar()
        {
            lbPersonas.Items.Clear();
            switch (cbFiltro.SelectedIndex)
            {
                case 0: // TODO
                    for (int indice = 0; indice <= ultimo; indice++)
                        lbPersonas.Items.Add(APersonas[indice].ToString());
                    break;
                case 1: // PERSONAS
                    for (int indice = 0; indice <= ultimo; indice++)
                        if (APersonas[indice].GetType() == typeof(Persona))
                            lbPersonas.Items.Add(APersonas[indice].ToString());
                    break;
                case 2: // ESTUDIANTES
                    for (int indice = 0; indice <= ultimo; indice++)
                        if (APersonas[indice].GetType() == typeof(Estudiante))
                            lbPersonas.Items.Add(APersonas[indice].ToString());
                    break;
                case 3: // EMPLEADOS
                    for (int indice = 0; indice <= ultimo; indice++)
                        if (APersonas[indice].GetType() == typeof(Empleado))
                            lbPersonas.Items.Add(APersonas[indice].ToString());
                    break;
            }
        }

        private void LimpiarEP()
        {
            EPDni.Clear();
            EPNombre.Clear();
            EPLegajo.Clear();
            EPCargo.Clear();
            EPCarrera.Clear();
        }

        private void ActualizarPantalla()
        {
            LimpiarEP();
            Listar();
            LCantPersonas.Text = lbPersonas.Items.Count.ToString();
            mtDni.Focus();
        }

        private void Redimensionar(ref Persona[] alista, int ult, ref int total, int valor)
        {
            Persona[] ACopia = alista;
            total += valor;
            alista = new Persona[total];

            for (int indice = 0; indice <= ult; indice++)
                alista[indice] = ACopia[indice];
        }

        private string ObtenerInformacionPersona(ref Persona[] alista, int pos)
        {
            string informacion;

            informacion = "\nDNI: " + alista[pos].Dni;
            informacion = "\nNombre: " + alista[pos].Nombre;
            informacion += "\nFecha Nacimiento: " + alista[pos].FechaNacimiento.ToString("dd/MM/yyyy");

            if (alista[pos].GetType() == typeof(Empleado))
            {
                Empleado empleado = (Empleado)alista[pos];
                informacion += "\nLegajo: " + empleado.Legajo;
                informacion += "\nCargo: " + empleado.Cargo;
            }
            else if (alista[pos].GetType() == typeof(Estudiante))
            {
                Estudiante estudiante = (Estudiante)alista[pos];
                informacion += "\nLegajo: " + estudiante.Legajo;
                informacion += "\nCarrera: " + estudiante.Carrera;
            }
            return informacion;
        }
        #endregion

        #region Eventos
        public fPrincipal()
        {
            InitializeComponent();

            tope = 20;
            APersonas = new Persona[tope];
            ultimo = -1;

            cbFiltro.SelectedIndex = 0;
            dtFechaNacimiento.MaxDate = new DateTime(DateTime.Today.Year + 1,1,1);
        }

        private void mtDni_Enter(object sender, EventArgs e)
        {
            if (EPDni.GetError(mtDni) != "")
                EPDni.Clear();
        }

        private void tNombre_Enter(object sender, EventArgs e)
        {
            if (EPNombre.GetError(tNombre) != "")
                EPNombre.Clear();
        }

        private void mtDni_Validating(object sender, CancelEventArgs e)
        {
            if (!mtDni.MaskFull)
                EPDni.SetError(mtDni, "Debe ingresar un número de DNI");
        }

        private void tNombre_Validating(object sender, CancelEventArgs e)
        {
            if (tNombre.Text.Trim() == "")
                EPNombre.SetError(tNombre, "Debe ingresar un nombre");
        }

        private void MTLegajoEstudiante_Validating(object sender, CancelEventArgs e)
        {
            EPLegajo.Clear();
            if (!MTLegajoEstudiante.MaskFull)
                EPLegajo.SetError(MTLegajoEstudiante,"Debe ingresar un valor en legajo de estudiante");
        }

        private void MTLegajoEmpleado_Validating(object sender, CancelEventArgs e)
        {
            EPLegajo.Clear();
            if (!MTLegajoEmpleado.MaskFull)
                EPLegajo.SetError(MTLegajoEmpleado, "Debe ingresar un valor en legajo de empleado");
        }

        private void cbCargo_Validating(object sender, CancelEventArgs e)
        {
            EPCargo.Clear();
            if (cbCargo.Text.Trim() == "")
                EPCargo.SetError(cbCargo,"Ingresar o elegir un cargo");
        }

        private void cbCarrera_Validating(object sender, CancelEventArgs e)
        {
            EPCarrera.Clear();
            if (cbCarrera.Text.Trim() == "")
                EPCarrera.SetError(cbCarrera, "Ingresar o elegir una carrera");
        }

        private void RBEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (RBEstudiante.Checked)
            {
                pEstudiante.Visible = true;
                pEmpleado.Visible = false;
            }
            else
            {
                MTLegajoEstudiante.Clear();
                cbCarrera.Text = "";

                EPLegajo.Clear();
                EPCarrera.Clear();
            }
        }

        private void RBEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (RBEmpleado.Checked)
            {
                pEmpleado.Visible = true;
                pEstudiante.Visible = false;
            }
            else
            {
                MTLegajoEmpleado.Clear();
                cbCargo.Text = "";

                EPLegajo.Clear();
                EPCargo.Clear();
            }
        }

        private void RBPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (RBPersona.Checked)
            {
                pEmpleado.Visible = false;
                pEstudiante.Visible = false;
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarPantalla();
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            int dni,legajo,posicion;
            Empleado empleado;
            Estudiante estudiante;

            if (mtDni.Text.Trim() != "")
            {
                dni = Convert.ToInt32(mtDni.Text.Trim());
                posicion = BuscarPosicionPersona(ref APersonas,ultimo,dni);

                if(posicion == -1)
                    MessageBox.Show("No se encuentra registrada ninguna persona con ese número de documento","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                {
                    if (APersonas[posicion].GetType() == typeof(Estudiante))
                    {
                        RBEstudiante.Checked = true;
                        estudiante = (Estudiante)APersonas[posicion];
                        MTLegajoEstudiante.Text = estudiante.Legajo.ToString("000000");
                        cbCarrera.Text = estudiante.Carrera;
                    }
                    else if (APersonas[posicion].GetType() == typeof(Empleado))
                    {
                        RBEmpleado.Checked = true;
                        empleado = (Empleado)APersonas[posicion];
                        MTLegajoEmpleado.Text = empleado.Legajo.ToString("000000");
                        cbCargo.Text = empleado.Cargo;
                    }
                    else
                        RBPersona.Checked = true;

                    tNombre.Text = APersonas[posicion].Nombre;
                    dtFechaNacimiento.Value = APersonas[posicion].FechaNacimiento;

                    LimpiarEP();
                }
            }
            else
            {
                if (RBEstudiante.Checked && MTLegajoEstudiante.Text.Trim() != "")
                {
                    legajo = Convert.ToInt32(MTLegajoEstudiante.Text.Trim());
                    posicion = BuscarPosicionEstudiante(ref APersonas, ultimo, legajo);

                    if (posicion > -1)
                    {
                        estudiante = (Estudiante)APersonas[posicion];
                        mtDni.Text = estudiante.Dni.ToString();
                        tNombre.Text = estudiante.Nombre;
                        dtFechaNacimiento.Value = estudiante.FechaNacimiento;
                        cbCarrera.Text = estudiante.Carrera;

                        LimpiarEP();
                    }
                    else
                        MessageBox.Show("No hay ningún estudiante con el legajo " + legajo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (RBEmpleado.Checked && MTLegajoEmpleado.Text.Trim() != "")
                {
                    legajo = Convert.ToInt32(MTLegajoEmpleado.Text.Trim());
                    posicion = BuscarPosicionEmpleado(ref APersonas, ultimo, legajo);

                    if (posicion > -1)
                    {
                        empleado = (Empleado)APersonas[posicion];
                        mtDni.Text = empleado.Dni.ToString();
                        tNombre.Text = empleado.Nombre;
                        dtFechaNacimiento.Value = empleado.FechaNacimiento;
                        cbCargo.Text = empleado.Cargo;

                        LimpiarEP();
                    }
                    else
                        MessageBox.Show("No hay ningún empleado con el legajo " + legajo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("No se completo ni un DNI ni un número de legajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (!mtDni.MaskFull)
            {
                MessageBox.Show("Ingresar un número de DNI", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDni.Focus();
            }
            else if (tNombre.Text == "")
            {
                MessageBox.Show("Ingresar un nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tNombre.Focus();
            }
            else if (dtFechaNacimiento.Value.CompareTo(DateTime.Today.AddYears(-18).AddDays(1)) > 0)
            {
                MessageBox.Show("Debe ser mayor de edad para poder ser ingresado al programa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtFechaNacimiento.Focus();
            }
            else if (RBEmpleado.Checked && !MTLegajoEmpleado.MaskFull)
            { 
                MessageBox.Show("Ingresar un número de legajo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MTLegajoEmpleado.Focus();
            }
            else if (RBEmpleado.Checked && cbCargo.Text.Trim() == "")
            {
                MessageBox.Show("Escriba o elija un cargo por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbCargo.Focus();
            }
            else if (RBEstudiante.Checked && !MTLegajoEstudiante.MaskFull)
            {
                MessageBox.Show("Ingresar un número de legajo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MTLegajoEstudiante.Focus();
            }
            else if (RBEstudiante.Checked && cbCarrera.Text.Trim() == "")
            {
                MessageBox.Show("Escriba o elija un cargo por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbCarrera.Focus();
            }
            else
            {
                int legajo = (RBEmpleado.Checked)?Convert.ToInt32(MTLegajoEmpleado.Text.Trim()): (RBEstudiante.Checked) ? Convert.ToInt32(MTLegajoEstudiante.Text.Trim()):-1;
                int dni = Convert.ToInt32(mtDni.Text.Trim());
                bool existePersona = ExistePersona(ref APersonas, ultimo, dni);
                int posicion = BuscarPosicionPersona(ref APersonas, ultimo, dni);
                bool legajo_repetido = false;

                if (RBEmpleado.Checked)
                {
                    int posicionEmpleado = BuscarPosicionEmpleado(ref APersonas, ultimo, legajo);
                    if (posicionEmpleado > -1 && posicion != posicionEmpleado)
                    {
                        MessageBox.Show("Ya se encuentra cargado un empleado con el número de legajo ingresado.\n" + ObtenerInformacionPersona(ref APersonas, posicionEmpleado), "Legajo Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MTLegajoEmpleado.Focus();
                        legajo_repetido = true;
                    }
                }
                else if (RBEstudiante.Checked)
                {
                    int posicionEstudiante = BuscarPosicionEstudiante(ref APersonas, ultimo, legajo);
                    if (posicionEstudiante > -1 && posicion != posicionEstudiante)
                    {
                        MessageBox.Show("Ya se encuentra cargado un estudiante con el número de legajo ingresado.\n" + ObtenerInformacionPersona(ref APersonas, posicionEstudiante),"Legajo Repetido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        MTLegajoEstudiante.Focus();
                        legajo_repetido = true;
                    }
                }

                if (!legajo_repetido)
                {
                    string nombre = tNombre.Text.Trim();
                    DateTime fecha = dtFechaNacimiento.Value;

                    string cargo = cbCargo.Text.Trim();
                    string carrera = cbCarrera.Text.Trim();

                    if (posicion != -1)
                    {
                        string mensaje = "¿Quiere actualizar los datos de la persona?\n" + ObtenerInformacionPersona(ref APersonas, posicion);
                        DialogResult respuesta = MessageBox.Show(mensaje, "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Persona persona;
                            if (RBEstudiante.Checked)
                            {
                                persona = new Estudiante(dni, nombre, fecha, legajo, carrera);
                                if (carrera != "" && !cbCarrera.Items.Contains(carrera))
                                    cbCarrera.Items.Add(carrera);
                            }
                            else if (RBEmpleado.Checked)
                            {
                                persona = new Empleado(dni, nombre, fecha, legajo, cargo);
                                if (!cbCargo.Items.Contains(cargo))
                                    cbCargo.Items.Add(cargo);
                            }
                            else
                                persona = new Persona(dni, nombre, fecha);

                            if (existePersona)
                                APersonas[posicion] = persona;
                            else
                            {
                                EliminarPersona(ref APersonas, ref ultimo, posicion);
                                InsertarPersona(ref APersonas, ref ultimo, persona);
                            }
                            ActualizarPantalla();
                        }
                        else
                            MessageBox.Show("No se han realizado cambios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (ultimo + 1 == tope)
                            Redimensionar(ref APersonas, ultimo, ref tope, 5);

                        if (RBPersona.Checked)
                            InsertarPersona(ref APersonas, ref ultimo, new Persona(dni, nombre, fecha));
                        else if (RBEmpleado.Checked)
                        {
                            InsertarPersona(ref APersonas, ref ultimo, new Empleado(dni, nombre, fecha, legajo, cargo));
                            if (!cbCargo.Items.Contains(cargo))
                                cbCargo.Items.Add(cargo);
                        }
                        else
                        {
                            InsertarPersona(ref APersonas, ref ultimo, new Estudiante(dni, nombre, fecha, legajo, carrera));
                            if (!cbCarrera.Items.Contains(carrera))
                                cbCarrera.Items.Add(carrera);
                        }
                        ActualizarPantalla();
                    }
                    RBPersona.Checked = true;
                    tNombre.Clear();
                    mtDni.Clear();
                    dtFechaNacimiento.Value = DateTime.Today;
                }
            }
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere salir?","Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                Close();
        }
        #endregion
    }
}