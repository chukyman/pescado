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
    public class GestorCarrera
    {

        public static void registrarCarrera(string pcodigo, string pnombre, int pid_director_academico)
        {

            //Creacion y Instancia del objeto Carrera persistente
            CarreraPersistente objCarreraPersistente = new CarreraPersistente();
            //Creacion del objeto Carrera
            Carrera objCarrera;
            //Instanciación del objeto Carrera con los valores que me pasan por parámetros.
            objCarrera = new Carrera(pcodigo, pnombre, pid_director_academico);

            //
            objCarreraPersistente.insertarCarrera(objCarrera);


        }
        

        public static List<StrCarrera> listarCarrera()
        {
            try
            {
                CarreraPersistente objCarreraPersistente = new CarreraPersistente();
                List<StrCarrera> listado = objCarreraPersistente.listarCarreras();
                return listado;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        




        public static void actualizarCarrera(int pidcarrera, string pcodigo, string pnombre, int pid_directoracademico)
        {
            
            Carrera objCarrera = new Carrera(pidcarrera, pcodigo, pnombre, pid_directoracademico);
            CarreraPersistente objCarreraPersistente = new CarreraPersistente();
            objCarreraPersistente.updateCarrera(objCarrera);
        }

        public static void eliminarCarrera(int pid_Carrera)
        {

            CarreraPersistente objCarreraPersistente = new CarreraPersistente();
            objCarreraPersistente.eliminarCarrera(pid_Carrera);

        }

        public static StrCarrera buscarCarrera(String pnombre)
        {
            CarreraPersistente objCarreraPersistente = new CarreraPersistente();
            StrCarrera carrera = objCarreraPersistente.buscarCarreraXNombre(pnombre);
            return carrera;

        }
    }



}
