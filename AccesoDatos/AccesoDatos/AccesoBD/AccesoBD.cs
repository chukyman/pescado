using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos.Clases
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
                    _sqlCadena = Properties.Settings.Default.Bd_Proyecto2.ToString();
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

        //Metodo que ejecuta los procedimientos almacenados

        public SqlDataReader ejecutarProcedimiento(String psqlCadena)
        {
            SqlCommand cmd;

            //se crea el comando
            cmd = new SqlCommand();
            cmd.Connection = getConection();

            //Se le asigna el tipo store procedure al command type
            cmd.CommandType = CommandType.StoredProcedure;
            //Se asigna el parámetro psqlCadena el cual es el nombre del store procedure
            cmd.CommandText = psqlCadena;

            //si la conexión no está abierta, se abre
            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Connection.Close();

            return cmd.ExecuteReader();
        }


        //Métodos que ejecutan sentencias
        //en la BD
        //método que no devuelve resultados

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
