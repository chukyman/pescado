using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Clases
{
    /// <summary>
    /// Clase Usuario
    /// </summary>
    /// <remarks>LeafSoft Roberto Cordero</remarks>
    public class Usuario
    {
        #region "Atributos"
       
        private string _cedula;
        private string _nombre;
        private string _apellido1;
        private string _apellido2;
        private string _correo;
        private char _genero;
        private int _idRol;
        #endregion

        #region "Constructores"
       
        /// <summary>
        /// Constructor de la clase Usaurio
        /// </summary>
        public Usuario(){}

        /// <summary>
        /// Construtor que no recibe el id rol
        /// </summary>
        /// <param name="pcedula">Cedula</param>
        /// <param name="pnombre">Nombre</param>
        /// <param name="papellido1">Primer apellido</param>
        /// <param name="papellido2">Segundo apellido</param>
        /// <param name="pcorreo">Correo Eletronico</param>
        /// <param name="pgnero">Genero del usuario</param>
        public Usuario(string pcedula, string pnombre, string papellido1, 
                       string papellido2, string pcorreo, char pgnero)
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
        public Usuario(string pcedula, string pnombre, string papellido1, string papellido2,
                       string pcorreo, char pgnero, int pidRol)
        {
            Cedula = pcedula;
            Nombre = pnombre;
            Apellido1 = papellido1;
            Apellido2 = papellido2;
            Correo = pcorreo;
            Genero = pgnero;
            IdRol = pidRol;
        }
        
        #endregion
        
        #region "Set/Get"

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
        public char Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        /// <summary>
        /// Obtiene y Establece el rol del usuario (Roles= "" , "" , "" ,"" ,"") 
        /// </summary>
        public int IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        #endregion
        
    }
}
