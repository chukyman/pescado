using System;
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
   public class RolPersistente
    {

       AccesoBD AD = new AccesoBD();


       public List<StrRol> listarRoles()
       {
           StrRol tmpRol = new StrRol();
           List<StrRol> listaRoles = new List<StrRol>();
           try
           {
               String cmdText;
               cmdText = Properties.Resources.PAListarRol;

               SqlDataReader reader = AD.ejecutarSPListar(cmdText);
               //recorror el data reader para ir creando las estructuras y agregarlas a la coleccion
               while (reader.Read())
               {
                   listaRoles.Add(new StrRol(
                   tmpRol.IdRol = reader.GetValue(0).ToString(),
                   tmpRol.NombreRol = reader.GetValue(1).ToString(),
                   tmpRol.NumeroRol = reader.GetValue(2).ToString()
                            
                   ));
               }
               reader.Close();
               return listaRoles;
           }
           catch (SqlException e)
           {
               throw e;
           }
       }



    }
}
