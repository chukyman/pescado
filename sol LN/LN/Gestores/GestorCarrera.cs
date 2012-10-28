using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//PAQUETES QUE UTILIZA
using LN.Clases;
using LN.Persistente;

namespace LN.Gestores
{
    public class GestorCarrera
    {

        //================================================================================
        // Metodo Agregar Carrera
        //
        //================================================================================

        public static void agregarCarrera(String pcodigo, String pnombre, int pid_director_academico)
        {

            try
            {

                //Creacion del objeto Carrera con los parametros
                Carrera objcarrera = new Carrera(pcodigo, pnombre, pid_director_academico);
                //Creacion y Instancia del objeto Usuario persistente
                CarreraPersistente carreraPer = new CarreraPersistente();
                carreraPer.insertCarrera(objcarrera);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }

}
