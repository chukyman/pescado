﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//PAQUETES QUE UTILIZA
using LN.Clases;
using LN.Persistente;


namespace LN.Gestores
{
    public class GestorGrupo
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pnombre"></param>
        /// <param name="phorario"></param>
        /// <param name="pdescripcion"></param>
        /// <param name="pidCurso"></param>
        public static void registrarGrupo(String pnombre, String phorario, String pdescripcion, int pidCurso)
        {
            //Creacion del objeto grupo
            Grupo objGrupo;

            //instanciación del objeto grupo con los valores que me pasan por parámetros.
            objGrupo = new Grupo(pnombre, phorario, pdescripcion, pidCurso);
            GrupoPersistente objGrupoPersistente = new GrupoPersistente();
            objGrupoPersistente.insertGrupo(objGrupo);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pnombre"></param>
        /// <param name="phorario"></param>
        /// <param name="pdescripcion"></param>
        /// <param name="pidCurso"></param>
        public static void modificarGrupo(String pnombre, String phorario, String pdescripcion, int pidCurso)
        {

            Grupo objGrupo = new Grupo(pnombre, phorario, pdescripcion, pidCurso);
            GrupoPersistente grupoP = new GrupoPersistente();
            grupoP.updateGrupo(objGrupo);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="pidCurso"></param>
        /// <returns></returns>
        public Array buscarGrupos(int pidGrupo)
        {

            Grupo objGrupo = (new GrupoPersistente().buscarGrupoXId(pidGrupo));

            String[] datosGrupo = new String[] {objGrupo.Nombre,
                                                objGrupo.Horario, 
                                                objGrupo.Descripcion, 
                                                Convert.ToString(objGrupo.IdCurso)
                                                };

            return datosGrupo;
        }

        //public List<Array> obtenerListaGruposXCurso(int pidCurso)
        //{
        //    List<Array> datosListaGrupos = new List<Array>();
        //    List<Grupo> listaGrupos = (new GrupoPersistente().obtenerlistaGruposXIdCurso(pidCurso));


        //    for (int i = 0; i < listaGrupos.Count; i++)
        //    {

        //        String[] datosGrupo = new String[] {objGrupo.Nombre,
        //                                        objGrupo.Horario, 
        //                                        objGrupo.Descripcion, 
        //                                        Convert.ToString(objGrupo.IdCurso)
        //                                        };
        //    }
        //}
    }
}