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
        public Grupo buscarGrupoXId(int pidGrupo)
        {
            //Creacion del datareader
            SqlDataReader drDatosGrupo;
            //Creacion del objeto grupo
            Grupo objGrupo= null;
            //Se crea una lista de parámetros
            List<Parametro> listaParam = new List<Parametro>();
            
            //Se crea un objeto parametro 
            Parametro tmp01 = new Parametro("idgrupo", Convert.ToString(pidGrupo));
            //Agrego el objParametro a la lista Parametros.
            listaParam.Add(tmp01);

            //Llamada al store procedure
            String storeProced = Properties.Resources.PABuscarGrupo.ToString();
            
            try
            {
                //Ejecuto el procedimiento y retorno los datos del grupos
                drDatosGrupo = AD.ejecutarProcedimiento(storeProced, listaParam);

                if (drDatosGrupo.Read())
                {
                    objGrupo = new Grupo(
                                        drDatosGrupo.GetString(0),
                                        drDatosGrupo.GetString(1),
                                        drDatosGrupo.GetString(2),
                                        drDatosGrupo.GetInt16(3));
                }
                drDatosGrupo.Close();
                return objGrupo;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        public List<StrGrupo> obtenerListaGrupos()
        {
            StrGrupo estructuraGrupo= new StrGrupo();
            List<StrGrupo> listaEstructurasGrupo = new List<StrGrupo>();

            try
            {
                String cmdText;
                cmdText = Properties.Resources.PAListarCarreras;

                SqlDataReader reader = AD.ejecutarSPListar(cmdText);
                //recorror el data reader para ir creando las estructuras y agregarlas a la coleccion
                while (reader.Read())
                {
                    listaEstructurasGrupo.Add(new StrGrupo(
                                                            estructuraGrupo.IdGrupo= reader.GetInt16(0),
                                                            estructuraGrupo.Nombre= reader.GetString(1),
                                                            estructuraGrupo.Horario= reader.GetString(2),
                                                            estructuraGrupo.Descripcion= reader.GetString(3),
                                                            estructuraGrupo.IdCurso= reader.GetInt16(4)
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

       /// <summary>
       /// Obtengo el total de grupos por el codigo del curso
       /// </summary>
       /// <returns></returns>
        public List<Grupo> obtenerlistaGruposXIdCurso(int pidCurso)
        {
            //declaro el datareader de lista de grupos
            SqlDataReader drListaGrupos;
            //Declaro lista de objetos grupo
            List<Grupo> listaGrupos = new List<Grupo>();

            //Declaro una lista de parametros
            List<Parametro> listaParam= new List<Parametro>();
            //Se crea el objeto parametro y se establecen los datos del objeto
            Parametro tmp01 = new Parametro("idcurso", Convert.ToString(pidCurso));
            //Agrego el parametro dentro de la lista
            listaParam.Add(tmp01);

            try
            {
                //invocar el procedimiento almacenado
                String storeProced = Properties.Resources.PAListarGrupoXCurso;
                //Ejecuto el procedimiento y retorna un datareader de grupos
                drListaGrupos= AD.ejecutarProcedimiento(storeProced,listaParam);

                while(drListaGrupos.Read())
                {
                    //Creo el objeto y lo agrego a la lista de grupos
                    listaGrupos.Add(new Grupo(
                                                drListaGrupos.GetString(0),
                                                drListaGrupos.GetString(1),
                                                drListaGrupos.GetString(2),
                                                drListaGrupos.GetInt16(3)
                                                ));
                }
                //Cierro el datareader
                drListaGrupos.Close();
                return listaGrupos;
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
