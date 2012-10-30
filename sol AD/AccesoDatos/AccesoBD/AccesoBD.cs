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
        public SqlDataReader ejecutarSP_Retorna(String psp, List<Parametro> pparametros)
        {
            SqlCommand cmd;
            String nombre;
            SqlConnection conexion = getConection();
            //Se crea el comando
            cmd = new SqlCommand();
            cmd.Connection = conexion;

            //transformar la colección de parámetros en SqlParameter...
            foreach (Parametro objParametro in pparametros)
            {
                nombre = "@" + objParametro.Nombre;
                cmd.Parameters.AddWithValue(nombre, objParametro.Dato);
            }
            
            try
            {
                //se indica que se va a ejecutar un store procedure...
                cmd.CommandType = CommandType.StoredProcedure;
                //Se asigna el sp a ejecutar
                cmd.CommandText = psp;
                cmd.Connection.Open();
                
            }
            catch (Exception e)
            {
                throw e;
            }
            return cmd.ExecuteReader();
        }


        /// <summary>
        /// Prueba listar Roberto
        /// </summary>
        /// <param name="pSQL"></param>
        /// <returns></returns>
        public SqlDataReader ejecutarSPListar(String pSQL)
        {
            SqlCommand cmd;
            SqlConnection conexion = getConection();
            //Se crea el comando
            cmd = new SqlCommand();
            cmd.Connection = conexion;

            //Se indica el tipo del commandty a procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = pSQL;

            //si la conexión no está abierta, se abre
            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }

            return cmd.ExecuteReader();
            cmd.Connection.Close();
        }
    }
}
