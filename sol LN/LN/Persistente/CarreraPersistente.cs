using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using System.Data.SqlClient;

//PAQUETES QUE UTILIZA
using LN.Clases;

namespace LN.Persistente
{
   

        public class CarreraPersistente
    {
        AccesoBD AD = new AccesoBD();

        public void insertCarrera( Carrera  pobjCarrera)
        {
            List<Parametro> parametros = new List<Parametro>();
            //Creacion de objetos de tipo parametro para la lista de parametros

            Parametro tmp01 = new Parametro("Codigo", pobjCarrera.Codigo);
            Parametro tmp02 = new Parametro("Nombre", pobjCarrera.Nombre);
            Parametro tmp03 = new Parametro("Id_director_academico", Convert.ToString(pobjCarrera.Id_director_academico));

            //llenado de la lista
            parametros.Add(tmp01);
            parametros.Add(tmp02);
            parametros.Add(tmp02);
        

            //Sentencia sql
            String sql = "INSERT INTO TCarrera (Codigo, Nombre, Id_director_academico) VALUES(Codigo, Nombre, Id_director_academico)";
            try
            {
                AD.ejecutarSQL(sql, parametros);
            }
            catch (Exception e)
            {

            }

        }
        }
    }


