using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POLIMORFISMO_EJERCICIO_PERSONAS
{
    class Estudiante: Persona
    {
        #region Atributos
        private int _legajo;
        private string _carrera;
        #endregion

        #region Propiedades
        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        public string Carrera
        {
            get { return _carrera; }
            set { _carrera = value; }
        }
        #endregion

        #region Consultas
        public int getLegajo()
        {
            return _legajo;
        }
        public string getCarrera()
        {
            return _carrera;
        }
        public override string ToString()
        {
            return "Estudiante:" + _legajo + " - " + base.ToString();
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return this == null;
            else if (this.GetType() != obj.GetType())
                return false;
            else
            {
                Estudiante estudiante = (Estudiante)obj;
                return _legajo == estudiante.Legajo;
            }
        }
        public override int GetHashCode()
        {
            return _legajo * 3500;
        }
        #endregion

        #region Comandos
        public void setLegajo(int legajo)
        {
            _legajo = legajo;
        }

        public void setCarrera(string carrera)
        {
            _carrera = carrera;
        }
        #endregion

        #region Constructores
        public Estudiante(int dni, int legajo) : base(dni)
        {
            _legajo = legajo;
            _carrera = "";
        }

        public Estudiante(int dni, string nombre, DateTime fecha_nacimiento, int legajo, string carrera) : base(dni, nombre, fecha_nacimiento)
        {
            _legajo = legajo;
            _carrera = carrera;
        }
        #endregion
    }
}
