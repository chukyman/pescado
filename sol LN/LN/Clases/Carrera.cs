using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN.Clases
{    /// <summary>
    /// Clase Usuario
    /// </summary>
    /// <remarks>LeafSoft Julio Moreira</remarks>
    
        public class Carrera
        {

            //================================================================================
            // Atributos 
            //================================================================================

            private int _id_carrera;
            private string _codigo;
            private string _nombre;
            private int _id_director_academico;


            //private List<Curso> listaCursos;


            //================================================================================
            // Constructores
            //================================================================================

            public Carrera(int pid_carrera, String pcodigo, String pnombre, int pid_director_academico)
            {

                _id_carrera = pid_carrera;
                _codigo = pcodigo;
                _nombre = pnombre;
                _id_director_academico = pid_director_academico;
                // setlistaCursos(null);

            }


            public Carrera(String pcodigo, String pnombre, int pid_director_academico)
            {
                _codigo = pcodigo;
                _nombre = pnombre;
                _id_director_academico = pid_director_academico;
                // setlistaCursoso(null);

            }


            //================================================================================
            // Get &  Set
            //================================================================================


            public int Id_carrera
            {
                get { return _id_carrera; }
                set { _id_carrera= value; }
            }


            public String Codigo
            {
                get { return _codigo; }
                set { _codigo = value; }
            }

            public String Nombre
            {
                get { return _nombre; }
                set { _nombre = value; }
            }


            public int Id_director_academico
            {
                get { return _id_director_academico; }
                set { _id_director_academico = value; }
            }



            /*
            private List<Curso> ListaCursos
            {
                get { return listaCursos; }
                set { listaCursos = value; }
            }
            */
        }




    }

