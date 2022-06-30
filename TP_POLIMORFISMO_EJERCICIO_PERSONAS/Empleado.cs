using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POLIMORFISMO_EJERCICIO_PERSONAS
{
    class Empleado: Persona
    {
        #region Atributos
        private int _legajo;
        private string _cargo;
        #endregion

        #region Propiedades
        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        #endregion

        #region Consultas
        public int getLegajo()
        {
            return _legajo;
        }
        public string getCargo()
        {
            return _cargo;
        }
        public override string ToString()
        {
            return "Empleado:" + _legajo + " - " + base.ToString();
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return this == null;
            else if (this.GetType() != obj.GetType())
                return false;
            else
            {
                Empleado empleado = (Empleado)obj;
                return _legajo == empleado.Legajo;
            }
        }
        public override int GetHashCode()
        {
            return _legajo * 5000;
        }
        #endregion

        #region Comandos
        public void setLegajo(int legajo)
        {
            _legajo = legajo;
        }
        public void setCargo(string cargo)
        {
            _cargo = cargo;
        }
        #endregion

        #region Constructores
        public Empleado(int dni,int legajo) : base(dni)
        {
            _legajo = legajo;
            _cargo = "";
        }

        public Empleado(int dni, string nombre, DateTime fecha_nacimiento, int legajo, string cargo) : base(dni, nombre, fecha_nacimiento)
        {
            _legajo = legajo;
            _cargo = cargo;
        }
        #endregion
    }
}
