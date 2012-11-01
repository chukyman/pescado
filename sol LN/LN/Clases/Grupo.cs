using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Clases
{
    public class Grupo
    {
        //================================================================================
        // Atributos 
        //================================================================================
        private int _idGrupo;
        private String _nombre;
        private String _horario;
        private String _descripcion;
        private int _cantEstudiantes;

        
        private int _idCurso;

        //private List<Foro> listaForos;


        //================================================================================
        // Constructores
        //================================================================================
        public Grupo(String pnombre, String phorario, String pdescripcion, int pcantEstudiantes, int pidCurso)
        {
            Nombre = pnombre;
            Horario = phorario;
            Descripcion = pdescripcion;
            CantEstudiantes = pcantEstudiantes;
            IdCurso = pidCurso;
        }


        //================================================================================
        // Get &  Set
        //================================================================================
        public Grupo(int pidGrupo, String pnombre, String phorario, String pdescripcion, int pcantEstudiantes ,int pidCurso)
        {
            IdGrupo = pidGrupo;
            Nombre = pnombre;
            Horario = phorario;
            Descripcion = pdescripcion;
            CantEstudiantes = pcantEstudiantes;
            IdCurso = pidCurso;
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

        public int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }
    }
    
}
