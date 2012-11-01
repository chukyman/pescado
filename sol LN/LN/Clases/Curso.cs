using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Clases
{
   public class Curso
    {
        //Atributos
        private string _codigo;
        private string _nombre;
        private int _idCarrera;
        private Boolean _estado;
        //private Carrera _objCarrera;


        //Constructor

        public Curso(string pcodigo, string pnombre, int pidCarrera, Boolean pestado){
            _codigo = pcodigo;
            _nombre = pnombre;
            _idCarrera = pidCarrera;
            _estado = pestado;
        
        }



        //Get y Set

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int IdCarrera
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
        }

        public Boolean Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


    }

}
