using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Estructuras
{
    public class StrGrupo
    {

        //Atributos
        private String _nombre;
        private String _horario;
        private String _descripcion;
        private String _nombreGrupo;

        public StrGrupo(String pnombre, String phorario, String pdescripcion, String pnombreCurso)
        {
            Nombre = pnombre;
            Horario = phorario;
            Descripcion = pdescripcion;
            NombreGrupo = pnombreCurso;
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public String NombreGrupo
        {
            get { return _nombreGrupo; }
            set { _nombreGrupo = value; }
        }
    }
}
