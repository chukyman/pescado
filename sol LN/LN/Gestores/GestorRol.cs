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
    public  class GestorRol
    {


        /// <summary>
        /// Metodo Encargado de listar los usuarios del sistema
        /// </summary>
        /// <returns></returns>
        public static List<StrRol> listarRoles()
        {
            try
            {
                RolPersistente objRolPersistente = new RolPersistente();
                List<StrRol> listado = objRolPersistente.listarRoles();
                return listado;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
