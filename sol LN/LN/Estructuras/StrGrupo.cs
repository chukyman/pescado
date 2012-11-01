using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Estructuras
{
    public struct StrGrupo
    {

        //================================================================================
        // Atributos 
        //================================================================================
        private int _idGrupo;
        private String _nombre;
        private String _horario;
        private String _descripcion;
        private int _cantEstudiantes;
        private String _nomCurso;
        
        //================================================================================
        // Constructores
        //================================================================================
        public StrGrupo(int pidGrupo, String pnombre, String phorario, String pdescripcion, int pcantEstudiantes ,String pnomCurso)
        {
            _idGrupo = pidGrupo;
            _nombre = pnombre;
            _horario = phorario;
            _descripcion = pdescripcion;
            _cantEstudiantes = pcantEstudiantes;
            _nomCurso = pnomCurso;
        }

        public int IdGrupo
        {
            get { return _idGrupo; }
            set { _idGrupo = value; }
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

        public int CantEstudiantes
        {
            get { return _cantEstudiantes; }
            set { _cantEstudiantes = value; }
        }

        public String NomCurso
        {
            get { return _nomCurso; }
            set { _nomCurso = value; }
        }

        public String NombreCompleto
        {
            get { return _nombre + " " + _horario;  }
        }
    }
}
