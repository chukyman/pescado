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









    }
}
