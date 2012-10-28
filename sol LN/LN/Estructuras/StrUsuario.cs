using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Estructuras
{
 
        /// <summary>
        /// Clase Estructura Usuario
        /// </summary>
        /// <remarks>LeafSoft Roberto Cordero</remarks>
       public class StrUsuario
        {

            #region "Atributos"

            private string _cedula;
            private string _nombre;
            private string _apellido1;
            private string _apellido2;
            private string _correo;
            private string _genero;
            private string _idRol;
            private string _pnombreRol;
            #endregion

            #region "constructores"

            /// <summary>
            /// Constructor de la clase Usaurio
            /// </summary>
            public StrUsuario() { }

            /// <summary>
            /// Construtor que no recibe el id rol
            /// </summary>
            /// <param name="pcedula">Cedula</param>
            /// <param name="pnombre">Nombre</param>
            /// <param name="papellido1">Primer apellido</param>
            /// <param name="papellido2">Segundo apellido</param>
            /// <param name="pcorreo">Correo Eletronico</param>
            /// <param name="pgnero">Genero del usuario</param>
            public StrUsuario(string pcedula, string pnombre, string papellido1,
                           string papellido2, string pcorreo, string pgnero)
            {
                Cedula = pcedula;
                Nombre = pnombre;
                Apellido1 = papellido1;
                Apellido2 = papellido2;
                Correo = pcorreo;
                Genero = pgnero;
            }

            /// <summary>
            /// Constructor que recibe los parametros del usuario.
            /// </summary>
            /// <param name="pcedula">Cedula</param>
            /// <param name="pnombre">Nombre</param>
            /// <param name="papellido1">Primer Apellido</param>
            /// <param name="papellido2">Segundo Apellido</param>
            /// <param name="pcorreo">Correo Electronico</param>
            /// <param name="pgnero">Fenero</param>
            /// <param name="pidRol">Identificador del Rol</param>
            public StrUsuario(string pcedula, string pnombre, string papellido1, string papellido2,
                           string pcorreo, string pgnero, string pidRol)
            {
                Cedula = pcedula;
                Nombre = pnombre;
                Apellido1 = papellido1;
                Apellido2 = papellido2;
                Correo = pcorreo;
                Genero = pgnero;
                IdRol = pidRol;
            }

            public StrUsuario(string pidRol, string pnombre,   string papellido1, string papellido2,
                              string pcedula, string pcorreo, string pgnero, string pnombreRol)
            {
                IdRol = pidRol;
                Nombre = pnombre;
                Apellido1 = papellido1;
                Apellido2 = papellido2;
                Cedula = pcedula;
                Correo = pcorreo;
                Genero = pgnero;
                NombreRol = pnombreRol;
            }


            #endregion

            #region "Set/Get"


            /// <summary>
            /// Obtiene y Establece el rol del usuario (Roles= "" , "" , "" ,"" ,"") 
            /// </summary>
            public string IdRol
            {
                get { return _idRol; }
                set { _idRol = value; }
            }

            /// <summary>
            /// Obtiene y Establece la cèdula
            /// </summary>
            public string Cedula
            {
                get { return _cedula; }
                set { _cedula = value; }
            }

            /// <summary>
            /// Obtiene y Establece el nombre
            /// </summary>
            public string Nombre
            {
                get { return _nombre; }
                set { _nombre = value; }
            }

            /// <summary>
            /// Obtiene y Establece primer apellido
            /// </summary>
            public string Apellido1
            {
                get { return _apellido1; }
                set { _apellido1 = value; }
            }

            /// <summary>
            /// Obtiene y Establece el segundo apellido
            /// </summary>
            public string Apellido2
            {
                get { return _apellido2; }
                set { _apellido2 = value; }
            }

            /// <summary>
            /// Obtiene y Establece el correo electronico del usuario
            /// </summary>
            public string Correo
            {
                get { return _correo; }
                set { _correo = value; }
            }

            /// <summary>
            /// Obtiene y Establece el genero si es 0 = hombre = 1, mujer = 2 
            /// </summary>
            public string Genero
            {
                get { return _genero; }
                set { _genero = value; }
            }

            /// <summary>
            /// 
            /// </summary>
            public string NombreRol
            {
                get { return _pnombreRol; }
                set { _pnombreRol = value; }
            }

      

            #endregion

        }
    }
