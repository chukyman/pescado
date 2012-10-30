using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// PAQUETES
using LN.Persistente;
using AccesoDatos;
using LN.Estructuras;




//PAQUETES
using LN.Clases;
using System.Data.SqlClient;
using System.Data;

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

        /// <summary>
        /// 
        /// </summary>
        /// <returns> List<StrUsuario> Una lista de Estructura Usuario</returns>
         public List<StrUsuario> listarUsuarios()
         {
             StrUsuario tmpUsuario = new StrUsuario();
             List<StrUsuario> listaUsuarios = new List<StrUsuario>();
             try
             {
                 String cmdText;
                 cmdText = Properties.Resources.PAListarUsuarios;
                           
                 SqlDataReader reader = AD.ejecutarSPListar(cmdText);
                                  //recorror el data reader para ir creando las estructuras y agregarlas a la coleccion
                 while (reader.Read())
                 {
                     listaUsuarios.Add(new StrUsuario(
                     tmpUsuario.IdRol = reader.GetValue(0).ToString(),
                     tmpUsuario.Cedula = reader.GetValue(1).ToString(),
                     tmpUsuario.Nombre = reader.GetValue(2).ToString(),
                     tmpUsuario.Apellido1 = reader.GetValue(3).ToString(),
                     tmpUsuario.Apellido2 = reader.GetValue(4).ToString(),
                     tmpUsuario.Correo = reader.GetValue(5).ToString(),
                     tmpUsuario.Genero = reader.GetValue(6).ToString(),
                     tmpUsuario.NombreRol = reader.GetValue(7).ToString()
                     ));
                 }
                 reader.Close();
                     return listaUsuarios;
             }
             catch (SqlException e)
             {
                 throw e;
             }
         }


         /// <summary>
         /// 
         /// </summary>
         /// <param name="pobjUsuario"></param>
         public void updateUsuario(Usuario pobjUsuario)
         {
             List<Parametro> listaParametros = new List<Parametro>();

             //Creacion de objetos de tipo parametro para la lista de parametros

            Parametro tmp01 = new Parametro("cedula", pobjUsuario.Cedula);
            Parametro tmp02 = new Parametro("nombre", pobjUsuario.Nombre);
            Parametro tmp03 = new Parametro("apellido1", pobjUsuario.Apellido1);
            Parametro tmp04 = new Parametro("apellido2", pobjUsuario.Apellido2);
            Parametro tmp05 = new Parametro("correo_electronico", pobjUsuario.Correo);
            Parametro tmp06 = new Parametro("genero", Convert.ToString(pobjUsuario.Genero));
            Parametro tmp07 = new Parametro("iD_Rol", Convert.ToString(pobjUsuario.IdRol));

             //llenado de la lista
             listaParametros.Add(tmp01);
             listaParametros.Add(tmp02);
             listaParametros.Add(tmp03);
             listaParametros.Add(tmp04);
             listaParametros.Add(tmp05);
             listaParametros.Add(tmp06);
             listaParametros.Add(tmp07);

             try
             {
                 //Sentencia sql
                 String sql = "UPDATE TUSUARIO SET " +
                                                "Nombre = nombre, " +
                                                "Apellido1 = apellido1, " +
                                                "Apellido2 = apellido2, " +
                                                "Correo_electronico = correo_electronico, " +
                                                "Genero = genero, " +
                                                "Id_rol = iD_Rol " +
                               "WHERE Cedula = cedula ";
                                       
                 //ejecucion del sql
                 AD.ejecutarSQL(sql, listaParametros);
             }
             catch (Exception e)
             {
                 throw new Exception(e.Message);
             }
         }

         /// <summary>
         ///  
         /// </summary>
         /// <param name="pidGrupo"></param>
         public void eliminarUsuario(string pCedula)
         {
             //Creacion de la lista de objetos de tipo parametro
             List<Parametro> parametros = new List<Parametro>();
             //Creacion e instanciación del objeto parametro
             Parametro tmp01 = new Parametro("cedula", Convert.ToString(pCedula));
             //Se agrega el objeto a la lista de parametros
             parametros.Add(tmp01);

             try
             {
                 //Sentencia sql
                 String sql = "DELETE FROM TUsuario WHERE Cedula= cedula";
                 //Ejecución del sql
                 AD.ejecutarSQL(sql, parametros);
             }
             catch (Exception e)
             {
                 throw new Exception(e.Message);
             }
         }


         /// <summary>
         /// 
         /// </summary>
         /// <param name="pcedula"></param>
         /// <returns></returns>
         public StrUsuario buscarUsuarioXCedula(string pcedula)
         {
             //Creacion del datareader
             SqlDataReader drDatosUsuario;
             //Creacion del objeto grupo
             StrUsuario objStrUsuario = null;
             //Se crea una lista de parámetros
             List<Parametro> listaParam = new List<Parametro>();

             //Se crea un objeto parametro 
             Parametro tmp01 = new Parametro("cedula", pcedula);
             //Agrego el objParametro a la lista Parametros.
             listaParam.Add(tmp01);

             //Llamada al store procedure
             String storeProced = Properties.Resources.PAlistarUsuariosCedula.ToString();

             try
             {
                 //Ejecuto el procedimiento y retorno los datos del usuario
                 drDatosUsuario = AD.ejecutarSP_Retorna(storeProced, listaParam);





                 if (drDatosUsuario.Read())
                 {
                     objStrUsuario = new StrUsuario(
                                         drDatosUsuario.GetInt64(0).ToString(),
                                         drDatosUsuario.GetString(1).ToString(),
                                         drDatosUsuario.GetString(2).ToString(),
                                         drDatosUsuario.GetString(3).ToString(),
                                         drDatosUsuario.GetString(4).ToString(),
                                         drDatosUsuario.GetString(5).ToString(),
                                         drDatosUsuario.GetString(6).ToString(),
                                         drDatosUsuario.GetString(7).ToString());
                 }
                
                 return objStrUsuario;
              //  drDatosUsuario.Close();
             }
             catch (Exception e)
             {
                 throw new Exception(e.Message);
             }

         }


        



    }
}
