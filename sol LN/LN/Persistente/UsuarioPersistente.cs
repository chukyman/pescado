using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using LN.Persistente;
using AccesoDatos;


//PAQUETES
using LN.Clases;

namespace LN.Persistente
{
    public class UsuarioPersistente
    {
        AccesoBD AD = new AccesoBD();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pobjUsuario"></param>
         public void insertarUsuario(Usuario pobjUsuario)
        {
            List<Parametro> parametros = new List<Parametro>();
            //Creacion de objetos de tipo parametro para la lista de parametros

            //Crecion de objetos tipo Parametro 
            Parametro tmp01 = new Parametro("cedula", pobjUsuario.Cedula);
            Parametro tmp02 = new Parametro("nombre", pobjUsuario.Nombre);
            Parametro tmp03 = new Parametro("apellido1", pobjUsuario.Apellido1);
            Parametro tmp04 = new Parametro("apellido2", pobjUsuario.Apellido2);
            Parametro tmp05 = new Parametro("correo_electronico", pobjUsuario.Correo);
            Parametro tmp06 = new Parametro("genero", Convert.ToString(pobjUsuario.Genero));
            Parametro tmp07 = new Parametro("iD_Rol", Convert.ToString(pobjUsuario.IdRol));

            //Llenado de la lista
            parametros.Add(tmp01);
            parametros.Add(tmp02);
            parametros.Add(tmp03);
            parametros.Add(tmp04);
            parametros.Add(tmp05);
            parametros.Add(tmp06);
            parametros.Add(tmp07);
             
            try
            {
                //Sentencia sql
                String sql = "INSERT INTO TUsuario (Cedula, Nombre, Apellido1, Apellido2, Correo_electronico, " +
                            " Genero, ID_Rol ) VALUES(cedula, nombre, apellido1, apellido2, correo_electronico, " +
                            " genero, iD_Rol)";

                //Se ejecuta el sql, del Acceso Datos
                AD.ejecutarSQL(sql, parametros);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
