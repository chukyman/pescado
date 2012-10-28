using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class AccesoBD
    {
        
        //Atributos del objeto
        private String _sqlCadena = "";

        //Cadena de caracteres que contiene el String de conexion
        public String SqlCadena
        {
            get 
            {
                if (_sqlCadena == "")
                {
                    _sqlCadena = Properties.Settings.Default.Bd_CATec.ToString();
                }

                return _sqlCadena; 
            }
        }

        //método que abre una conexión con la 
        //configuración dada
        public SqlConnection getConection()
        {
            return new SqlConnection(SqlCadena);
        }

        /// <summary>
        /// Metodo que ejecuta los procedimientos almacenados
        /// /Metodo que devuelve resultados en un DataSet
        /// </summary>
        /// <param name="pstoreProced"></param>
        /// <param name="pparametros"></param>
        /// <returns>LeafSoft</returns>
        public SqlDataReader ejecutarProcedimiento(String pstoreProced, List<Parametro> pparametros)
        {
            SqlCommand cmd;
            String nombre;
            SqlConnection conexion = getConection();

            //Se crea el comando
            cmd = new SqlCommand();
            cmd.Connection = conexion;

            //Se sacan los parámetros
            foreach (Parametro objParametro in pparametros)
            {
                nombre = String.Format("@{0}", objParametro.Nombre);
                cmd.Parameters.AddWithValue(nombre, objParametro.Dato);
            }

            try
            {
                //Se indica el tipo del commandty a procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                //Se asigna el store procedure a ejecutar
                cmd.CommandText = pstoreProced;

                //si la conexión no está abierta, se abre
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            //Se cierra la conexion
            cmd.Connection.Close();
            //Ejecuta el comando y lo retorna
            return cmd.ExecuteReader();
                        
        }


        /// <summary>
        /// Métodos que ejecutan sentencias en la BD
        /// método que no devuelve resultados
        /// </summary>
        /// <param name="psqlCadena"></param>
        /// <param name="parametros"></param>
        public void ejecutarSQL(String psqlCadena, List<Parametro> parametros)
        {
            SqlCommand cmd;
            String nombre;

            //se crea el comando
            cmd= new SqlCommand();
            cmd.Connection= getConection();

            //Se sacan los parametros
            foreach (Parametro objParametro in parametros)
            {
                nombre= "@" + objParametro.Nombre;
                cmd.Parameters.AddWithValue(nombre, objParametro.Dato);
                psqlCadena= psqlCadena.Replace(objParametro.Nombre, nombre);
                
            }
            cmd.CommandText = psqlCadena;
            //si la conexión no está abierta, se abre
            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.ExecuteNonQuery(); //insert, update, delete
            cmd.Connection.Close();
        }
        
        //Metodo que devuelve resultados en un DataSet
        public SqlDataReader ejecutarSelect(String pSQL, List<Parametro> parametros)
        {
            SqlCommand cmd;
            String nombre;
            SqlConnection conexion= getConection();
            //Se crea el comando
            cmd=  new SqlCommand();
            cmd.Connection = conexion;

            //Se sacan los parámetros
            foreach (Parametro objParametro in parametros)
            {
                nombre = String.Format("@{0}", objParametro.Nombre);
                cmd.Parameters.AddWithValue(nombre, objParametro.Dato);
                pSQL = pSQL.Replace(objParametro.Nombre, nombre);
            }

            cmd.CommandText = pSQL;

            //si la conexión no está abierta, se abre
            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }

            return cmd.ExecuteReader();
        }

    }
}
