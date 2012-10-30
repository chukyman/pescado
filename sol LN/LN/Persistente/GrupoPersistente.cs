using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using System.Data.SqlClient;
using LN.Estructuras;
//PAQUETES QUE UTILIZA
using LN.Clases;

namespace LN.Persistente
{
   public class GrupoPersistente
    {
        AccesoBD AD = new AccesoBD();

       /// <summary>
       /// 
       /// </summary>
       /// <param name="pobjGrupo"></param>
        public void insertGrupo(Grupo pobjGrupo)
        {
            List<Parametro> parametros= new List<Parametro>();
            //Creacion de objetos de tipo parametro para la lista de parametros

            //Crecion de objetos tipo Parametro 
            Parametro tmp01 = new Parametro("nombre",pobjGrupo.Nombre);
            Parametro tmp02 = new Parametro("horario", pobjGrupo.Horario);
            Parametro tmp03 = new Parametro("descripcion", pobjGrupo.Descripcion);
            Parametro tmp04 = new Parametro("idcurso",Convert.ToString(pobjGrupo.IdCurso));

            //llenado de la lista
            parametros.Add(tmp01);
            parametros.Add(tmp02);
            parametros.Add(tmp03);
            parametros.Add(tmp04);
         
            try
            {
                //Sentencia sql
                String sql = "INSERT INTO TGrupo (Nombre, Horario, Descripcion, Id_curso) VALUES(nombre, horario, descripcion,idcurso)";
               
                //Se ejecuta el sql, del Acceso Datos
                AD.ejecutarSQL(sql, parametros);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="pobjGrupo"></param>
        public void updateGrupo(Grupo pobjGrupo)
        {
            List<Parametro> listaParametros = new List<Parametro>();

            //Creacion de objetos de tipo parametro para la lista de parametros

            Parametro tmp01 = new Parametro("idgrupo", Convert.ToString(pobjGrupo.IdGrupo));
            Parametro tmp02 = new Parametro("nombre", pobjGrupo.Nombre);
            Parametro tmp03 = new Parametro("horario", pobjGrupo.Horario);
            Parametro tmp04 = new Parametro("descripcion", pobjGrupo.Descripcion);
            Parametro tmp05 = new Parametro("idcurso", Convert.ToString(pobjGrupo.IdCurso));

            //llenado de la lista
            listaParametros.Add(tmp01);
            listaParametros.Add(tmp02);
            listaParametros.Add(tmp03);
            listaParametros.Add(tmp04);
                 
            try
            {
                //Sentencia sql
                String sql = "UPDATE TGrupo SET Nombre= (nombre), Horario= (horario), Descripcion=(descripcion), Id_curso=(idcurso) " +
                         "WHERE Id_grupo=(idgrupo)";

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
        public void deleteGrupo(int pidGrupo)
        {
            //Creacion de la lista de objetos de tipo parametro
            List<Parametro> parametros = new List<Parametro>();
            //Creacion e instanciación del objeto parametro
            Parametro tmp01 = new Parametro("idgrupo", Convert.ToString(pidGrupo));
            //Se agrega el objeto a la lista de parametros
            parametros.Add(tmp01);

            try
            {
                //Sentencia sql
                String sql = "DELETE FROM TGrupo WHERE Id_grupo= idgrupo";
                //Ejecución del sql
                AD.ejecutarSQL(sql, parametros);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

       /// <summary>
       /// Metodo que busca un grupo por Id. 
       /// </summary>
       /// <param name="pidGrupo"></param>
       /// <returns>Diego Salas Arce</returns>
        public StrGrupo buscarGrupoXNombre(String pnombre)
        {
            //Creacion del datareader
            SqlDataReader drDatosGrupo;
            
            //Se crea una lista de parámetros
            List<Parametro> listaParam = new List<Parametro>();

            StrGrupo str = new StrGrupo();

            //Se crea un objeto parametro
            Parametro tmp01 = new Parametro("Nombre", pnombre);

            //Agrego el objParametro a la lista Parametros.
            listaParam.Add(tmp01);
            
            //Llamada al store procedure
            String storeProced = Properties.Resources.PABuscarGrupoXNombre.ToString();
            
            try
            {

                //Ejecuto el procedimiento y retorno los datos del grupos
                drDatosGrupo = AD.ejecutarSP_Retorna(storeProced, listaParam);

                if (drDatosGrupo.Read())
                {
                    str=(new StrGrupo(drDatosGrupo.GetInt16(0),
                                      drDatosGrupo.GetString(1).ToString(),
                                      drDatosGrupo.GetString(2).ToString(),
                                      drDatosGrupo.GetString(3).ToString(),
                                      drDatosGrupo.GetInt16(4)));
                   
                }
            }
            catch (Exception e)
            {
                throw new Exception (e.Message);
            }
            return str;
            drDatosGrupo.Close();
        }

       /// <summary>
       /// Obtiene la lista total de grupos almacenados en el sistema
       /// </summary>
       /// <returns>List de estructuras de grupos</returns>
        public List<StrGrupo> obtenerListaGrupos()
        {
            StrGrupo estructuraGrupo= new StrGrupo();
            List<StrGrupo> listaEstructurasGrupo = new List<StrGrupo>();

            try
            {
                String cmdText;
                cmdText = Properties.Resources.PAListarGrupos;

                SqlDataReader reader = AD.ejecutarSPListar(cmdText);
                //recorror el data reader para ir creando las estructuras y agregarlas a la coleccion
                while (reader.Read())
                {
                    Console.Out.WriteLine(reader.HasRows.ToString()); 
                    listaEstructurasGrupo.Add(new StrGrupo(
                                                     
                                                            estructuraGrupo.IdGrupo= reader.GetInt32(0),
                                                            estructuraGrupo.Nombre= reader.GetValue(1).ToString(),
                                                            estructuraGrupo.Horario= reader.GetValue(2).ToString(),
                                                            estructuraGrupo.Descripcion= reader.GetValue(3).ToString(),
                                                            estructuraGrupo.IdCurso= reader.GetInt32(4)
                                                            ));
                }
                reader.Close();

                return listaEstructurasGrupo;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
