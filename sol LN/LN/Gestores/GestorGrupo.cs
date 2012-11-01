using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//PAQUETES QUE UTILIZA
using LN.Clases;
using LN.Persistente;
using LN.Estructuras;

namespace LN.Gestores
{
    public class GestorGrupo
    {

        /// <summary>
        /// Registra un grupo en el sistema
        /// </summary>
        /// <param name="pnombre"></param>
        /// <param name="phorario"></param>
        /// <param name="pdescripcion"></param>
        /// <param name="pidCurso"></param>
        public static void registrarGrupo(String pnombre, String phorario, String pdescripcion, int pcantEstudiantes ,int pidCurso)
        {
            //Creacion del objeto grupo
            Grupo objGrupo;

            //instanciación del objeto grupo con los valores que me pasan por parámetros.
            objGrupo = new Grupo(pnombre, phorario, pdescripcion, pcantEstudiantes, pidCurso);
            GrupoPersistente objGrupoPersistente = new GrupoPersistente();
            objGrupoPersistente.insertGrupo(objGrupo);
        }


        /// <summary>
        /// Modifica los datos de un grupo
        /// </summary>
        /// <param name="pnombre"></param>
        /// <param name="phorario"></param>
        /// <param name="pdescripcion"></param>
        /// <param name="pidCurso"></param>
        public static void modificarGrupo(String pnombre, String phorario, String pdescripcion, int pcantEstudiantes ,int pidCurso)
        {

            Grupo objGrupo = new Grupo(pnombre, phorario, pdescripcion, pcantEstudiantes, pidCurso);
            GrupoPersistente grupoP = new GrupoPersistente();
            grupoP.updateGrupo(objGrupo);
        }


        public static void eliminarGrupo()
        {

        }
        /// <summary>
        /// Obtiene un grupo determinado por medio del nombre del grupo
        /// </summary>
        /// <param name="pidCurso"></param>
        /// <returns></returns>
        public static StrGrupo obtenerGrupoXNombre(String pnombre)
        {
            GrupoPersistente grupoP = new GrupoPersistente();
            StrGrupo strG = grupoP.buscarGrupoXNombre(pnombre);

            return strG;
        }

        /// <summary>
        /// Lista los grupos almacenados en el sistema
        /// </summary>
        /// <returns></returns>
        public static List<StrGrupo> listarGrupos()
        {

            try
            {
                List<StrGrupo> listadoGrupos = new List<StrGrupo>();
                GrupoPersistente grupoPersistente = new GrupoPersistente();
                listadoGrupos = grupoPersistente.obtenerListaGrupos();
                return listadoGrupos;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
