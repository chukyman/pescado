using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Clases
{
    public class Rol
    {

        private int _idRol;
        private string _nombreRol;
        private char _numeroRol;

        public Rol()
        {

        }


        public Rol( string pnombreRol, char pnumeroRol)
        {
            NombreRol = pnombreRol;
            NumeroRol = pnumeroRol;
        }


        public Rol(int pidRol, string pnombreRol, char pnumeroRol)
        {
            IdRol = pidRol;
            NombreRol = pnombreRol;
            NumeroRol = pnumeroRol;
              

        }


        public int IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }


        public string NombreRol
        {
            get { return _nombreRol; }
            set { _nombreRol = value; }
        }


        public char NumeroRol
        {
            get { return _numeroRol; }
            set { _numeroRol = value; }
        }



    }
}
