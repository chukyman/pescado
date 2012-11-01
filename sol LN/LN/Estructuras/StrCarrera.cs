using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Estructuras
{
    public struct StrCarrera
    {


        //================================================================================
        // Atributos 
        //================================================================================

        private int _Id_Carrera;
        private String _Codigo;
        private String _Nombre;
        private int _Id_Director_academico;
        private String _nombre_DA;



        //================================================================================
        // Constructoresm
        //================================================================================


        public StrCarrera(int pid_carrera, String pcodigo, String pnombre, int pid_director_academico, string pnombre_NA)
        {
            _Id_Carrera = pid_carrera;
            _Codigo = pcodigo;
            _Nombre = pnombre;
            _Id_Director_academico = pid_director_academico;
            _nombre_DA = pnombre_NA;

        }


        //================================================================================
        // Get &  Set
        //================================================================================

        public int Id_Carrera
        {
            get { return _Id_Carrera; }
            set { _Id_Carrera = value; }
        }

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public int Id_Director_academico
        {
            get { return _Id_Director_academico; }
            set { _Id_Director_academico = value; }
        }

        public String Nombre_DA
        {
            get { return _nombre_DA; }
            set { _nombre_DA = value; }
        }




    }



}