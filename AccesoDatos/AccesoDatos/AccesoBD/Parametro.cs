using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccesoDatos.Clases
{
    public class Parametro
    {
        private String mNombre;
        private String mDato;

        //Constructor
        public Parametro(String pnombre, String pdato)
        {
            Nombre = pnombre;
            Dato = pdato;
        }

        // Declare una propiedad Nombre como String
        public string Nombre
        {
            get
            {
                return mNombre;
            }
            set
            {
                mNombre = value;
            }
        }
        // Declare una propiedad Dato como String
        public String Dato
        {
            get
            {
                return mDato;
            }

            set
            {
                mDato = value;
            }
        }

        
        
    }
}
