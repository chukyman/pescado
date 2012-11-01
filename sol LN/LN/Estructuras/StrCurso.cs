using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Estructuras
{
    class StrCurso
    {
        //Atributos
        private string _codigo;
        private string _nombre;
        private string _estado;

        
        


        //Costructores

        public StrCurso(string pcodigo, string pnombre, string pestado){
            _codigo = pcodigo;
            _nombre = pnombre;
            _estado = pestado;

        }



        //Set y get


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

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


    }
}
