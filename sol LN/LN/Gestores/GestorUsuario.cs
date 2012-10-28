using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LN.Persistente;
using LN.Clases;


namespace LN.Gestores
{
    public class GestorUsuario
    {
        
        public static void registrarUsuario(string pcedula, string pnombre, string papellido1, 
                                            string papellido2, string pcorreo, char pgnero, int pidRol)
        {
            //Creacion y Instancia del objeto Usuario persistente
            UsuarioPersistente objUsuarioPersistente = new UsuarioPersistente();
            //Creacion del objeto Usuario
            Usuario objUsuario;
            //Instanciación del objeto usuario con los valores que me pasan por parámetros.
            objUsuario = new Usuario(pcedula, pnombre, papellido1, papellido2, pcorreo, pgnero, pidRol);

            //
            objUsuarioPersistente.insertarUsuario(objUsuario);
        }

    }
}
