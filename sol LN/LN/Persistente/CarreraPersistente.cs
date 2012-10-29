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




    }
}
