using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Estructuras
{
    public class StrRol
    {
        
        private string _idRol;
        private string _nombreRol;
        private string _numeroRol;

        public StrRol()
        {

        }


        public StrRol( string pnombreRol, string pnumeroRol)
        {
            NombreRol = pnombreRol;
            NumeroRol = pnumeroRol;
        }


        public StrRol(string pidRol, string pnombreRol, string pnumeroRol)
        {
            IdRol = pidRol;
            NombreRol = pnombreRol;
            NumeroRol = pnumeroRol;
              

        }


        public string IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }


        public string NombreRol
        {
            get { return _nombreRol; }
            set { _nombreRol = value; }
        }


        public string NumeroRol
        {
            get { return _numeroRol; }
            set { _numeroRol = value; }
        }


    }
}
