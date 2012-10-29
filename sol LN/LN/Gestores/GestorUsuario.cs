using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Paquetes Usados
using LN.Persistente;
using LN.Clases;
using LN.Estructuras;

namespace LN.Gestores
{
    public class GestorUsuario
    {
        
        /// <summary>
        /// Procedimient encargado de registrar un Usuario
        /// </summary>
        /// <param name="pcedula"></param>
        /// <param name="pnombre"></param>
        /// <param name="papellido1"></param>
        /// <param name="papellido2"></param>
        /// <param name="pcorreo"></param>
        /// <param name="pgnero"></param>
        /// <param name="pidRol"></param>
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
        
        /// <summary>
        /// Metodo Encargado de listar los usuarios del sistema
        /// </summary>
        /// <returns></returns>
        public static List<StrUsuario> listarUsuario()
        {
            try
            {
                UsuarioPersistente objUsuarioPersistente = new UsuarioPersistente();
                List<StrUsuario> listado = objUsuarioPersistente.listarUsuarios();
                return listado;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Procedimiento encargado de actualizar un usuario.
        /// </summary>
        /// <param name="pnombre"></param>
        /// <param name="phorario"></param>
        /// <param name="pdescripcion"></param>
        /// <param name="pidCurso"></param>
        public static void actualizarUsuario(string pcedula, string pnombre, string papellido1, 
                                            string papellido2, string pcorreo, char pgnero, int pidRol)
        {

            Usuario objUsuario = new Usuario(pcedula, pnombre, papellido1, 
                                             papellido2,  pcorreo,  pgnero,  pidRol);
            UsuarioPersistente objUsuarioPersistente = new UsuarioPersistente();
            objUsuarioPersistente.updateUsuario(objUsuario);
        }

        public static void eliminarUsuario(string pcedula)
        {
                   
            UsuarioPersistente objUsuarioPersistente = new UsuarioPersistente();
            objUsuarioPersistente.eliminarUsuario(pcedula);
        }


        /// <summary>
        /// Buscar Usario por el numero de cedula
        /// </summary>
        /// <param name="pcedula"></param>
        /// <returns></returns>
        public static Array buscarUsuarioCedula(string pcedula)
        {

            StrUsuario objStrUsuario = (new UsuarioPersistente().buscarUsuarioXCedula(pcedula));

            String[] datosUsuario = new String[] {objStrUsuario.Nombre,
                                                objStrUsuario.Apellido1, 
                                                objStrUsuario.Apellido2, 
                                                objStrUsuario.Cedula,
                                                objStrUsuario.Correo, 
                                                objStrUsuario.Genero,
                                                objStrUsuario.NombreRol
                                                };

            return datosUsuario;
        }
    


    }
}
