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

        /// <summary>
        /// Cadena de caracteres que contiene el String de conexion
        /// </summary>
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

        /// <summary>
        /// Método que abre la conexión con la configuración dada
        /// </summary>
        /// <returns></returns>
        public SqlConnection getConection()
        {
            return new SqlConnection(SqlCadena);
        }


        /// <summary>
        /// Método que ejecuta sentencias como insert, update y delete.
        /// No devuelve resultados
        /// </summary>
        /// <param name="psqlCadena"></param>
        /// <param name="parametros"></param>
        public void ejecutarSQL_NoRetorna(String psqlCadena, List<Parametro> parametros)
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
        
        /// <summary>
        /// Método que ejecuta un procedimiento almacenado con parámetros 
        /// </summary>
        /// <param name="psp"></param>
        /// <param name="pparametros"></param>
        /// <returns>DataReader</returns>
        public SqlDataReader ejecutarSP_Retorna(String psp, List<Parametro> pparametros)
        {
            //Se crea el command
            SqlCommand cmd;
            String nombre;
            
            //Llama al metodo getConection para asi traer la cadena de conexion.
            SqlConnection conexion = getConection();
            
            //Se instancia el command
            cmd = new SqlCommand();
            
            //Al command se le asigna la cadena de conexion que retorna el método getConection()
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

                //si la conexión no está abierta, se abre
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
            //ejecuta el command y lo retorna en forma de DataReader
            return cmd.ExecuteReader();
            //Cierra la conexion
            cmd.Connection.Close();
        }


        /// <summary>
        /// Ejecuta un procedimiento almacenado sin parámetros
        /// </summary>
        /// <param name="pSQL"></param>
        /// <returns>DataReader</returns>
        public SqlDataReader ejecutarSPListar(String pSQL)
        {
            //Se crea el command
            SqlCommand cmd;

            //Llama al metodo getConection para asi traer la cadena de conexion.
            SqlConnection conexion = getConection();

            //Se instancia el command
            cmd = new SqlCommand();

            //Al command se le asigna la cadena de conexion que retorna el método getConection()
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
