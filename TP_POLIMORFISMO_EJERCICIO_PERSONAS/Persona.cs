using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POLIMORFISMO_EJERCICIO_PERSONAS
{
    class Persona
    {
        #region Atributos
        private int _dni;
        private string _nombre;
        private DateTime _fecha_nacimiento;
        #endregion

        #region Propiedades
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fecha_nacimiento; }
            set { _fecha_nacimiento = value; }
        }
        #endregion

        #region Consultas
        public int getDNI()
        {
            return _dni;
        }

        public string getNombre()
        {
            return _nombre;
        }
        
        public DateTime getFechaNacimiento()
        {
            return _fecha_nacimiento;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return this == null;
            else if (this.GetType() != obj.GetType())
                return false;
            else
            {
                Persona p = (Persona)obj;
                return _dni == p.Dni;
            }
        }
        public override int GetHashCode()
        {
            return _dni * 2500;
        }

        public override string ToString()
        {
            return "DNI " + _dni + " - " + _nombre;
        }
        #endregion

        #region Comandos
        public void setDNI(int dni)
        {
            _dni = dni;
        }
        public void setNombre(string nombre)
        {
            _nombre = nombre;
        }
        public void setFechaNacimiento(DateTime fecha_nacimiento)
        {
            _fecha_nacimiento = fecha_nacimiento;
        }
        #endregion

        #region Constructores
        public Persona(int dni, string nombre, DateTime fecha_nacimiento)
        {
            if (dni > 0 && fecha_nacimiento <= DateTime.Today)
            {
                _dni = dni;
                _nombre = nombre;
                _fecha_nacimiento = fecha_nacimiento;
            }
        }
        public Persona(int dni)
        {
            _dni = dni;
            _nombre = "";
            _fecha_nacimiento = DateTime.Today;
        }
        #endregion
    }
}
