using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModelo
{
    public class Persona
    {
        private String _rut;
        public String Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        private String _razonSocial;

        public String RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        private String _nombre;

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private String _direccion;

        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private int _telefono;

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private String _actividad;

        public String Actividad
        {
            get { return _actividad; }
            set { _actividad = value; }
        }

        private char _tipo;

        public char Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public Persona()
        {
                
        }
    }
}
