﻿using System;
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
    public class CarreraPersistente
    {

        AccesoBD AD = new AccesoBD();


        public void updateCarrera(Carrera pobjCarrera)
        {
            List<Parametro> listaParametros = new List<Parametro>();

            //Creacion de objetos de tipo parametro para la lista de parametros

            Parametro tmp01 = new Parametro("codigo", pobjCarrera.Codigo);
            Parametro tmp02 = new Parametro("nombre", pobjCarrera.Nombre);
            Parametro tmp03 = new Parametro("id_director_academico", Convert.ToString(pobjCarrera.Id_director_academico));


            //llenado de la lista
            listaParametros.Add(tmp01);
            listaParametros.Add(tmp02);
            listaParametros.Add(tmp03);

            try
            {
                //Sentencia sql
                String sql = "UPDATE TCarrera SET " +
                                               "Codigo = codigo, " +
                                               "Nombre = nombre, " +
                                               "Apellido2 = id_director_academico, " +
                                               "WHERE Id_carrera =id_director_academico";

                //ejecucion del sql
                AD.ejecutarSQL(sql, listaParametros);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public void insertarCarrera(Carrera pobjCarrera)
        {
            List<Parametro> parametros = new List<Parametro>();
            //Creacion de objetos de tipo parametro para la lista de parametros

            //Crecion de objetos tipo Parametro 
            Parametro tmp01 = new Parametro("codigo", pobjCarrera.Codigo);
            Parametro tmp02 = new Parametro("nombre", pobjCarrera.Nombre);
            Parametro tmp03 = new Parametro("id_director_academico", Convert.ToString(pobjCarrera.Id_director_academico));

            //Llenado de la lista
            parametros.Add(tmp01);
            parametros.Add(tmp02);
            parametros.Add(tmp03);


            try
            {
                //Sentencia sql
                String sql = "INSERT INTO TCarrera (Codigo, Nombre, Id_director_academico)  VALUES (codigo,nombre,id_director_academico) ";

                //Se ejecuta el sql, del Acceso Datos
                AD.ejecutarSQL(sql, parametros);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public List<StrCarrera> listarCarreras()
        {
            StrCarrera tmpCarrera = new StrCarrera();
            List<StrCarrera> listaCarreras = new List<StrCarrera>();
            try
            {
                String cmdText;
                cmdText = Properties.Resources.PAListarCarreras;

                SqlDataReader reader = AD.ejecutarSPListar(cmdText);


                //recorror el data reader para ir creando las estructuras y agregarlas a la coleccion
                while (reader.Read())
                {
                    listaCarreras.Add(new StrCarrera(
                    tmpCarrera.Id_Carrera = reader.GetInt32(0),
                    tmpCarrera.Codigo = reader.GetValue(1).ToString(),
                    tmpCarrera.Nombre = reader.GetValue(2).ToString(),
                    tmpCarrera.Id_Director_academico = reader.GetInt32(3)

                    ));
                }
                reader.Close();

                return listaCarreras;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }


        public void eliminarCarrera(int pid_Carrera)
        {
            //Creacion de la lista de objetos de tipo parametro
            List<Parametro> parametros = new List<Parametro>();
            //Creacion e instanciación del objeto parametro
            Parametro tmp01 = new Parametro("id_carrera", Convert.ToString(pid_Carrera));
            //Se agrega el objeto a la lista de parametros
            parametros.Add(tmp01);

            try
            {
                //Sentencia sql
                String sql = "DELETE FROM TCarrera WHERE Id_carrera= id_carrera";
                //Ejecución del sql
                AD.ejecutarSQL(sql, parametros);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public Carrera buscarCarreraXid(int pid_carrera)
        {
            String cmdText;
            cmdText = Properties.Resources.PABuscarCarreraXId;
            Carrera objCarrera = null;
            try
            {
                List<Parametro> parametros = new List<Parametro>();
                Parametro tmp01 = new Parametro("id_carrera", Convert.ToString(pid_carrera));
                parametros.Add(tmp01);
                SqlDataReader reader = AD.ejecutarProcedimiento(cmdText, parametros);


                while (reader.Read())
                {
                    objCarrera= new Carrera(
                    reader.GetInt16(0),
                    reader.GetValue(1).ToString(),
                    reader.GetValue(2).ToString(),
                    reader.GetInt16(3));
                }

                return objCarrera;
            }

            catch (SqlException e)
            {
                throw e;
            }
        }


    }
}