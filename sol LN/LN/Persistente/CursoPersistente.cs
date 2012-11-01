using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LN.Clases;
using AccesoDatos;
using LN.Estructuras;
using System.Data.SqlClient;

namespace LN.Persistente
{
   public class CursoPersistente
    {
       AccesoBD acceso = new AccesoBD();
        public void insertar(Curso pobjCurso){

            List<Parametro> parametros= new List<Parametro>();
                Parametro tmp01 = new Parametro("codigo",pobjCurso.Codigo);
                Parametro tmp02 = new Parametro("nombre",pobjCurso.Nombre);
                Parametro tmp03 = new Parametro("idCarrera",Convert.ToString(pobjCurso.IdCarrera));
                Parametro tmp04 = new Parametro("estado", Convert.ToString(pobjCurso.Estado));
               
                parametros.Add(tmp01);
                parametros.Add(tmp02);
                parametros.Add(tmp03);
                parametros.Add(tmp04);

                try
                {   
                    //Consulta
                    String sql = "INSERT INTO TCurso (Codigo, Nombre, Id_carrera, Estado) VALUES(codigo, nombre,  idCarrera, estado) "; 
                    acceso.ejecutarSQL_NoRetorna(sql, parametros);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
        }


        public void modificar(Curso pobjCurso)
        {
            List<Parametro> parametros = new List<Parametro>();
            Parametro tmp01 = new Parametro("codigo", pobjCurso.Codigo);
            Parametro tmp02 = new Parametro("nombre", pobjCurso.Nombre);
            Parametro tmp03 = new Parametro("id_carrera", Convert.ToString(pobjCurso.IdCarrera));
            Parametro tmp04 = new Parametro("estado", Convert.ToString(pobjCurso.Estado));
            

            parametros.Add(tmp01);
            parametros.Add(tmp02);
            parametros.Add(tmp03);
            parametros.Add(tmp04);

            String pstoreName = "PA_modificar_curso";

            try
            {
                //Consulta

                acceso.ejecutarSQL_NoRetorna(pstoreName, parametros);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public void eliminar(String pcodigo)
        {

            List<Parametro> parametros = new List<Parametro>();
            Parametro tmp01 = new Parametro("codigo", pcodigo);

            parametros.Add(tmp01);

            String pstoreName = "PA_eliminar_curso";

            try
            {
                //Consulta

                acceso.ejecutarSQL_NoRetorna(pstoreName, parametros);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }



        public StrCurso buscarCodigo(String pcodigo)
        {
            
            SqlDataReader drDatosCurso;

            
            List<Parametro> parametros = new List<Parametro>();

            StrCurso str = new StrCurso();

            
            Parametro tmp01 = new Parametro("Codigo", pcodigo);

            
            parametros.Add(tmp01);

            
            String storeProced = Properties.Resources.PABuscarCursoXCodigo.ToString();

            try
            {

                
                drDatosCurso = acceso.ejecutarSP_Retorna(storeProced, parametros);

                if (drDatosCurso.Read())
                {
                   
                    str = (new StrCurso(
                                     
                                        drDatosCurso.GetValue(0).ToString(),
                                        drDatosCurso.GetValue(1).ToString(),
                                        drDatosCurso.GetValue(2).ToString()
                                        ));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return str;
            drDatosCurso.Close();
        }


        public StrCurso buscarNombre(String pnombre)
        {

            SqlDataReader drDatosCurso;


            List<Parametro> parametros = new List<Parametro>();

            StrCurso str = new StrCurso();


            Parametro tmp01 = new Parametro("Nombre", pnombre);


            parametros.Add(tmp01);


            String storeProced = Properties.Resources.PABuscarCursoXNombre.ToString();

            try
            {


                drDatosCurso = acceso.ejecutarSP_Retorna(storeProced, parametros);

                if (drDatosCurso.Read())
                {

                    str = (new StrCurso(

                                        drDatosCurso.GetValue(0).ToString(),
                                        drDatosCurso.GetValue(1).ToString(),
                                        drDatosCurso.GetValue(2).ToString()
                                        ));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return str;
            drDatosCurso.Close();
        }


    }
}
